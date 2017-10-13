namespace CarDebugger_V2._0
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxAfter = new System.Windows.Forms.PictureBox();
            this.checkBox_Start = new System.Windows.Forms.CheckBox();
            this.checkBox_Binaryzation = new System.Windows.Forms.CheckBox();
            this.checkBox_Search = new System.Windows.Forms.CheckBox();
            this.labelFound = new System.Windows.Forms.Label();
            this.textBoxThreshold = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTurnValue = new System.Windows.Forms.Label();
            this.label_TurnValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAfter)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "320*240",
            "240*180",
            "160*120",
            "100*80",
            "80*60"});
            this.comboBoxSize.Location = new System.Drawing.Point(71, 12);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(92, 20);
            this.comboBoxSize.TabIndex = 0;
            this.comboBoxSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxSize_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "图像尺寸";
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOriginal.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(12, 38);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(320, 240);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxOriginal.TabIndex = 2;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "原始图像";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "处理后图像";
            // 
            // pictureBoxAfter
            // 
            this.pictureBoxAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAfter.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBoxAfter.Location = new System.Drawing.Point(418, 38);
            this.pictureBoxAfter.Name = "pictureBoxAfter";
            this.pictureBoxAfter.Size = new System.Drawing.Size(320, 240);
            this.pictureBoxAfter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAfter.TabIndex = 5;
            this.pictureBoxAfter.TabStop = false;
            // 
            // checkBox_Start
            // 
            this.checkBox_Start.AutoSize = true;
            this.checkBox_Start.Location = new System.Drawing.Point(338, 50);
            this.checkBox_Start.Name = "checkBox_Start";
            this.checkBox_Start.Size = new System.Drawing.Size(72, 16);
            this.checkBox_Start.TabIndex = 7;
            this.checkBox_Start.Text = "开始采集";
            this.checkBox_Start.UseVisualStyleBackColor = true;
            this.checkBox_Start.CheckedChanged += new System.EventHandler(this.checkBox_Start_CheckedChanged);
            // 
            // checkBox_Binaryzation
            // 
            this.checkBox_Binaryzation.AutoSize = true;
            this.checkBox_Binaryzation.Location = new System.Drawing.Point(338, 96);
            this.checkBox_Binaryzation.Name = "checkBox_Binaryzation";
            this.checkBox_Binaryzation.Size = new System.Drawing.Size(60, 16);
            this.checkBox_Binaryzation.TabIndex = 8;
            this.checkBox_Binaryzation.Text = "二值化";
            this.checkBox_Binaryzation.UseVisualStyleBackColor = true;
            // 
            // checkBox_Search
            // 
            this.checkBox_Search.AutoSize = true;
            this.checkBox_Search.Location = new System.Drawing.Point(338, 142);
            this.checkBox_Search.Name = "checkBox_Search";
            this.checkBox_Search.Size = new System.Drawing.Size(48, 16);
            this.checkBox_Search.TabIndex = 9;
            this.checkBox_Search.Text = "寻标";
            this.checkBox_Search.UseVisualStyleBackColor = true;
            // 
            // labelFound
            // 
            this.labelFound.AutoSize = true;
            this.labelFound.Location = new System.Drawing.Point(96, 305);
            this.labelFound.Name = "labelFound";
            this.labelFound.Size = new System.Drawing.Size(0, 12);
            this.labelFound.TabIndex = 10;
            // 
            // textBoxThreshold
            // 
            this.textBoxThreshold.Location = new System.Drawing.Point(591, 12);
            this.textBoxThreshold.Name = "textBoxThreshold";
            this.textBoxThreshold.Size = new System.Drawing.Size(72, 21);
            this.textBoxThreshold.TabIndex = 11;
            this.textBoxThreshold.TextChanged += new System.EventHandler(this.textBoxThreshold_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "阈值";
            // 
            // labelTurnValue
            // 
            this.labelTurnValue.AutoSize = true;
            this.labelTurnValue.Location = new System.Drawing.Point(549, 305);
            this.labelTurnValue.Name = "labelTurnValue";
            this.labelTurnValue.Size = new System.Drawing.Size(0, 12);
            this.labelTurnValue.TabIndex = 13;
            // 
            // label_TurnValue
            // 
            this.label_TurnValue.AutoSize = true;
            this.label_TurnValue.Location = new System.Drawing.Point(555, 305);
            this.label_TurnValue.Name = "label_TurnValue";
            this.label_TurnValue.Size = new System.Drawing.Size(0, 12);
            this.label_TurnValue.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 343);
            this.Controls.Add(this.label_TurnValue);
            this.Controls.Add(this.labelTurnValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxThreshold);
            this.Controls.Add(this.labelFound);
            this.Controls.Add(this.checkBox_Search);
            this.Controls.Add(this.checkBox_Binaryzation);
            this.Controls.Add(this.checkBox_Start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxAfter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSize);
            this.Name = "Form2";
            this.Text = "图像采集";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAfter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxAfter;
        private System.Windows.Forms.CheckBox checkBox_Start;
        private System.Windows.Forms.CheckBox checkBox_Binaryzation;
        private System.Windows.Forms.CheckBox checkBox_Search;
        private System.Windows.Forms.Label labelFound;
        private System.Windows.Forms.TextBox textBoxThreshold;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTurnValue;
        private System.Windows.Forms.Label label_TurnValue;
    }
}