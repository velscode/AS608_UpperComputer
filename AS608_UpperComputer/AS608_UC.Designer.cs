namespace AS608_UpperComputer
{
    partial class AS608_UC
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AS608_UC));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_OpenPort = new System.Windows.Forms.Button();
            this.comboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_PortName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_ClearTextBoxRecv = new System.Windows.Forms.Button();
            this.textBox_Recv = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_Debug4 = new System.Windows.Forms.Button();
            this.button_Debug3 = new System.Windows.Forms.Button();
            this.button_Debug2 = new System.Windows.Forms.Button();
            this.button_Debug1 = new System.Windows.Forms.Button();
            this.textBox_Notice = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_GetImage = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_GenChar2 = new System.Windows.Forms.Button();
            this.button_GenChar1 = new System.Windows.Forms.Button();
            this.button_UpImage = new System.Windows.Forms.Button();
            this.timer_Debug = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_Image = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label_DatapackageSize = new System.Windows.Forms.Label();
            this.label_SafetyLevel = new System.Windows.Forms.Label();
            this.label_Capacity = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button_Match = new System.Windows.Forms.Button();
            this.button_UpChar1 = new System.Windows.Forms.Button();
            this.button_UpChar2 = new System.Windows.Forms.Button();
            this.comboBox_DataPackageSize = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_OpenPort);
            this.groupBox1.Controls.Add(this.comboBox_BaudRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_PortName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口配置";
            // 
            // button_OpenPort
            // 
            this.button_OpenPort.Location = new System.Drawing.Point(12, 80);
            this.button_OpenPort.Name = "button_OpenPort";
            this.button_OpenPort.Size = new System.Drawing.Size(146, 23);
            this.button_OpenPort.TabIndex = 4;
            this.button_OpenPort.Text = "打开串口";
            this.button_OpenPort.UseVisualStyleBackColor = true;
            this.button_OpenPort.Click += new System.EventHandler(this.button_OpenPort_Click);
            // 
            // comboBox_BaudRate
            // 
            this.comboBox_BaudRate.FormattingEnabled = true;
            this.comboBox_BaudRate.Location = new System.Drawing.Point(69, 48);
            this.comboBox_BaudRate.Name = "comboBox_BaudRate";
            this.comboBox_BaudRate.Size = new System.Drawing.Size(89, 20);
            this.comboBox_BaudRate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "波特率";
            // 
            // comboBox_PortName
            // 
            this.comboBox_PortName.FormattingEnabled = true;
            this.comboBox_PortName.Location = new System.Drawing.Point(69, 20);
            this.comboBox_PortName.Name = "comboBox_PortName";
            this.comboBox_PortName.Size = new System.Drawing.Size(89, 20);
            this.comboBox_PortName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口选择";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_ClearTextBoxRecv);
            this.groupBox2.Controls.Add(this.textBox_Recv);
            this.groupBox2.Location = new System.Drawing.Point(12, 401);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收数据";
            // 
            // button_ClearTextBoxRecv
            // 
            this.button_ClearTextBoxRecv.Location = new System.Drawing.Point(6, 156);
            this.button_ClearTextBoxRecv.Name = "button_ClearTextBoxRecv";
            this.button_ClearTextBoxRecv.Size = new System.Drawing.Size(303, 35);
            this.button_ClearTextBoxRecv.TabIndex = 1;
            this.button_ClearTextBoxRecv.Text = "清除接收区";
            this.button_ClearTextBoxRecv.UseVisualStyleBackColor = true;
            this.button_ClearTextBoxRecv.Click += new System.EventHandler(this.button_ClearTextBoxRecv_Click);
            // 
            // textBox_Recv
            // 
            this.textBox_Recv.Location = new System.Drawing.Point(6, 18);
            this.textBox_Recv.Multiline = true;
            this.textBox_Recv.Name = "textBox_Recv";
            this.textBox_Recv.Size = new System.Drawing.Size(303, 132);
            this.textBox_Recv.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_Debug4);
            this.groupBox3.Controls.Add(this.button_Debug3);
            this.groupBox3.Controls.Add(this.button_Debug2);
            this.groupBox3.Controls.Add(this.button_Debug1);
            this.groupBox3.Location = new System.Drawing.Point(336, 410);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(181, 182);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "调试按钮";
            // 
            // button_Debug4
            // 
            this.button_Debug4.Location = new System.Drawing.Point(92, 100);
            this.button_Debug4.Name = "button_Debug4";
            this.button_Debug4.Size = new System.Drawing.Size(80, 74);
            this.button_Debug4.TabIndex = 3;
            this.button_Debug4.Text = "Debug 4";
            this.button_Debug4.UseVisualStyleBackColor = true;
            this.button_Debug4.Click += new System.EventHandler(this.button_Debug4_Click);
            // 
            // button_Debug3
            // 
            this.button_Debug3.Location = new System.Drawing.Point(6, 100);
            this.button_Debug3.Name = "button_Debug3";
            this.button_Debug3.Size = new System.Drawing.Size(80, 74);
            this.button_Debug3.TabIndex = 2;
            this.button_Debug3.Text = "Debug 3";
            this.button_Debug3.UseVisualStyleBackColor = true;
            this.button_Debug3.Click += new System.EventHandler(this.button_Debug3_Click);
            // 
            // button_Debug2
            // 
            this.button_Debug2.Location = new System.Drawing.Point(92, 20);
            this.button_Debug2.Name = "button_Debug2";
            this.button_Debug2.Size = new System.Drawing.Size(80, 74);
            this.button_Debug2.TabIndex = 1;
            this.button_Debug2.Text = "Debug 2";
            this.button_Debug2.UseVisualStyleBackColor = true;
            this.button_Debug2.Click += new System.EventHandler(this.button_Debug2_Click);
            // 
            // button_Debug1
            // 
            this.button_Debug1.Location = new System.Drawing.Point(6, 20);
            this.button_Debug1.Name = "button_Debug1";
            this.button_Debug1.Size = new System.Drawing.Size(80, 74);
            this.button_Debug1.TabIndex = 0;
            this.button_Debug1.Text = "Debug 1";
            this.button_Debug1.UseVisualStyleBackColor = true;
            this.button_Debug1.Click += new System.EventHandler(this.button_Debug1_Click);
            // 
            // textBox_Notice
            // 
            this.textBox_Notice.Location = new System.Drawing.Point(6, 20);
            this.textBox_Notice.Multiline = true;
            this.textBox_Notice.Name = "textBox_Notice";
            this.textBox_Notice.Size = new System.Drawing.Size(304, 159);
            this.textBox_Notice.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_Notice);
            this.groupBox4.Location = new System.Drawing.Point(11, 210);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(319, 185);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "消息";
            // 
            // button_GetImage
            // 
            this.button_GetImage.Location = new System.Drawing.Point(6, 19);
            this.button_GetImage.Name = "button_GetImage";
            this.button_GetImage.Size = new System.Drawing.Size(80, 44);
            this.button_GetImage.TabIndex = 5;
            this.button_GetImage.Text = "读取指纹";
            this.button_GetImage.UseVisualStyleBackColor = true;
            this.button_GetImage.Click += new System.EventHandler(this.button_GetImage_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button_UpChar2);
            this.groupBox5.Controls.Add(this.button_UpChar1);
            this.groupBox5.Controls.Add(this.button_Match);
            this.groupBox5.Controls.Add(this.button_GenChar2);
            this.groupBox5.Controls.Add(this.button_GenChar1);
            this.groupBox5.Controls.Add(this.button_UpImage);
            this.groupBox5.Controls.Add(this.button_GetImage);
            this.groupBox5.Location = new System.Drawing.Point(336, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(181, 383);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "模块操作";
            // 
            // button_GenChar2
            // 
            this.button_GenChar2.Location = new System.Drawing.Point(92, 69);
            this.button_GenChar2.Name = "button_GenChar2";
            this.button_GenChar2.Size = new System.Drawing.Size(80, 44);
            this.button_GenChar2.TabIndex = 8;
            this.button_GenChar2.Text = "生成特征2";
            this.button_GenChar2.UseVisualStyleBackColor = true;
            this.button_GenChar2.Click += new System.EventHandler(this.button_GenChar2_Click);
            // 
            // button_GenChar1
            // 
            this.button_GenChar1.Location = new System.Drawing.Point(6, 69);
            this.button_GenChar1.Name = "button_GenChar1";
            this.button_GenChar1.Size = new System.Drawing.Size(80, 44);
            this.button_GenChar1.TabIndex = 7;
            this.button_GenChar1.Text = "生成特征1\r\n";
            this.button_GenChar1.UseVisualStyleBackColor = true;
            this.button_GenChar1.Click += new System.EventHandler(this.button_GenChar1_Click);
            // 
            // button_UpImage
            // 
            this.button_UpImage.Location = new System.Drawing.Point(92, 20);
            this.button_UpImage.Name = "button_UpImage";
            this.button_UpImage.Size = new System.Drawing.Size(80, 44);
            this.button_UpImage.TabIndex = 6;
            this.button_UpImage.Text = "上传图像";
            this.button_UpImage.UseVisualStyleBackColor = true;
            this.button_UpImage.Click += new System.EventHandler(this.button_UpImage_Click);
            // 
            // timer_Debug
            // 
            this.timer_Debug.Interval = 1;
            this.timer_Debug.Tick += new System.EventHandler(this.timer_Debug_Tick);
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Image.Image")));
            this.pictureBox_Image.Location = new System.Drawing.Point(6, 29);
            this.pictureBox_Image.Name = "pictureBox_Image";
            this.pictureBox_Image.Size = new System.Drawing.Size(128, 144);
            this.pictureBox_Image.TabIndex = 12;
            this.pictureBox_Image.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBox_DataPackageSize);
            this.groupBox6.Controls.Add(this.label_DatapackageSize);
            this.groupBox6.Controls.Add(this.label_SafetyLevel);
            this.groupBox6.Controls.Add(this.label_Capacity);
            this.groupBox6.Location = new System.Drawing.Point(11, 130);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(170, 74);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "系统参数";
            // 
            // label_DatapackageSize
            // 
            this.label_DatapackageSize.AutoSize = true;
            this.label_DatapackageSize.Location = new System.Drawing.Point(18, 54);
            this.label_DatapackageSize.Name = "label_DatapackageSize";
            this.label_DatapackageSize.Size = new System.Drawing.Size(77, 12);
            this.label_DatapackageSize.TabIndex = 2;
            this.label_DatapackageSize.Text = "数据包大小：";
            // 
            // label_SafetyLevel
            // 
            this.label_SafetyLevel.AutoSize = true;
            this.label_SafetyLevel.Location = new System.Drawing.Point(30, 37);
            this.label_SafetyLevel.Name = "label_SafetyLevel";
            this.label_SafetyLevel.Size = new System.Drawing.Size(71, 12);
            this.label_SafetyLevel.TabIndex = 1;
            this.label_SafetyLevel.Text = "安全等级：0";
            // 
            // label_Capacity
            // 
            this.label_Capacity.AutoSize = true;
            this.label_Capacity.Location = new System.Drawing.Point(18, 20);
            this.label_Capacity.Name = "label_Capacity";
            this.label_Capacity.Size = new System.Drawing.Size(83, 12);
            this.label_Capacity.TabIndex = 0;
            this.label_Capacity.Text = "指纹库容量：0";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pictureBox_Image);
            this.groupBox7.Location = new System.Drawing.Point(187, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(143, 192);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "指纹图像";
            // 
            // button_Match
            // 
            this.button_Match.Location = new System.Drawing.Point(6, 118);
            this.button_Match.Name = "button_Match";
            this.button_Match.Size = new System.Drawing.Size(80, 44);
            this.button_Match.TabIndex = 9;
            this.button_Match.Text = "对比指纹";
            this.button_Match.UseVisualStyleBackColor = true;
            this.button_Match.Click += new System.EventHandler(this.button_Match_Click);
            // 
            // button_UpChar1
            // 
            this.button_UpChar1.Location = new System.Drawing.Point(6, 168);
            this.button_UpChar1.Name = "button_UpChar1";
            this.button_UpChar1.Size = new System.Drawing.Size(80, 44);
            this.button_UpChar1.TabIndex = 10;
            this.button_UpChar1.Text = "上传特征1";
            this.button_UpChar1.UseVisualStyleBackColor = true;
            this.button_UpChar1.Click += new System.EventHandler(this.button_UpChar1_Click);
            // 
            // button_UpChar2
            // 
            this.button_UpChar2.Location = new System.Drawing.Point(92, 168);
            this.button_UpChar2.Name = "button_UpChar2";
            this.button_UpChar2.Size = new System.Drawing.Size(80, 44);
            this.button_UpChar2.TabIndex = 11;
            this.button_UpChar2.Text = "上传特征2";
            this.button_UpChar2.UseVisualStyleBackColor = true;
            this.button_UpChar2.Click += new System.EventHandler(this.button_UpChar2_Click);
            // 
            // comboBox_DataPackageSize
            // 
            this.comboBox_DataPackageSize.FormattingEnabled = true;
            this.comboBox_DataPackageSize.Items.AddRange(new object[] {
            "32Bytes",
            "64Bytes",
            "128Bytes",
            "256Bytes"});
            this.comboBox_DataPackageSize.Location = new System.Drawing.Point(90, 50);
            this.comboBox_DataPackageSize.Name = "comboBox_DataPackageSize";
            this.comboBox_DataPackageSize.Size = new System.Drawing.Size(74, 20);
            this.comboBox_DataPackageSize.TabIndex = 3;
            this.comboBox_DataPackageSize.SelectedIndexChanged += new System.EventHandler(this.comboBox_DataPackageSize_SelectedIndexChanged);
            // 
            // AS608_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 619);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AS608_UC";
            this.Text = "AS608指纹识别模块上位机";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_OpenPort;
        private System.Windows.Forms.ComboBox comboBox_BaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_PortName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_Recv;
        private System.Windows.Forms.Button button_ClearTextBoxRecv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_Debug4;
        private System.Windows.Forms.Button button_Debug3;
        private System.Windows.Forms.Button button_Debug2;
        private System.Windows.Forms.Button button_Debug1;
        private System.Windows.Forms.TextBox textBox_Notice;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_GetImage;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Timer timer_Debug;
        private System.Windows.Forms.Button button_UpImage;
        private System.Windows.Forms.PictureBox pictureBox_Image;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label_DatapackageSize;
        private System.Windows.Forms.Label label_SafetyLevel;
        private System.Windows.Forms.Label label_Capacity;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button_GenChar2;
        private System.Windows.Forms.Button button_GenChar1;
        private System.Windows.Forms.Button button_Match;
        private System.Windows.Forms.Button button_UpChar2;
        private System.Windows.Forms.Button button_UpChar1;
        private System.Windows.Forms.ComboBox comboBox_DataPackageSize;

    }
}

