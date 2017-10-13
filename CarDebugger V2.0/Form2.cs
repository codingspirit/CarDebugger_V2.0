using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace CarDebugger_V2._0
{
    public partial class Form2 : Form
    {
        public static int ROW, COL;
        public static byte[] PixData;
        public static byte[] PixDataO;
        public byte Threshold;
        public byte[] AfterPix;
        public byte SingalCOL = 0;
        public byte MidValue = 0;
        public byte SingalLost = 0;
        public int TurnValue = 0;
        public int P_TurnValue = 0;
        System.Timers.Timer timer2 = new System.Timers.Timer(100);
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox_Start_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Start.Checked)
            {
                if (PixData != null)
                {
                    Form1.Cam = true;
                    Form1.CamFound = false;
                    Form1.CamFinished = false;
                    labelFound.Text = "正在寻找图像头";
                    timer2.Start();
                }
                else
                {
                    MessageBox.Show("图像内存池尚未开辟。是不是忘了设置图像尺寸？");
                }
            }
            else
            {
                Form1.Cam = false;
                Form1.CamFound = false;
                Form1.CamFinished = false;
                labelFound.Text = "";
                timer2.Stop();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBoxSize.SelectedIndex = 1;
            timer2.Elapsed += new System.Timers.ElapsedEventHandler(this.DrawPix);
            timer2.AutoReset = true;
            textBoxThreshold.Text = "240";
        }

        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxSize.Text)
                {
                    case "320*240": ROW = 240; COL = 320; break;
                    case "240*180": ROW = 180; COL = 240; break;
                    case "160*120": ROW = 120; COL = 160; break;
                    case "100*80": ROW = 80; COL = 100; break;
                    case "80*60": ROW = 60; COL = 80; break;
                }
                PixData = new byte[ROW * COL];
                PixDataO = new byte[ROW * COL / 8];
            }
            catch (Exception)
            {
                MessageBox.Show("开辟图像内存池失败");
                throw;
            }
        }

        private void textBoxThreshold_TextChanged(object sender, EventArgs e)
        {
            Threshold = Convert.ToByte(textBoxThreshold.Text);
        }

        private void DrawPix(object sender, EventArgs e)
        {
            if (Form1.CamFinished)
            {
                try
                {
                    labelFound.Text = "已找到图像头";
                    PixO2Pix();
                    pictureBoxOriginal.Image = Pix2Bmp(PixData);
                    Form1.CamFinished = false;
                    Form1.CamFound = false;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            //if (checkBox_Binaryzation.Checked)
            //{
            //    try
            //    {
            //        AfterPix = new byte[ROW * COL];
            //        for (int i = 0; i < ROW; i++)
            //        {
            //            for (int j = 0; j < COL; j++)
            //            {
            //                if (PixData[i * COL + j] < Threshold)
            //                {
            //                    AfterPix[i * COL + j] = 0;
            //                }
            //                else
            //                {
            //                    AfterPix[i * COL + j] = 255;
            //                }
            //            }
            //        }
            //        pictureBoxAfter.Image = Pix2Bmp(AfterPix);
            //    }
            //    catch (Exception)
            //    {
            //        throw;
            //    }
            //}
            if (checkBox_Search.Checked)
            {
                int x, y;
                int Hcalc = 0;
                byte Hcounter = 0;
                MidValue = 0;
                for (y = 0; y < ROW - 1; y++)
                {
                    for (x = 1; x < (COL / 8) + 1; x++)
                    {
                        if (PixDataO[y * COL / 8 + x] < 0xF0)  //more than 4 black
                        {
                            if (PixDataO[(y + 2) * COL / 8 + x] < 0xF0)  //next 2 ROW more than 4 black
                            {
                                Hcounter++;
                                Hcalc += (x-1);
                            }
                        }
                    }
                    if (Hcalc > 0)  //found
                    {
                        MidValue = (byte)((Hcalc / Hcounter) * 8 - 4);//(HCalc/Hcounter-0.5)*8
                        break;
                    }
                }
                if (MidValue == 0)
                {
                    SingalLost++;
                    if (SingalLost >= 5)
                    {
                        TurnValue = COL / 2;
                        SingalLost = 0;
                    }
                    else
                    {
                        TurnValue = P_TurnValue / 2;
                    }
                }
                else
                {
                    TurnValue = COL / 2 - MidValue;
                    P_TurnValue = TurnValue;
                    SingalLost = 0;
                }
                AfterPix = new byte[ROW * COL];
                AfterPix = PixData;
                for (int i = 0; i < ROW; i++)
                {
                    AfterPix[i * COL + MidValue] = 100;
                }
                pictureBoxAfter.Image = Pix2BmpSingal(AfterPix);
                labelTurnValue.Text = "Error:" + TurnValue.ToString();
            }
        }
        private Bitmap Pix2Bmp(byte[] Pix)
        {
            Bitmap bmp = new Bitmap(COL, ROW, PixelFormat.Format8bppIndexed);
            var palette = bmp.Palette;
            for (var i = 0; i < 256; i++)
            {
                palette.Entries[i] = Color.FromArgb(i, i, i);
            }
            palette.Entries[0] = Color.FromArgb(0, 0, 0);
            palette.Entries[1] = Color.FromArgb(255, 255, 255);
            bmp.Palette = palette;
            BitmapData bmpdata = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
            System.Runtime.InteropServices.Marshal.Copy(Pix, 0, bmpdata.Scan0, Pix.Length);
            bmp.UnlockBits(bmpdata);
            return bmp;
        }
        private Bitmap Pix2BmpSingal(byte[] Pix)
        {
            Bitmap bmp = new Bitmap(COL, ROW, PixelFormat.Format8bppIndexed);
            var palette = bmp.Palette;
            for (var i = 0; i < 256; i++)
            {
                palette.Entries[i] = Color.FromArgb(i, i, i);
            }
            palette.Entries[0] = Color.FromArgb(0, 0, 0);
            palette.Entries[1] = Color.FromArgb(255, 255, 255);
            palette.Entries[100] = Color.FromArgb(255, 100, 100);
            bmp.Palette = palette;
            BitmapData bmpdata = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
            System.Runtime.InteropServices.Marshal.Copy(Pix, 0, bmpdata.Scan0, Pix.Length);
            bmp.UnlockBits(bmpdata);
            return bmp;
        }
        private void PixO2Pix()
        {
            for (int i = 0; i < ROW; i++)
            {
                for (int j = 0; j < COL / 8; j++)
                {
                    PixData[i * COL + j * 8] = (byte)((PixDataO[i * COL / 8 + j] >> 7) & 0x01);
                    PixData[i * COL + j * 8 + 1] = (byte)((PixDataO[i * COL / 8 + j] >> 6) & 0x01);
                    PixData[i * COL + j * 8 + 2] = (byte)((PixDataO[i * COL / 8 + j] >> 5) & 0x01);
                    PixData[i * COL + j * 8 + 3] = (byte)((PixDataO[i * COL / 8 + j] >> 4) & 0x01);
                    PixData[i * COL + j * 8 + 4] = (byte)((PixDataO[i * COL / 8 + j] >> 3) & 0x01);
                    PixData[i * COL + j * 8 + 5] = (byte)((PixDataO[i * COL / 8 + j] >> 2) & 0x01);
                    PixData[i * COL + j * 8 + 6] = (byte)((PixDataO[i * COL / 8 + j] >> 1) & 0x01);
                    PixData[i * COL + j * 8 + 7] = (byte)((PixDataO[i * COL / 8 + j] >> 0) & 0x01);
                    //PixData[i * COL + j * 8] = (byte)((PixDataO[i * COL / 8 + j] >> 7) & 0x01);
                    //PixData[i * COL + j * 8 + 1] = (byte)0xff;
                    //PixData[i * COL + j * 8 + 2] = (byte)0xff;
                    //PixData[i * COL + j * 8 + 3] = (byte)0xff;
                    //PixData[i * COL + j * 8 + 4] = (byte)0xff;
                    //PixData[i * COL + j * 8 + 5] = (byte)0x00;
                    //PixData[i * COL + j * 8 + 6] = (byte)0x00;
                    //PixData[i * COL + j * 8 + 7] = (byte)0x00;
                }
            }
        }
    }
}
