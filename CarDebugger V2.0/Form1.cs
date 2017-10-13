using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace CarDebugger_V2._0
{
    public partial class Form1 : Form
    {
        public const int MAXBUFFER = 91;//91
        public byte[] buffer = new byte[MAXBUFFER];
        public bool found = false;
        public static bool Cam = false;
        public static bool CamFound = false;
        public static bool CamFinished = false;
        public string str = "";
        public MaskedTextBox edit;
        public int rowi = 0;
        System.Timers.Timer timer1 = new System.Timers.Timer(200);
        public Form1()
        {
            InitializeComponent();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                if (!Cam)
                {
                    if (!found)
                    {
                        serialPort1.ReadTo("!");
                        found = true;
                    }
                    if ((serialPort1.BytesToRead >= MAXBUFFER) && found)
                    {
                        serialPort1.Read(buffer, 0, MAXBUFFER);
                        serialPort1.DiscardInBuffer();
                    }
                    if (found)
                    {
                        for (int i = 0; i < (MAXBUFFER - 1) / 5; i++)
                        {
                            switch ((char)buffer[1 + 5 * i])
                            {
                                case 'a': LeftSpeed.Text = DataProcess(2 + 5 * i); break;
                                case 'b': RightSpeed.Text = DataProcess(2 + 5 * i); break;
                                case 'c': XAngle.Text = DataProcess(2 + 5 * i); break;
                                case 'd': YAngle.Text = DataProcess(2 + 5 * i); break;
                                case 'e': ZAngle.Text = DataProcess(2 + 5 * i); break;
                                case 'f': ZAngleSpeed.Text = DataProcess(2 + 5 * i); break;
                                case 'g': CarAngle.Text = DataProcess(2 + 5 * i); break;
                                case 'h': CarSpeed.Text = DataProcess(2 + 5 * i); break;
                                case 'i': AngleP.Text = DataProcess(2 + 5 * i); break;
                                case 'j': AngleD.Text = DataProcess(2 + 5 * i); break;
                                case 'k': SpeedP.Text = DataProcess(2 + 5 * i); break;
                                case 'l': SpeedI.Text = DataProcess(2 + 5 * i); break;
                                case 'm': TurnValue.Text = DataProcess(2 + 5 * i); break;
                                case 'n': LDuty.Text = DataProcess(2 + 5 * i); break;
                                case 'o': RDuty.Text = DataProcess(2 + 5 * i); break;
                                case 'p': LDead.Text = DataProcess(2 + 5 * i); break;
                                case 'q': RDead.Text = DataProcess(2 + 5 * i); break;
                                case 'r': UndefinedValue.Text = DataProcess(2 + 5 * i); break;
                            }
                        }
                    }
                }
                else
                {
                    if (!CamFound)
                    {
                        serialPort1.ReadTo("\r");
                        CamFound = true;
                    }
                    if ((serialPort1.BytesToRead >= (Form2.COL/8 * Form2.ROW)) && CamFound && (!CamFinished))
                    {
                        serialPort1.Read(Form2.PixDataO, 0, Form2.COL/8 * Form2.ROW);
                        serialPort1.DiscardInBuffer();
                        CamFinished = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("数据包错误");
                throw;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }
        private void PortSettingChanged(object sender, EventArgs e)
        {
            OpenCom.Checked = false;
        }

        private void OpenCom_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            if (OpenCom.Checked == true)
            {
                progressBar1.Value = 0;
                try
                {
                    serialPort1.PortName = comboBoxPort.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBoxBAUD.Text);
                    serialPort1.DataBits = Convert.ToInt32(comboBoxData.Text);
                    if (comboBoxStop.Text == "1")
                    {
                        serialPort1.StopBits = StopBits.One;
                    }
                    if (comboBoxStop.Text == "2")
                    {
                        serialPort1.StopBits = StopBits.Two;
                    }
                    serialPort1.Parity = Parity.None;
                    //serialPort1.ReadTimeout = 1000;
                    serialPort1.Open();
                    progressBar1.Value = 100;
                }
                catch
                {
                    MessageBox.Show("打开串口失败");
                    OpenCom.Checked = false;
                }
            }
            else
            {
                if (serialPort1.IsOpen)
                {
                    progressBar1.Value = 100;
                    serialPort1.Close();
                    foreach (Control c in SendArea.Controls)
                    {
                        if (c is CheckBox)
                        {
                            ((CheckBox)c).Checked = false;
                        }
                    }
                    progressBar1.Value = 0;
                }
            }
        }
        private string DataProcess(int i)
        {
            byte[] recivedata = new byte[4];
            for (int j = 0; j < 4; j++)
            {
                recivedata[j] = buffer[i + j];
            }
            string bt = System.Text.Encoding.ASCII.GetString(recivedata);
            return bt;
        }
        private void SendUpdate(object sender, EventArgs e)
        {
            String temp = ((CheckBox)sender).Name;
            if (((CheckBox)sender).Checked)
            {
                switch (temp)
                {
                    case "checkBox_LDead": str += "A"; str += SendLDead.Text; break;
                    case "checkBox_RDead": str += "B"; str += SendRDead.Text; break;
                    case "checkBox_BalanceAngle": str += "C"; str += SendBalanceAngle.Text; break;
                    case "checkBox_CarSpeed": str += "D"; str += SendCarSpeed.Text; break;
                    case "checkBox_ZAngleOffset": str += "E"; str += SendZAngleOffset.Text; break;
                    case "checkBox_AngleP": str += "F"; str += SendAngleP.Text; break;
                    case "checkBox_AngleD": str += "G"; str += SendAngleD.Text; break;
                    case "checkBox_SpeedP": str += "H"; str += SendSpeedP.Text; break;
                    case "checkBox_SpeedI": str += "I"; str += SendSpeedI.Text; break;
                    case "checkBox_TurnValue": str += "J"; str += SendTurnValue.Text; break;
                    case "checkBox_ZAngleSpeedOffset": str = "K"; str += SendZAngleSpeedOffset.Text; break;
                    case "checkBox_UndefinedValue": str += "L"; str += SendUndefinedValue.Text; break;
                    case "checkBox_UndefinedValue2": str += "M"; str += SendUndefinedValue2.Text; break;
                    case "checkBox_UndefinedValue3": str += "N"; str += SendUndefinedValue3.Text; break;
                    case "checkBox_UndefinedValue4": str += "O"; str += SendUndefinedValue4.Text; break;
                }
                if (serialPort1.IsOpen)
                {
                    timer1.Start();
                }
                else
                {
                    MessageBox.Show("串口未打开");
                    ((CheckBox)sender).Checked = false;
                }
            }
            else
            {
                Regex r1 = new Regex(@"A[0-9][0-9][0-9][0-9]");
                Regex r2 = new Regex(@"B[0-9][0-9][0-9][0-9]");
                Regex r3 = new Regex(@"C[+-0-9][0-9]\.[0-9]");
                Regex r4 = new Regex(@"D[+-0-9][0-9][0-9][0-9]");
                Regex r5 = new Regex(@"E[0-9][0-9][0-9][0-9]");
                Regex r6 = new Regex(@"F[0-9][0-9][0-9][0-9]");
                Regex r7 = new Regex(@"G[0-9][0-9][0-9][0-9]");
                Regex r8 = new Regex(@"H[0-9][0-9][0-9][0-9]");
                Regex r9 = new Regex(@"I[0-9][0-9][0-9][0-9]");
                Regex r10 = new Regex(@"J[+-0-9][0-9][0-9][0-9]");
                Regex r11 = new Regex(@"K[0-9][0-9][0-9][0-9]");
                Regex r12 = new Regex(@"L[0-9][0-9][0-9][0-9]");
                Regex r13 = new Regex(@"M[0-9][0-9][0-9][0-9]");
                Regex r14 = new Regex(@"N[0-9][0-9][0-9][0-9]");
                Regex r15 = new Regex(@"O[0-9][0-9][0-9][0-9]");
                switch (temp)
                {
                    case "checkBox_LDead": str = r1.Replace(str, ""); break;
                    case "checkBox_RDead": str = r2.Replace(str, ""); break;
                    case "checkBox_BalanceAngle": str = r3.Replace(str, ""); break;
                    case "checkBox_CarSpeed": str = r4.Replace(str, ""); break;
                    case "checkBox_ZAngleOffset": str = r5.Replace(str, ""); break;
                    case "checkBox_AngleP": str = r6.Replace(str, ""); break;
                    case "checkBox_AngleD": str = r7.Replace(str, ""); break;
                    case "checkBox_SpeedP": str = r8.Replace(str, ""); break;
                    case "checkBox_SpeedI": str = r9.Replace(str, ""); break;
                    case "checkBox_TurnValue": str = r10.Replace(str, ""); break;
                    case "checkBox_ZAngleSpeedOffset": str = r11.Replace(str, ""); break;
                    case "checkBox_UndefinedValue": str = r12.Replace(str, ""); break;
                    case "checkBox_UndefinedValue2": str = r13.Replace(str, ""); break;
                    case "checkBox_UndefinedValue3": str = r14.Replace(str, ""); break;
                    case "checkBox_UndefinedValue4": str = r15.Replace(str, ""); break;
                }
                if (str == "")
                {
                    timer1.Stop();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Process[] temp = Process.GetProcessesByName("SteamService");
            if (temp.Length > 0)
            {
                temp = Process.GetProcessesByName("dota2");
                if (temp.Length > 0)
                {
                    MessageBox.Show("我靠你一边调车一边刀啊？");
                }
                else
                {
                    MessageBox.Show("steam都打开了，是不是想刀一局？");
                }
            }
            else
            {
                MessageBox.Show("调什么车，刀TMD，快开steam");
            }
            foreach (Control c in this.Controls)
            {
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndexChanged += new System.EventHandler(this.PortSettingChanged);
                }
            }
            foreach (Control c in SendArea.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).CheckedChanged += new System.EventHandler(this.SendUpdate);
                }
                if (c is MaskedTextBox)
                {
                    ((MaskedTextBox)c).Enter += new System.EventHandler(this.TextBox_Edit);
                    ((MaskedTextBox)c).TextChanged += new System.EventHandler(this.TextBox_Change);
                }
            }
            try
            {
                string[] port = SerialPort.GetPortNames();
                Array.Sort(port);
                comboBoxPort.Items.AddRange(port);
                comboBoxPort.SelectedIndex = 0;
                comboBoxBAUD.SelectedIndex = 3;
                comboBoxData.SelectedIndex = 3;
                comboBoxStop.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("没有找到串口");
            }
            timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.SendData);
            timer1.AutoReset = true;
            trackBar1.Maximum = 2000;
            trackBar1.Minimum = 0;
        }
        private void SendData(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    byte[] package = System.Text.Encoding.ASCII.GetBytes(str);
                    serialPort1.Write(package, 0, str.Length);
                }
                catch (Exception)
                {
                    MessageBox.Show("数据包发送失败");
                    foreach (Control c in this.SendArea.Controls)
                    {
                        if (c is CheckBox)
                        {
                            ((CheckBox)c).Checked = false;
                        }
                    }
                    throw;
                }
            }
            else
            {
                timer1.Stop();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (edit != null)
            {
                if (trackBar1.Value < 10)
                {
                    edit.Text = "000" + trackBar1.Value.ToString();
                }
                else if (trackBar1.Value < 100)
                {
                    edit.Text = "00" + trackBar1.Value.ToString();
                }
                else if (trackBar1.Value < 1000)
                {
                    edit.Text = '0' + trackBar1.Value.ToString();
                }
                else if (trackBar1.Value >= 1000)
                    edit.Text = trackBar1.Value.ToString();
            }
        }
        private void TextBox_Edit(object sender, EventArgs e)
        {
            edit = (MaskedTextBox)sender;
        }
        private void TextBox_Change(object sender, EventArgs e)
        {
            String temp = ((MaskedTextBox)sender).Name;
            Regex r1 = new Regex(@"A[0-9][0-9][0-9][0-9]");
            Regex r2 = new Regex(@"B[0-9][0-9][0-9][0-9]");
            Regex r3 = new Regex(@"C[+-0-9][0-9]\.[0-9]");
            Regex r4 = new Regex(@"D[+-0-9][0-9][0-9][0-9]");
            Regex r5 = new Regex(@"E[0-9][0-9][0-9][0-9]");
            Regex r6 = new Regex(@"F[0-9][0-9][0-9][0-9]");
            Regex r7 = new Regex(@"G[0-9][0-9][0-9][0-9]");
            Regex r8 = new Regex(@"H[0-9][0-9][0-9][0-9]");
            Regex r9 = new Regex(@"I[0-9][0-9][0-9][0-9]");
            Regex r10 = new Regex(@"J[+-0-9][0-9][0-9][0-9]");
            Regex r11 = new Regex(@"K[0-9][0-9][0-9][0-9]");
            Regex r12 = new Regex(@"L[0-9][0-9][0-9][0-9]");
            Regex r13 = new Regex(@"M[0-9][0-9][0-9][0-9]");
            Regex r14 = new Regex(@"N[0-9][0-9][0-9][0-9]");
            Regex r15 = new Regex(@"O[0-9][0-9][0-9][0-9]");
            switch (temp)
            {
                case "SendLDead": str = r1.Replace(str, "A" + SendLDead.Text); break;
                case "SendRDead": str = r2.Replace(str, "B" + SendRDead.Text); break;
                case "SendBalanceAngle": str = r3.Replace(str, "C" + SendBalanceAngle.Text); break;
                case "SendCarSpeed": str = r4.Replace(str, "D" + SendCarSpeed.Text); break;
                case "SendZAngleOffset": str = r5.Replace(str, "E" + SendZAngleOffset.Text); break;
                case "SendAngleP": str = r6.Replace(str, "F" + SendAngleP.Text); break;
                case "SendAngleD": str = r7.Replace(str, "G" + SendAngleD.Text); break;
                case "SendSpeedP": str = r8.Replace(str, "H" + SendSpeedP.Text); break;
                case "SendSpeedI": str = r9.Replace(str, "I" + SendSpeedI.Text); break;
                case "SendTurnValue": str = r10.Replace(str, "J" + SendTurnValue.Text); break;
                case "SendZAngleSpeedOffset": str = r11.Replace(str, "K" + SendZAngleSpeedOffset.Text); break;
                case "SendUndefinedValue": str = r12.Replace(str, "L" + SendUndefinedValue.Text); break;
                case "SendUndefinedValue2": str = r13.Replace(str, "M" + SendUndefinedValue2.Text); break;
                case "SendUndefinedValue3": str = r14.Replace(str, "N" + SendUndefinedValue3.Text); break;
                case "SendUndefinedValue4": str = r15.Replace(str, "O" + SendUndefinedValue4.Text); break;
            }
        }

        private void ShowCam_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            serialPort1.ReadBufferSize = (Form2.ROW * Form2.COL) + 100;
        }
    }
}
