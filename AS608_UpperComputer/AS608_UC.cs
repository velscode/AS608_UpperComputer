using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

//version : beta 1.1.0

namespace AS608_UpperComputer
{
    public partial class AS608_UC : Form
    {
        int cnt=0;
        int PicX = 0, PicY = 0;
        VCOM vcom = new VCOM();

        Queue Recv_Buffer = new Queue(); 
        FileStream filestream;

        #region DataPackage_Struct

        class DataPackage
        { 
            public byte [] DeviceAddress = new byte[4];
            public byte    Type          ;
            public byte [] Length        = new byte[2];
            public byte    Command       ;
            public byte    Ensure        ;
            public byte [] Data          = new byte[1024];
            public byte [] Summary       = new byte[2];
        };

        #endregion

        #region AS608_常用命令

        byte[] AS608_GetImage = {0xEF,0x01,0xFF,0xFF,0xFF,0xFF,0x01,0x00,0x03,0x01,0x00,0x05};
        byte[] AS608_UpImage = {0xEF,0x01,0xFF,0xFF,0xFF,0xFF,0x01,0x00,0x03,0x0a,0x00,0x0E};
        byte[] AS608_ReadSysPara = {0xEF,0x01,0xFF,0xFF,0xFF,0xFF,0x01,0x00,0x03,0x0f,0x00,0x13};
        byte[] AS608_GenChar1= {0xEF,0x01,0xFF,0xFF,0xFF,0xFF,0x01,0x00,0x04,0x02,0x01,0x00,0x08};
        byte[] AS608_GenChar2= {0xEF,0x01,0xFF,0xFF,0xFF,0xFF,0x01,0x00,0x04,0x02,0x02,0x00,0x09};
        byte[] AS608_Match= {0xEF,0x01,0xFF,0xFF,0xFF,0xFF,0x01,0x00,0x03,0x03,0x00,0x07};
        byte[] AS608_UpChar1= {0xEF,0x01,0xFF,0xFF,0xFF,0xFF,0x01,0x00,0x04,0x08,0x01,0x00,0x0E};
        byte[] AS608_UpChar2= {0xEF,0x01,0xFF,0xFF,0xFF,0xFF,0x01,0x00,0x04,0x08,0x02,0x00,0x0F};

        #endregion

        #region 标志位

        bool f_GetImage = false;
        bool f_UpImage = false;
        bool f_ReadSysPara = false;
        bool f_GenChar = false;
        bool f_Match = false;
        bool f_UpChar=false;

        #endregion

        public AS608_UC()
        {
            InitializeComponent();

            vcom.SearchPort();
            vcom.FillComboBox_UsablePort(comboBox_PortName);
            vcom.FillComboBox_BaudRate(comboBox_BaudRate);

            vcom.SetDataBits(8);
            vcom.SetStopBits(1);
            vcom.SetParity(0);
        }

        private void button_OpenPort_Click(object sender, EventArgs e)
        {
            vcom.SetPortName(comboBox_PortName.Text);
            vcom.SetBaudRate(Convert.ToInt32(comboBox_BaudRate.Text));
            vcom.OpenPort();
            timer_Debug.Enabled=true;
            comboBox_BaudRate.Enabled=false;
            comboBox_PortName.Enabled=false;
            button_OpenPort.Enabled  =false;

            vcom.SendBytes(AS608_ReadSysPara);
            f_ReadSysPara=true;
        }

        private void button_GetImage_Click(object sender, EventArgs e)
        {
            vcom.SendBytes(AS608_GetImage);
            f_GetImage = true;
        }

