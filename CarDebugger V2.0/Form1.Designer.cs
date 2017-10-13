namespace CarDebugger_V2._0
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxBAUD = new System.Windows.Forms.ComboBox();
            this.OpenCom = new System.Windows.Forms.CheckBox();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxStop = new System.Windows.Forms.ComboBox();
            this.comboBoxData = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ReceiveArea = new System.Windows.Forms.GroupBox();
            this.UndefinedValue = new System.Windows.Forms.TextBox();
            this.RDead = new System.Windows.Forms.TextBox();
            this.LDead = new System.Windows.Forms.TextBox();
            this.RDuty = new System.Windows.Forms.TextBox();
            this.LDuty = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.TurnValue = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.SpeedI = new System.Windows.Forms.TextBox();
            this.SpeedP = new System.Windows.Forms.TextBox();
            this.AngleD = new System.Windows.Forms.TextBox();
            this.AngleP = new System.Windows.Forms.TextBox();
            this.CarSpeed = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CarAngle = new System.Windows.Forms.TextBox();
            this.ZAngleSpeed = new System.Windows.Forms.TextBox();
            this.ZAngle = new System.Windows.Forms.TextBox();
            this.YAngle = new System.Windows.Forms.TextBox();
            this.XAngle = new System.Windows.Forms.TextBox();
            this.RightSpeed = new System.Windows.Forms.TextBox();
            this.LeftSpeed = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowCam = new System.Windows.Forms.Button();
            this.SendArea = new System.Windows.Forms.GroupBox();
            this.checkBox_UndefinedValue4 = new System.Windows.Forms.CheckBox();
            this.SendUndefinedValue4 = new System.Windows.Forms.MaskedTextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.checkBox_UndefinedValue3 = new System.Windows.Forms.CheckBox();
            this.SendUndefinedValue3 = new System.Windows.Forms.MaskedTextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.checkBox_UndefinedValue2 = new System.Windows.Forms.CheckBox();
            this.SendUndefinedValue2 = new System.Windows.Forms.MaskedTextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.checkBox_UndefinedValue = new System.Windows.Forms.CheckBox();
            this.SendUndefinedValue = new System.Windows.Forms.MaskedTextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.checkBox_ZAngleSpeedOffset = new System.Windows.Forms.CheckBox();
            this.SendZAngleSpeedOffset = new System.Windows.Forms.MaskedTextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.checkBox_TurnValue = new System.Windows.Forms.CheckBox();
            this.SendTurnValue = new System.Windows.Forms.MaskedTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.checkBox_SpeedI = new System.Windows.Forms.CheckBox();
            this.SendSpeedI = new System.Windows.Forms.MaskedTextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.checkBox_SpeedP = new System.Windows.Forms.CheckBox();
            this.SendSpeedP = new System.Windows.Forms.MaskedTextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.checkBox_AngleD = new System.Windows.Forms.CheckBox();
            this.SendAngleD = new System.Windows.Forms.MaskedTextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.checkBox_AngleP = new System.Windows.Forms.CheckBox();
            this.SendAngleP = new System.Windows.Forms.MaskedTextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.checkBox_ZAngleOffset = new System.Windows.Forms.CheckBox();
            this.SendZAngleOffset = new System.Windows.Forms.MaskedTextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.checkBox_CarSpeed = new System.Windows.Forms.CheckBox();
            this.SendCarSpeed = new System.Windows.Forms.MaskedTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.checkBox_BalanceAngle = new System.Windows.Forms.CheckBox();
            this.SendBalanceAngle = new System.Windows.Forms.MaskedTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.checkBox_RDead = new System.Windows.Forms.CheckBox();
            this.SendRDead = new System.Windows.Forms.MaskedTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.checkBox_LDead = new System.Windows.Forms.CheckBox();
            this.SendLDead = new System.Windows.Forms.MaskedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.ReceiveArea.SuspendLayout();
            this.SendArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 44;
            this.label16.Text = "串口";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(175, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 43;
            this.label15.Text = "波特率";
            // 
            // comboBoxBAUD
            // 
            this.comboBoxBAUD.FormattingEnabled = true;
            this.comboBoxBAUD.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "115200",
            "128000",
            "256000"});
            this.comboBoxBAUD.Location = new System.Drawing.Point(222, 9);
            this.comboBoxBAUD.Name = "comboBoxBAUD";
            this.comboBoxBAUD.Size = new System.Drawing.Size(81, 20);
            this.comboBoxBAUD.TabIndex = 42;
            // 
            // OpenCom
            // 
            this.OpenCom.AutoSize = true;
            this.OpenCom.Location = new System.Drawing.Point(122, 11);
            this.OpenCom.Name = "OpenCom";
            this.OpenCom.Size = new System.Drawing.Size(48, 16);
            this.OpenCom.TabIndex = 41;
            this.OpenCom.Text = "打开";
            this.OpenCom.UseVisualStyleBackColor = true;
            this.OpenCom.CheckedChanged += new System.EventHandler(this.OpenCom_CheckedChanged);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(36, 9);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(80, 20);
            this.comboBoxPort.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(152, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 49;
            this.label14.Text = "停止位";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(6, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 48;
            this.label13.Text = "数据位";
            // 
            // comboBoxStop
            // 
            this.comboBoxStop.FormattingEnabled = true;
            this.comboBoxStop.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxStop.Location = new System.Drawing.Point(200, 35);
            this.comboBoxStop.Name = "comboBoxStop";
            this.comboBoxStop.Size = new System.Drawing.Size(54, 20);
            this.comboBoxStop.TabIndex = 47;
            // 
            // comboBoxData
            // 
            this.comboBoxData.FormattingEnabled = true;
            this.comboBoxData.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxData.Location = new System.Drawing.Point(54, 35);
            this.comboBoxData.Name = "comboBoxData";
            this.comboBoxData.Size = new System.Drawing.Size(62, 20);
            this.comboBoxData.TabIndex = 46;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(326, 6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 45;
            // 
            // ReceiveArea
            // 
            this.ReceiveArea.Controls.Add(this.UndefinedValue);
            this.ReceiveArea.Controls.Add(this.RDead);
            this.ReceiveArea.Controls.Add(this.LDead);
            this.ReceiveArea.Controls.Add(this.RDuty);
            this.ReceiveArea.Controls.Add(this.LDuty);
            this.ReceiveArea.Controls.Add(this.label12);
            this.ReceiveArea.Controls.Add(this.label18);
            this.ReceiveArea.Controls.Add(this.label19);
            this.ReceiveArea.Controls.Add(this.label20);
            this.ReceiveArea.Controls.Add(this.label21);
            this.ReceiveArea.Controls.Add(this.TurnValue);
            this.ReceiveArea.Controls.Add(this.label22);
            this.ReceiveArea.Controls.Add(this.SpeedI);
            this.ReceiveArea.Controls.Add(this.SpeedP);
            this.ReceiveArea.Controls.Add(this.AngleD);
            this.ReceiveArea.Controls.Add(this.AngleP);
            this.ReceiveArea.Controls.Add(this.CarSpeed);
            this.ReceiveArea.Controls.Add(this.label11);
            this.ReceiveArea.Controls.Add(this.label10);
            this.ReceiveArea.Controls.Add(this.label9);
            this.ReceiveArea.Controls.Add(this.label8);
            this.ReceiveArea.Controls.Add(this.label7);
            this.ReceiveArea.Controls.Add(this.CarAngle);
            this.ReceiveArea.Controls.Add(this.ZAngleSpeed);
            this.ReceiveArea.Controls.Add(this.ZAngle);
            this.ReceiveArea.Controls.Add(this.YAngle);
            this.ReceiveArea.Controls.Add(this.XAngle);
            this.ReceiveArea.Controls.Add(this.RightSpeed);
            this.ReceiveArea.Controls.Add(this.LeftSpeed);
            this.ReceiveArea.Controls.Add(this.label17);
            this.ReceiveArea.Controls.Add(this.label4);
            this.ReceiveArea.Controls.Add(this.label5);
            this.ReceiveArea.Controls.Add(this.label6);
            this.ReceiveArea.Controls.Add(this.label3);
            this.ReceiveArea.Controls.Add(this.label2);
            this.ReceiveArea.Controls.Add(this.label1);
            this.ReceiveArea.Location = new System.Drawing.Point(8, 61);
            this.ReceiveArea.Name = "ReceiveArea";
            this.ReceiveArea.Size = new System.Drawing.Size(464, 202);
            this.ReceiveArea.TabIndex = 50;
            this.ReceiveArea.TabStop = false;
            this.ReceiveArea.Text = "接收区";
            // 
            // UndefinedValue
            // 
            this.UndefinedValue.Location = new System.Drawing.Point(364, 158);
            this.UndefinedValue.Name = "UndefinedValue";
            this.UndefinedValue.ReadOnly = true;
            this.UndefinedValue.Size = new System.Drawing.Size(81, 21);
            this.UndefinedValue.TabIndex = 73;
            // 
            // RDead
            // 
            this.RDead.Location = new System.Drawing.Point(364, 131);
            this.RDead.Name = "RDead";
            this.RDead.ReadOnly = true;
            this.RDead.Size = new System.Drawing.Size(81, 21);
            this.RDead.TabIndex = 72;
            // 
            // LDead
            // 
            this.LDead.Location = new System.Drawing.Point(364, 104);
            this.LDead.Name = "LDead";
            this.LDead.ReadOnly = true;
            this.LDead.Size = new System.Drawing.Size(81, 21);
            this.LDead.TabIndex = 71;
            // 
            // RDuty
            // 
            this.RDuty.Location = new System.Drawing.Point(364, 77);
            this.RDuty.Name = "RDuty";
            this.RDuty.ReadOnly = true;
            this.RDuty.Size = new System.Drawing.Size(81, 21);
            this.RDuty.TabIndex = 70;
            // 
            // LDuty
            // 
            this.LDuty.Location = new System.Drawing.Point(364, 50);
            this.LDuty.Name = "LDuty";
            this.LDuty.ReadOnly = true;
            this.LDuty.Size = new System.Drawing.Size(81, 21);
            this.LDuty.TabIndex = 69;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(313, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 68;
            this.label12.Text = "未定义";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(304, 138);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 67;
            this.label18.Text = "右轮死区";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(304, 110);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 66;
            this.label19.Text = "左轮死区";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(298, 80);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 65;
            this.label20.Text = "右轮占空比";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(298, 54);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 12);
            this.label21.TabIndex = 64;
            this.label21.Text = "左轮占空比";
            // 
            // TurnValue
            // 
            this.TurnValue.Location = new System.Drawing.Point(364, 23);
            this.TurnValue.Name = "TurnValue";
            this.TurnValue.ReadOnly = true;
            this.TurnValue.Size = new System.Drawing.Size(81, 21);
            this.TurnValue.TabIndex = 63;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(316, 26);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 12);
            this.label22.TabIndex = 62;
            this.label22.Text = "转向";
            // 
            // SpeedI
            // 
            this.SpeedI.Location = new System.Drawing.Point(214, 158);
            this.SpeedI.Name = "SpeedI";
            this.SpeedI.ReadOnly = true;
            this.SpeedI.Size = new System.Drawing.Size(81, 21);
            this.SpeedI.TabIndex = 61;
            // 
            // SpeedP
            // 
            this.SpeedP.Location = new System.Drawing.Point(214, 131);
            this.SpeedP.Name = "SpeedP";
            this.SpeedP.ReadOnly = true;
            this.SpeedP.Size = new System.Drawing.Size(81, 21);
            this.SpeedP.TabIndex = 60;
            // 
            // AngleD
            // 
            this.AngleD.Location = new System.Drawing.Point(214, 104);
            this.AngleD.Name = "AngleD";
            this.AngleD.ReadOnly = true;
            this.AngleD.Size = new System.Drawing.Size(81, 21);
            this.AngleD.TabIndex = 59;
            // 
            // AngleP
            // 
            this.AngleP.Location = new System.Drawing.Point(214, 77);
            this.AngleP.Name = "AngleP";
            this.AngleP.ReadOnly = true;
            this.AngleP.Size = new System.Drawing.Size(81, 21);
            this.AngleP.TabIndex = 58;
            // 
            // CarSpeed
            // 
            this.CarSpeed.Location = new System.Drawing.Point(214, 50);
            this.CarSpeed.Name = "CarSpeed";
            this.CarSpeed.ReadOnly = true;
            this.CarSpeed.Size = new System.Drawing.Size(81, 21);
            this.CarSpeed.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(161, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 56;
            this.label11.Text = "速度I";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(161, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 55;
            this.label10.Text = "速度P";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 54;
            this.label9.Text = "角度D";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 53;
            this.label8.Text = "角度P";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 52;
            this.label7.Text = "车速";
            // 
            // CarAngle
            // 
            this.CarAngle.Location = new System.Drawing.Point(214, 23);
            this.CarAngle.Name = "CarAngle";
            this.CarAngle.ReadOnly = true;
            this.CarAngle.Size = new System.Drawing.Size(81, 21);
            this.CarAngle.TabIndex = 51;
            // 
            // ZAngleSpeed
            // 
            this.ZAngleSpeed.Location = new System.Drawing.Point(68, 158);
            this.ZAngleSpeed.Name = "ZAngleSpeed";
            this.ZAngleSpeed.ReadOnly = true;
            this.ZAngleSpeed.Size = new System.Drawing.Size(81, 21);
            this.ZAngleSpeed.TabIndex = 50;
            // 
            // ZAngle
            // 
            this.ZAngle.Location = new System.Drawing.Point(68, 131);
            this.ZAngle.Name = "ZAngle";
            this.ZAngle.ReadOnly = true;
            this.ZAngle.Size = new System.Drawing.Size(81, 21);
            this.ZAngle.TabIndex = 49;
            // 
            // YAngle
            // 
            this.YAngle.Location = new System.Drawing.Point(68, 104);
            this.YAngle.Name = "YAngle";
            this.YAngle.ReadOnly = true;
            this.YAngle.Size = new System.Drawing.Size(81, 21);
            this.YAngle.TabIndex = 48;
            // 
            // XAngle
            // 
            this.XAngle.Location = new System.Drawing.Point(68, 77);
            this.XAngle.Name = "XAngle";
            this.XAngle.ReadOnly = true;
            this.XAngle.Size = new System.Drawing.Size(81, 21);
            this.XAngle.TabIndex = 47;
            // 
            // RightSpeed
            // 
            this.RightSpeed.Location = new System.Drawing.Point(68, 50);
            this.RightSpeed.Name = "RightSpeed";
            this.RightSpeed.ReadOnly = true;
            this.RightSpeed.Size = new System.Drawing.Size(81, 21);
            this.RightSpeed.TabIndex = 46;
            // 
            // LeftSpeed
            // 
            this.LeftSpeed.Location = new System.Drawing.Point(68, 23);
            this.LeftSpeed.Name = "LeftSpeed";
            this.LeftSpeed.ReadOnly = true;
            this.LeftSpeed.Size = new System.Drawing.Size(81, 21);
            this.LeftSpeed.TabIndex = 45;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(152, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 44;
            this.label17.Text = "车体角度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 43;
            this.label4.Text = "Z角速度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 42;
            this.label5.Text = "Z";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "X";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "右轮转速";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "左轮转速";
            // 
            // ShowCam
            // 
            this.ShowCam.Location = new System.Drawing.Point(326, 33);
            this.ShowCam.Name = "ShowCam";
            this.ShowCam.Size = new System.Drawing.Size(81, 23);
            this.ShowCam.TabIndex = 51;
            this.ShowCam.Text = "显示图像";
            this.ShowCam.UseVisualStyleBackColor = true;
            this.ShowCam.Click += new System.EventHandler(this.ShowCam_Click);
            // 
            // SendArea
            // 
            this.SendArea.Controls.Add(this.checkBox_UndefinedValue4);
            this.SendArea.Controls.Add(this.SendUndefinedValue4);
            this.SendArea.Controls.Add(this.label33);
            this.SendArea.Controls.Add(this.checkBox_UndefinedValue3);
            this.SendArea.Controls.Add(this.SendUndefinedValue3);
            this.SendArea.Controls.Add(this.label34);
            this.SendArea.Controls.Add(this.checkBox_UndefinedValue2);
            this.SendArea.Controls.Add(this.SendUndefinedValue2);
            this.SendArea.Controls.Add(this.label35);
            this.SendArea.Controls.Add(this.checkBox_UndefinedValue);
            this.SendArea.Controls.Add(this.SendUndefinedValue);
            this.SendArea.Controls.Add(this.label36);
            this.SendArea.Controls.Add(this.checkBox_ZAngleSpeedOffset);
            this.SendArea.Controls.Add(this.SendZAngleSpeedOffset);
            this.SendArea.Controls.Add(this.label37);
            this.SendArea.Controls.Add(this.checkBox_TurnValue);
            this.SendArea.Controls.Add(this.SendTurnValue);
            this.SendArea.Controls.Add(this.label28);
            this.SendArea.Controls.Add(this.checkBox_SpeedI);
            this.SendArea.Controls.Add(this.SendSpeedI);
            this.SendArea.Controls.Add(this.label29);
            this.SendArea.Controls.Add(this.checkBox_SpeedP);
            this.SendArea.Controls.Add(this.SendSpeedP);
            this.SendArea.Controls.Add(this.label30);
            this.SendArea.Controls.Add(this.checkBox_AngleD);
            this.SendArea.Controls.Add(this.SendAngleD);
            this.SendArea.Controls.Add(this.label31);
            this.SendArea.Controls.Add(this.checkBox_AngleP);
            this.SendArea.Controls.Add(this.SendAngleP);
            this.SendArea.Controls.Add(this.label32);
            this.SendArea.Controls.Add(this.checkBox_ZAngleOffset);
            this.SendArea.Controls.Add(this.SendZAngleOffset);
            this.SendArea.Controls.Add(this.label27);
            this.SendArea.Controls.Add(this.checkBox_CarSpeed);
            this.SendArea.Controls.Add(this.SendCarSpeed);
            this.SendArea.Controls.Add(this.label26);
            this.SendArea.Controls.Add(this.checkBox_BalanceAngle);
            this.SendArea.Controls.Add(this.SendBalanceAngle);
            this.SendArea.Controls.Add(this.label25);
            this.SendArea.Controls.Add(this.checkBox_RDead);
            this.SendArea.Controls.Add(this.SendRDead);
            this.SendArea.Controls.Add(this.label24);
            this.SendArea.Controls.Add(this.checkBox_LDead);
            this.SendArea.Controls.Add(this.SendLDead);
            this.SendArea.Controls.Add(this.label23);
            this.SendArea.Location = new System.Drawing.Point(8, 269);
            this.SendArea.Name = "SendArea";
            this.SendArea.Size = new System.Drawing.Size(464, 144);
            this.SendArea.TabIndex = 52;
            this.SendArea.TabStop = false;
            this.SendArea.Text = "发送区";
            // 
            // checkBox_UndefinedValue4
            // 
            this.checkBox_UndefinedValue4.AutoSize = true;
            this.checkBox_UndefinedValue4.Location = new System.Drawing.Point(410, 129);
            this.checkBox_UndefinedValue4.Name = "checkBox_UndefinedValue4";
            this.checkBox_UndefinedValue4.Size = new System.Drawing.Size(36, 16);
            this.checkBox_UndefinedValue4.TabIndex = 97;
            this.checkBox_UndefinedValue4.Text = "UP";
            this.checkBox_UndefinedValue4.UseVisualStyleBackColor = true;
            // 
            // SendUndefinedValue4
            // 
            this.SendUndefinedValue4.AsciiOnly = true;
            this.SendUndefinedValue4.Location = new System.Drawing.Point(364, 127);
            this.SendUndefinedValue4.Mask = "9999";
            this.SendUndefinedValue4.Name = "SendUndefinedValue4";
            this.SendUndefinedValue4.PromptChar = '0';
            this.SendUndefinedValue4.Size = new System.Drawing.Size(40, 21);
            this.SendUndefinedValue4.TabIndex = 96;
            this.SendUndefinedValue4.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(311, 130);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(47, 12);
            this.label33.TabIndex = 95;
            this.label33.Text = "未定义4";
            // 
            // checkBox_UndefinedValue3
            // 
            this.checkBox_UndefinedValue3.AutoSize = true;
            this.checkBox_UndefinedValue3.Location = new System.Drawing.Point(410, 102);
            this.checkBox_UndefinedValue3.Name = "checkBox_UndefinedValue3";
            this.checkBox_UndefinedValue3.Size = new System.Drawing.Size(36, 16);
            this.checkBox_UndefinedValue3.TabIndex = 94;
            this.checkBox_UndefinedValue3.Text = "UP";
            this.checkBox_UndefinedValue3.UseVisualStyleBackColor = true;
            // 
            // SendUndefinedValue3
            // 
            this.SendUndefinedValue3.AsciiOnly = true;
            this.SendUndefinedValue3.Location = new System.Drawing.Point(364, 100);
            this.SendUndefinedValue3.Mask = "9999";
            this.SendUndefinedValue3.Name = "SendUndefinedValue3";
            this.SendUndefinedValue3.PromptChar = '0';
            this.SendUndefinedValue3.Size = new System.Drawing.Size(40, 21);
            this.SendUndefinedValue3.TabIndex = 93;
            this.SendUndefinedValue3.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(311, 103);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(47, 12);
            this.label34.TabIndex = 92;
            this.label34.Text = "未定义3";
            // 
            // checkBox_UndefinedValue2
            // 
            this.checkBox_UndefinedValue2.AutoSize = true;
            this.checkBox_UndefinedValue2.Location = new System.Drawing.Point(410, 75);
            this.checkBox_UndefinedValue2.Name = "checkBox_UndefinedValue2";
            this.checkBox_UndefinedValue2.Size = new System.Drawing.Size(36, 16);
            this.checkBox_UndefinedValue2.TabIndex = 91;
            this.checkBox_UndefinedValue2.Text = "UP";
            this.checkBox_UndefinedValue2.UseVisualStyleBackColor = true;
            // 
            // SendUndefinedValue2
            // 
            this.SendUndefinedValue2.AsciiOnly = true;
            this.SendUndefinedValue2.Location = new System.Drawing.Point(364, 73);
            this.SendUndefinedValue2.Mask = "9999";
            this.SendUndefinedValue2.Name = "SendUndefinedValue2";
            this.SendUndefinedValue2.PromptChar = '0';
            this.SendUndefinedValue2.Size = new System.Drawing.Size(40, 21);
            this.SendUndefinedValue2.TabIndex = 90;
            this.SendUndefinedValue2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(311, 76);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(47, 12);
            this.label35.TabIndex = 89;
            this.label35.Text = "未定义2";
            // 
            // checkBox_UndefinedValue
            // 
            this.checkBox_UndefinedValue.AutoSize = true;
            this.checkBox_UndefinedValue.Location = new System.Drawing.Point(410, 48);
            this.checkBox_UndefinedValue.Name = "checkBox_UndefinedValue";
            this.checkBox_UndefinedValue.Size = new System.Drawing.Size(36, 16);
            this.checkBox_UndefinedValue.TabIndex = 88;
            this.checkBox_UndefinedValue.Text = "UP";
            this.checkBox_UndefinedValue.UseVisualStyleBackColor = true;
            // 
            // SendUndefinedValue
            // 
            this.SendUndefinedValue.AsciiOnly = true;
            this.SendUndefinedValue.Location = new System.Drawing.Point(364, 46);
            this.SendUndefinedValue.Mask = "9999";
            this.SendUndefinedValue.Name = "SendUndefinedValue";
            this.SendUndefinedValue.PromptChar = '0';
            this.SendUndefinedValue.Size = new System.Drawing.Size(40, 21);
            this.SendUndefinedValue.TabIndex = 87;
            this.SendUndefinedValue.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(311, 49);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(41, 12);
            this.label36.TabIndex = 86;
            this.label36.Text = "未定义";
            // 
            // checkBox_ZAngleSpeedOffset
            // 
            this.checkBox_ZAngleSpeedOffset.AutoSize = true;
            this.checkBox_ZAngleSpeedOffset.Location = new System.Drawing.Point(410, 21);
            this.checkBox_ZAngleSpeedOffset.Name = "checkBox_ZAngleSpeedOffset";
            this.checkBox_ZAngleSpeedOffset.Size = new System.Drawing.Size(36, 16);
            this.checkBox_ZAngleSpeedOffset.TabIndex = 85;
            this.checkBox_ZAngleSpeedOffset.Text = "UP";
            this.checkBox_ZAngleSpeedOffset.UseVisualStyleBackColor = true;
            // 
            // SendZAngleSpeedOffset
            // 
            this.SendZAngleSpeedOffset.AsciiOnly = true;
            this.SendZAngleSpeedOffset.Location = new System.Drawing.Point(364, 19);
            this.SendZAngleSpeedOffset.Mask = "9999";
            this.SendZAngleSpeedOffset.Name = "SendZAngleSpeedOffset";
            this.SendZAngleSpeedOffset.PromptChar = '0';
            this.SendZAngleSpeedOffset.Size = new System.Drawing.Size(40, 21);
            this.SendZAngleSpeedOffset.TabIndex = 84;
            this.SendZAngleSpeedOffset.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(311, 22);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(47, 12);
            this.label37.TabIndex = 83;
            this.label37.Text = "Z陀螺仪";
            // 
            // checkBox_TurnValue
            // 
            this.checkBox_TurnValue.AutoSize = true;
            this.checkBox_TurnValue.Location = new System.Drawing.Point(260, 129);
            this.checkBox_TurnValue.Name = "checkBox_TurnValue";
            this.checkBox_TurnValue.Size = new System.Drawing.Size(36, 16);
            this.checkBox_TurnValue.TabIndex = 82;
            this.checkBox_TurnValue.Text = "UP";
            this.checkBox_TurnValue.UseVisualStyleBackColor = true;
            // 
            // SendTurnValue
            // 
            this.SendTurnValue.AsciiOnly = true;
            this.SendTurnValue.Location = new System.Drawing.Point(214, 127);
            this.SendTurnValue.Mask = "#999";
            this.SendTurnValue.Name = "SendTurnValue";
            this.SendTurnValue.PromptChar = '0';
            this.SendTurnValue.Size = new System.Drawing.Size(40, 21);
            this.SendTurnValue.TabIndex = 81;
            this.SendTurnValue.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(161, 130);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(29, 12);
            this.label28.TabIndex = 80;
            this.label28.Text = "转向";
            // 
            // checkBox_SpeedI
            // 
            this.checkBox_SpeedI.AutoSize = true;
            this.checkBox_SpeedI.Location = new System.Drawing.Point(260, 102);
            this.checkBox_SpeedI.Name = "checkBox_SpeedI";
            this.checkBox_SpeedI.Size = new System.Drawing.Size(36, 16);
            this.checkBox_SpeedI.TabIndex = 79;
            this.checkBox_SpeedI.Text = "UP";
            this.checkBox_SpeedI.UseVisualStyleBackColor = true;
            // 
            // SendSpeedI
            // 
            this.SendSpeedI.AsciiOnly = true;
            this.SendSpeedI.Location = new System.Drawing.Point(214, 100);
            this.SendSpeedI.Mask = "9999";
            this.SendSpeedI.Name = "SendSpeedI";
            this.SendSpeedI.PromptChar = '0';
            this.SendSpeedI.Size = new System.Drawing.Size(40, 21);
            this.SendSpeedI.TabIndex = 78;
            this.SendSpeedI.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(161, 103);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(35, 12);
            this.label29.TabIndex = 77;
            this.label29.Text = "速度I";
            // 
            // checkBox_SpeedP
            // 
            this.checkBox_SpeedP.AutoSize = true;
            this.checkBox_SpeedP.Location = new System.Drawing.Point(260, 75);
            this.checkBox_SpeedP.Name = "checkBox_SpeedP";
            this.checkBox_SpeedP.Size = new System.Drawing.Size(36, 16);
            this.checkBox_SpeedP.TabIndex = 76;
            this.checkBox_SpeedP.Text = "UP";
            this.checkBox_SpeedP.UseVisualStyleBackColor = true;
            // 
            // SendSpeedP
            // 
            this.SendSpeedP.AsciiOnly = true;
            this.SendSpeedP.Location = new System.Drawing.Point(214, 73);
            this.SendSpeedP.Mask = "9999";
            this.SendSpeedP.Name = "SendSpeedP";
            this.SendSpeedP.PromptChar = '0';
            this.SendSpeedP.Size = new System.Drawing.Size(40, 21);
            this.SendSpeedP.TabIndex = 75;
            this.SendSpeedP.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(161, 76);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(35, 12);
            this.label30.TabIndex = 74;
            this.label30.Text = "速度P";
            // 
            // checkBox_AngleD
            // 
            this.checkBox_AngleD.AutoSize = true;
            this.checkBox_AngleD.Location = new System.Drawing.Point(260, 48);
            this.checkBox_AngleD.Name = "checkBox_AngleD";
            this.checkBox_AngleD.Size = new System.Drawing.Size(36, 16);
            this.checkBox_AngleD.TabIndex = 73;
            this.checkBox_AngleD.Text = "UP";
            this.checkBox_AngleD.UseVisualStyleBackColor = true;
            // 
            // SendAngleD
            // 
            this.SendAngleD.AsciiOnly = true;
            this.SendAngleD.Location = new System.Drawing.Point(214, 46);
            this.SendAngleD.Mask = "9999";
            this.SendAngleD.Name = "SendAngleD";
            this.SendAngleD.PromptChar = '0';
            this.SendAngleD.Size = new System.Drawing.Size(40, 21);
            this.SendAngleD.TabIndex = 72;
            this.SendAngleD.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(161, 49);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(35, 12);
            this.label31.TabIndex = 71;
            this.label31.Text = "角度D";
            // 
            // checkBox_AngleP
            // 
            this.checkBox_AngleP.AutoSize = true;
            this.checkBox_AngleP.Location = new System.Drawing.Point(260, 21);
            this.checkBox_AngleP.Name = "checkBox_AngleP";
            this.checkBox_AngleP.Size = new System.Drawing.Size(36, 16);
            this.checkBox_AngleP.TabIndex = 70;
            this.checkBox_AngleP.Text = "UP";
            this.checkBox_AngleP.UseVisualStyleBackColor = true;
            // 
            // SendAngleP
            // 
            this.SendAngleP.AsciiOnly = true;
            this.SendAngleP.Location = new System.Drawing.Point(214, 19);
            this.SendAngleP.Mask = "9999";
            this.SendAngleP.Name = "SendAngleP";
            this.SendAngleP.PromptChar = '0';
            this.SendAngleP.Size = new System.Drawing.Size(40, 21);
            this.SendAngleP.TabIndex = 69;
            this.SendAngleP.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(161, 22);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(35, 12);
            this.label32.TabIndex = 68;
            this.label32.Text = "角度P";
            // 
            // checkBox_ZAngleOffset
            // 
            this.checkBox_ZAngleOffset.AutoSize = true;
            this.checkBox_ZAngleOffset.Location = new System.Drawing.Point(114, 129);
            this.checkBox_ZAngleOffset.Name = "checkBox_ZAngleOffset";
            this.checkBox_ZAngleOffset.Size = new System.Drawing.Size(36, 16);
            this.checkBox_ZAngleOffset.TabIndex = 67;
            this.checkBox_ZAngleOffset.Text = "UP";
            this.checkBox_ZAngleOffset.UseVisualStyleBackColor = true;
            // 
            // SendZAngleOffset
            // 
            this.SendZAngleOffset.AsciiOnly = true;
            this.SendZAngleOffset.Location = new System.Drawing.Point(68, 127);
            this.SendZAngleOffset.Mask = "9999";
            this.SendZAngleOffset.Name = "SendZAngleOffset";
            this.SendZAngleOffset.PromptChar = '0';
            this.SendZAngleOffset.Size = new System.Drawing.Size(40, 21);
            this.SendZAngleOffset.TabIndex = 66;
            this.SendZAngleOffset.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 131);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(47, 12);
            this.label27.TabIndex = 65;
            this.label27.Text = "Z零偏值";
            // 
            // checkBox_CarSpeed
            // 
            this.checkBox_CarSpeed.AutoSize = true;
            this.checkBox_CarSpeed.Location = new System.Drawing.Point(114, 102);
            this.checkBox_CarSpeed.Name = "checkBox_CarSpeed";
            this.checkBox_CarSpeed.Size = new System.Drawing.Size(36, 16);
            this.checkBox_CarSpeed.TabIndex = 64;
            this.checkBox_CarSpeed.Text = "UP";
            this.checkBox_CarSpeed.UseVisualStyleBackColor = true;
            // 
            // SendCarSpeed
            // 
            this.SendCarSpeed.AsciiOnly = true;
            this.SendCarSpeed.Location = new System.Drawing.Point(68, 100);
            this.SendCarSpeed.Mask = "#999";
            this.SendCarSpeed.Name = "SendCarSpeed";
            this.SendCarSpeed.PromptChar = '0';
            this.SendCarSpeed.Size = new System.Drawing.Size(40, 21);
            this.SendCarSpeed.TabIndex = 63;
            this.SendCarSpeed.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 104);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 12);
            this.label26.TabIndex = 62;
            this.label26.Text = "车速";
            // 
            // checkBox_BalanceAngle
            // 
            this.checkBox_BalanceAngle.AutoSize = true;
            this.checkBox_BalanceAngle.Location = new System.Drawing.Point(114, 75);
            this.checkBox_BalanceAngle.Name = "checkBox_BalanceAngle";
            this.checkBox_BalanceAngle.Size = new System.Drawing.Size(36, 16);
            this.checkBox_BalanceAngle.TabIndex = 61;
            this.checkBox_BalanceAngle.Text = "UP";
            this.checkBox_BalanceAngle.UseVisualStyleBackColor = true;
            // 
            // SendBalanceAngle
            // 
            this.SendBalanceAngle.AsciiOnly = true;
            this.SendBalanceAngle.Location = new System.Drawing.Point(68, 73);
            this.SendBalanceAngle.Mask = "#9.9";
            this.SendBalanceAngle.Name = "SendBalanceAngle";
            this.SendBalanceAngle.PromptChar = '0';
            this.SendBalanceAngle.Size = new System.Drawing.Size(40, 21);
            this.SendBalanceAngle.TabIndex = 60;
            this.SendBalanceAngle.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 77);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 12);
            this.label25.TabIndex = 59;
            this.label25.Text = "平衡角";
            // 
            // checkBox_RDead
            // 
            this.checkBox_RDead.AutoSize = true;
            this.checkBox_RDead.Location = new System.Drawing.Point(114, 48);
            this.checkBox_RDead.Name = "checkBox_RDead";
            this.checkBox_RDead.Size = new System.Drawing.Size(36, 16);
            this.checkBox_RDead.TabIndex = 58;
            this.checkBox_RDead.Text = "UP";
            this.checkBox_RDead.UseVisualStyleBackColor = true;
            // 
            // SendRDead
            // 
            this.SendRDead.AsciiOnly = true;
            this.SendRDead.Location = new System.Drawing.Point(68, 46);
            this.SendRDead.Mask = "9999";
            this.SendRDead.Name = "SendRDead";
            this.SendRDead.PromptChar = '0';
            this.SendRDead.Size = new System.Drawing.Size(40, 21);
            this.SendRDead.TabIndex = 57;
            this.SendRDead.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 50);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 12);
            this.label24.TabIndex = 56;
            this.label24.Text = "右轮死区";
            // 
            // checkBox_LDead
            // 
            this.checkBox_LDead.AutoSize = true;
            this.checkBox_LDead.Location = new System.Drawing.Point(114, 21);
            this.checkBox_LDead.Name = "checkBox_LDead";
            this.checkBox_LDead.Size = new System.Drawing.Size(36, 16);
            this.checkBox_LDead.TabIndex = 55;
            this.checkBox_LDead.Text = "UP";
            this.checkBox_LDead.UseVisualStyleBackColor = true;
            // 
            // SendLDead
            // 
            this.SendLDead.AsciiOnly = true;
            this.SendLDead.Location = new System.Drawing.Point(68, 19);
            this.SendLDead.Mask = "9999";
            this.SendLDead.Name = "SendLDead";
            this.SendLDead.PromptChar = '0';
            this.SendLDead.Size = new System.Drawing.Size(40, 21);
            this.SendLDead.TabIndex = 54;
            this.SendLDead.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 23);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 12);
            this.label23.TabIndex = 52;
            this.label23.Text = "左轮死区";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(8, 423);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(464, 45);
            this.trackBar1.TabIndex = 53;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 454);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.SendArea);
            this.Controls.Add(this.ShowCam);
            this.Controls.Add(this.ReceiveArea);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBoxStop);
            this.Controls.Add(this.comboBoxData);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBoxBAUD);
            this.Controls.Add(this.OpenCom);
            this.Controls.Add(this.comboBoxPort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CarDebugger Ver2.1 By Coding Spirit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ReceiveArea.ResumeLayout(false);
            this.ReceiveArea.PerformLayout();
            this.SendArea.ResumeLayout(false);
            this.SendArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox ReceiveArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ZAngleSpeed;
        private System.Windows.Forms.TextBox ZAngle;
        private System.Windows.Forms.TextBox YAngle;
        private System.Windows.Forms.TextBox XAngle;
        private System.Windows.Forms.TextBox RightSpeed;
        private System.Windows.Forms.TextBox LeftSpeed;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UndefinedValue;
        private System.Windows.Forms.TextBox RDead;
        private System.Windows.Forms.TextBox LDead;
        private System.Windows.Forms.TextBox RDuty;
        private System.Windows.Forms.TextBox LDuty;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox TurnValue;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox SpeedI;
        private System.Windows.Forms.TextBox SpeedP;
        private System.Windows.Forms.TextBox AngleD;
        private System.Windows.Forms.TextBox AngleP;
        private System.Windows.Forms.TextBox CarSpeed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CarAngle;
        private System.Windows.Forms.Button ShowCam;
        private System.Windows.Forms.GroupBox SendArea;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.MaskedTextBox SendLDead;
        private System.Windows.Forms.CheckBox checkBox_ZAngleOffset;
        private System.Windows.Forms.MaskedTextBox SendZAngleOffset;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.CheckBox checkBox_CarSpeed;
        private System.Windows.Forms.MaskedTextBox SendCarSpeed;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox checkBox_BalanceAngle;
        private System.Windows.Forms.MaskedTextBox SendBalanceAngle;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.CheckBox checkBox_RDead;
        private System.Windows.Forms.MaskedTextBox SendRDead;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.CheckBox checkBox_LDead;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox checkBox_TurnValue;
        private System.Windows.Forms.MaskedTextBox SendTurnValue;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.CheckBox checkBox_SpeedI;
        private System.Windows.Forms.MaskedTextBox SendSpeedI;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.CheckBox checkBox_SpeedP;
        private System.Windows.Forms.MaskedTextBox SendSpeedP;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.CheckBox checkBox_AngleD;
        private System.Windows.Forms.MaskedTextBox SendAngleD;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.CheckBox checkBox_AngleP;
        private System.Windows.Forms.MaskedTextBox SendAngleP;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.CheckBox checkBox_UndefinedValue4;
        private System.Windows.Forms.MaskedTextBox SendUndefinedValue4;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.CheckBox checkBox_UndefinedValue3;
        private System.Windows.Forms.MaskedTextBox SendUndefinedValue3;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.CheckBox checkBox_UndefinedValue2;
        private System.Windows.Forms.MaskedTextBox SendUndefinedValue2;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.CheckBox checkBox_UndefinedValue;
        private System.Windows.Forms.MaskedTextBox SendUndefinedValue;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.CheckBox checkBox_ZAngleSpeedOffset;
        private System.Windows.Forms.MaskedTextBox SendZAngleSpeedOffset;
        private System.Windows.Forms.Label label37;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBoxBAUD;
        private System.Windows.Forms.CheckBox OpenCom;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.ComboBox comboBoxStop;
        private System.Windows.Forms.ComboBox comboBoxData;
    }
}

