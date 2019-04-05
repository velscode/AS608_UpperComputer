//version 1.0

using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

public class VCOM
{
    private SerialPort sport = new SerialPort();

    public int usablePortCnt = 0;                   //可用串口数量
    public string[] usablePort = new string[20];    //可用串口名称

    /// <summary>
    /// 设置串口名称
    /// </summary>
    /// <param name="name">串口名称</param>
    public void SetPortName(string name)
    {
        sport.PortName = name;
    }

    /// <summary>
    /// 设置串口波特率
    /// </summary>
    /// <param name="baudrate">波特率</param>
    public void SetBaudRate(Int32 baudrate)
    {
        if(baudrate < 0)
            return ;
        sport.BaudRate = baudrate;
    }

    /// <summary>
    /// 设置串口数据位长度
    /// </summary>
    /// <param name="databits">数据位长度</param>
    public void SetDataBits(Int16 databits)
    {
        if( databits < 0 )
            return ;
        sport.DataBits = databits;
    }

    /// <summary>
    /// 设置串口停止位长度
    /// </summary>
    /// <param name="stopbits"></param>
    /// <returns>true-设置成功 false-设置失败</returns>
    public bool SetStopBits(float stopbits)
    {
        if( stopbits < 0 )
            return false;

        if      (stopbits==0)   {sport.StopBits = StopBits.None;          return true;}
        else if (stopbits==1)   {sport.StopBits = StopBits.One;           return true;}
        else if (stopbits==1.5) {sport.StopBits = StopBits.OnePointFive;  return true;}
        else if (stopbits==2)   {sport.StopBits = StopBits.Two;           return true;}
        else
            return false;
    }

    /// <summary>
    /// 设置校验位
    /// </summary>
    /// <param name="parity">0-无校验 1-奇校验 2-偶校验</param>
    /// <returns>ture-设置成功 false-设置失败</returns>
    public bool SetParity( int parity )
    {
        if      (parity == 0) { sport.Parity = Parity.None; return true; }
        else if (parity == 1) { sport.Parity = Parity.Odd;  return true; }
        else if (parity == 2) { sport.Parity = Parity.Even; return true; }
        else
            return false;
    }

    /// <summary>
    /// 寻找可用的串口数量
    /// </summary>
    /// <returns>返回可用的串口数量，串口名称被保存在</returns>
    public int SearchPort()
    {
        usablePortCnt = 0;
        for (int i = 0; i < 20; i++)
        {
            try
            {
            SerialPort sport = new SerialPort("COM" + (i + 1).ToString());
            sport.Open();
            sport.Close();
            usablePort[usablePortCnt]=("COM" + (i + 1).ToString());
            usablePortCnt++;
            }
            catch (Exception)
            {
                continue;
            }
        }
        return usablePortCnt;
    }

    /// <summary>
    /// 打开串口
    /// </summary>
    /// <returns>true 打开成功</returns>
    public bool OpenPort()
    { 
        sport.ReadTimeout = -1;
        sport.RtsEnable = false;
        try
        { 
            sport.Open();
            return true;
        }
        catch 
        {
            return false;
        }

    }

    public int BytesToRead()
    { 
        return sport.BytesToRead;
    }

    public string Read()
    { 
        return sport.ReadExisting();
    }
    
    public byte ReadByte()
    { 
        return (byte)sport.ReadByte();
    }

    public bool Send(string str)
    {
        if(sport.IsOpen == true)
        { 
            sport.WriteLine(str);
            return true;
        }
        else
            return false;
    }

    public bool SendBytes(byte[] bytes)
    {
        if(sport.IsOpen == true)
        { 
            sport.Write(bytes,0,bytes.Length);
            return true;
        }
        else
            return false;
    }

    /// <summary>
    /// 向一个ComboBox控件中填充搜索到的可用串口名
    /// </summary>
    /// <param name="combobox">待填充的ComboBox控件</param>
    public void FillComboBox_UsablePort(ComboBox combobox)
    {
        combobox.Items.Clear();

        if(usablePortCnt!=0)
        { 
            for(int i = 0; i < usablePortCnt; i++)
            {
                combobox.Items.Add(usablePort[i]);
            }
        }
        else
             combobox.Items.Add("未找到串口");

        combobox.SelectedIndex = 0;
    }

    /// <summary>
    /// 向一个ComboBox控件中填充常用波特率
    /// </summary>
    /// <param name="combobox"></param>
    public void FillComboBox_BaudRate(ComboBox combobox)
    {
        combobox.Items.Clear();

        combobox.Items.Add("1200");
        combobox.Items.Add("2400");
        combobox.Items.Add("4800");
        combobox.Items.Add("9600");
        combobox.Items.Add("19200");
        combobox.Items.Add("38400");
        combobox.Items.Add("43000");
        combobox.Items.Add("56000");
        combobox.Items.Add("57600");
        combobox.Items.Add("115200");
        combobox.SelectedIndex = 9;
    }
}