        private void timer_Debug_Tick(object sender, EventArgs e)
        {
            timer_Debug.Enabled=false;
            while(vcom.BytesToRead()!=0)
            { 
                byte tempbyte = vcom.ReadByte();
                Recv_Buffer.Enqueue(tempbyte);
            }

            if (Recv_Buffer.Count == 0) { 
                timer_Debug.Enabled =true;
            return;
            }
                

            while( (byte)Recv_Buffer.Dequeue() != 0xEF )    //循环找到第一个包头
                ;
            if( (byte)Recv_Buffer.Dequeue() == 0x01 )
            { 
                DataPackage dp = new DataPackage();
                
                for (int i = 0; i < 4; i++ )                //读取芯片地址
                {
                    dp.DeviceAddress[i] = (byte)Recv_Buffer.Dequeue();
                }
                
                dp.Type = (byte)Recv_Buffer.Dequeue();    //读取包标识（类型）

                for (int i = 0; i < 2; i++ )                //读取包长度
                {
                    dp.Length[i] = (byte)Recv_Buffer.Dequeue();
                }

                //处理应答包=======================================================
                if( dp.Type == 0x07 )
                { 
                    dp.Ensure = (byte)Recv_Buffer.Dequeue();  //读取确认码
                    for( int i = 0; i < dp.Length[0] * 256 + dp.Length[1] - 3; i++ )
                    { 
                        dp.Data[i] = (byte)Recv_Buffer.Dequeue();    //读取返回参数
                    }

                    #region GetImage
                    if ( f_GetImage == true )
                    { 
                        if(dp.Ensure == 0x00) textBox_Notice.Text+="录入成功！\r\n";
                        else if(dp.Ensure == 0x01) textBox_Notice.Text+="收包有错！\r\n"; 
                        else if(dp.Ensure == 0x02) textBox_Notice.Text+="传感器上无手指！\r\n"; 
                        else if(dp.Ensure == 0x03) textBox_Notice.Text+="录入不成功！\r\n"; 
                        else
                            ;

                        f_GetImage = false;
                    }
                    #endregion
                    #region GenChar
                    if ( f_GenChar == true )
                    { 
                        if(dp.Ensure == 0x00) textBox_Notice.Text+="特征生成成功！\r\n";
                        else if(dp.Ensure == 0x01) textBox_Notice.Text+="收包有错！\r\n"; 
                        else if(dp.Ensure == 0x06) textBox_Notice.Text+="指纹太乱无法生成特征！\r\n"; 
                        else if(dp.Ensure == 0x07) textBox_Notice.Text+="指纹图像正常，但特征点太少而生不成特征！\r\n"; 
                        else if(dp.Ensure == 0x15) textBox_Notice.Text+="图像缓冲区内没有有效原始图而生不成图像！\r\n"; 
                        else
                            ;

                        f_GenChar = false;
                    }
                    #endregion
                    #region UpImage
                    if (f_UpImage == true)
                    { 
                        if(dp.Type == 0x07 && dp.Ensure == 0x00)
                        { 
                            PicX = PicY = 0;
                        }
                    }
                    #endregion
                    #region ReadSysPara
                    if ( f_ReadSysPara == true )
                    { 
                        label_Capacity.Text = "指纹库容量："+(dp.Data[4]*256+dp.Data[5]).ToString();
                        label_SafetyLevel.Text = "安全等级："+(dp.Data[6]*256+dp.Data[7]).ToString();
                        comboBox_DataPackageSize.SelectedIndex = dp.Data[12]*256+dp.Data[13];

                        f_ReadSysPara = false;
                    }
                    #endregion
                    #region Match
                    if ( f_Match == true )
                    { 
                        if(dp.Ensure == 0x00) textBox_Notice.Text+="指纹匹配！\r\n";
                        else if(dp.Ensure == 0x01) textBox_Notice.Text+="收包有错！\r\n"; 
                        else if(dp.Ensure == 0x08) textBox_Notice.Text+="指纹不匹配！\r\n"; 
                        else
                            ;

                        f_Match = false;
                    }
                    #endregion
                    #region UpChar
                    if (f_UpChar == true)
                    { 
                        cnt=0;
                        textBox_Recv.Text = "";
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Filter = "指纹模板文件(*.fpc)|*.fpc";
                        sfd.RestoreDirectory=true;
                        if(sfd.ShowDialog()==DialogResult.OK)
                        { 
                            filestream = new FileStream(sfd.FileName,FileMode.Create,FileAccess.Write);
                        }
                    }
                    #endregion

                }
                //处理数据包=======================================================
                else if (dp.Type == 0x02 || dp.Type == 0x08)
                {   
                    for( int i = 0; i < dp.Length[0] * 256 + dp.Length[1] - 2; i++ )
                    { 
                        dp.Data[i] = (byte)Recv_Buffer.Dequeue();    //读取返回参数
                    }

                    #region UpImage
                    if ( f_UpImage == true )
                    { 
                        Bitmap bm = new Bitmap(pictureBox_Image.Image);
                        if(PicY%2==0)
                        { 
                            for(int i = 0; i < 128; i++)
                            { 
                                bm.SetPixel(i,PicY/2,Color.FromArgb(Convert.ToInt32(dp.Data[i]),Convert.ToInt32(dp.Data[i]),Convert.ToInt32(dp.Data[i])));  
                            }
                            pictureBox_Image.Image = bm;
                        }
                        PicY++;
                        if(dp.Type == 0x08)
                        { 
                            f_UpImage=false;
                        }
                    }
                    #endregion

                    #region UpChar
                    if(f_UpChar==true)
                    { 
                        textBox_Recv.Text += "\r\n\r\n";
                        for( int i = 0; i < dp.Length[0] * 256 + dp.Length[1] - 2; i++ ,cnt++)
                        { 
                            if(cnt==384)
                            { 
                                f_UpChar = false;
                                filestream.Close();
                                break;
                            }
                            filestream.WriteByte(dp.Data[i]);
                            textBox_Recv.Text += dp.Data[i].ToString("X2")+" ";    //读取返回参数
                        }
                    }
                    #endregion
                }
                else
                { 
                    timer_Debug.Enabled=true;
                    return;
                }

                for (int i = 0; i < 2; i++ )                //读取包长度
                {
                    dp.Summary[i] = (byte)Recv_Buffer.Dequeue();
                }
            }
            else
            { 
                timer_Debug.Enabled=true;
                return;
            }
            timer_Debug.Enabled=true;
        }

