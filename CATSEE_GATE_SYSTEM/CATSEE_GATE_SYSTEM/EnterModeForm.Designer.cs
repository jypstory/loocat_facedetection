namespace CATSEE_GATE_SYSTEM
{
    partial class EnterModeForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmb_cam = new System.Windows.Forms.ComboBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.txb_cardnum = new System.Windows.Forms.TextBox();
            this.label_help = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(644, 443);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // cmb_cam
            // 
            this.cmb_cam.FormattingEnabled = true;
            this.cmb_cam.Location = new System.Drawing.Point(653, 426);
            this.cmb_cam.Name = "cmb_cam";
            this.cmb_cam.Size = new System.Drawing.Size(296, 20);
            this.cmb_cam.TabIndex = 6;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(653, 339);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(296, 81);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "캠 활성화";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.FaceDetection);
            // 
            // txb_cardnum
            // 
            this.txb_cardnum.BackColor = System.Drawing.SystemColors.Info;
            this.txb_cardnum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txb_cardnum.Location = new System.Drawing.Point(734, 3);
            this.txb_cardnum.Name = "txb_cardnum";
            this.txb_cardnum.Size = new System.Drawing.Size(215, 21);
            this.txb_cardnum.TabIndex = 7;
            // 
            // label_help
            // 
            this.label_help.AutoSize = true;
            this.label_help.Location = new System.Drawing.Point(651, 6);
            this.label_help.Name = "label_help";
            this.label_help.Size = new System.Drawing.Size(77, 12);
            this.label_help.TabIndex = 8;
            this.label_help.Text = "출입카드번호";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(78, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(144, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(78, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(144, 42);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 71);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 23);
            this.button7.TabIndex = 15;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(78, 71);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 23);
            this.button8.TabIndex = 16;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(144, 71);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 23);
            this.button9.TabIndex = 17;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 100);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(60, 23);
            this.button10.TabIndex = 18;
            this.button10.Text = "*";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(78, 100);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(60, 23);
            this.button11.TabIndex = 19;
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(144, 100);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(60, 23);
            this.button12.TabIndex = 20;
            this.button12.Text = "#";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "출입비번";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Location = new System.Drawing.Point(734, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 177);
            this.panel1.TabIndex = 22;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(12, 129);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(192, 34);
            this.button14.TabIndex = 21;
            this.button14.Text = "RESET";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(653, 233);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(296, 83);
            this.button13.TabIndex = 23;
            this.button13.Text = "호출";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // EnterModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 458);
            this.Controls.Add(this.cmb_cam);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_help);
            this.Controls.Add(this.txb_cardnum);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EnterModeForm";
            this.Text = "출입모드";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EnterModeForm_FormClosing);
            this.Load += new System.EventHandler(this.EnterModeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmb_cam;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox txb_cardnum;
        private System.Windows.Forms.Label label_help;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
    }
}