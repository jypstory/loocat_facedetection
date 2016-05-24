namespace CATSEE_GATE_SYSTEM
{
    partial class VisitorVideoCapture
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
            this.label_help = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.cmb_cam = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 465);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label_help
            // 
            this.label_help.AutoSize = true;
            this.label_help.Location = new System.Drawing.Point(3, 12);
            this.label_help.Name = "label_help";
            this.label_help.Size = new System.Drawing.Size(189, 12);
            this.label_help.TabIndex = 1;
            this.label_help.Text = "※ 얼굴이 녹색으로 인식되면 클릭";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(405, 4);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(101, 29);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "캠 활성화";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.FaceDetection);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.cmb_cam);
            this.panel1.Controls.Add(this.label_help);
            this.panel1.Controls.Add(this.btn_start);
            this.panel1.Location = new System.Drawing.Point(9, 491);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 37);
            this.panel1.TabIndex = 3;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(512, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(65, 29);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "저장";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cmb_cam
            // 
            this.cmb_cam.FormattingEnabled = true;
            this.cmb_cam.Location = new System.Drawing.Point(198, 9);
            this.cmb_cam.Name = "cmb_cam";
            this.cmb_cam.Size = new System.Drawing.Size(201, 20);
            this.cmb_cam.TabIndex = 3;
            // 
            // VisitorVideoCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 530);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VisitorVideoCapture";
            this.Text = "얼굴추출";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VisitorVideoCapture_FormClosing);
            this.Load += new System.EventHandler(this.VisitorVideoCapture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_help;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_cam;
        private System.Windows.Forms.Button btn_save;
    }
}