        private void button_UpImage_Click(object sender, EventArgs e)
        {
            vcom.SendBytes(AS608_UpImage);
            f_UpImage = true;
        }

         #region DEBUG_PART

        private void button_ClearTextBoxRecv_Click(object sender, EventArgs e)
        {
            textBox_Recv.Text = "";
        }
        
        private void button_Debug1_Click(object sender, EventArgs e)
        {

        }

        private void button_Debug2_Click(object sender, EventArgs e)
        {
            
        }

        private void button_Debug3_Click(object sender, EventArgs e)
        {

        }

        private void button_Debug4_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void button_GenChar1_Click(object sender, EventArgs e)
        {
            vcom.SendBytes(AS608_GenChar1);
            f_GenChar=true;
        }

        private void button_GenChar2_Click(object sender, EventArgs e)
        {
            vcom.SendBytes(AS608_GenChar2);
            f_GenChar=true;
        }

        private void button_Match_Click(object sender, EventArgs e)
        {
            vcom.SendBytes(AS608_Match);
            f_Match=true;
        }

        private void button_UpChar1_Click(object sender, EventArgs e)
        {
            vcom.SendBytes(AS608_UpChar1);
            f_UpChar = true;
        }

        private void button_UpChar2_Click(object sender, EventArgs e)
        {
            vcom.SendBytes(AS608_UpChar2);
            f_UpChar = true;
        }

        private void comboBox_DataPackageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte[] cmd = {0xEF,0X01,0XFF,0XFF,0XFF,0XFF,0X01,0X00,0X05,0X0E,0X06,(byte)comboBox_DataPackageSize.SelectedIndex,0X00,(byte)(0X1A+comboBox_DataPackageSize.SelectedIndex)};
            vcom.SendBytes(cmd);
        }
    }
}
