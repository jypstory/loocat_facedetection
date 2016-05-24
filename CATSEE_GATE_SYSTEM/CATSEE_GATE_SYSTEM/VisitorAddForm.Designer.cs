namespace CATSEE_GATE_SYSTEM
{
    partial class VisitorAddForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_video = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_cardnum = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txb_description = new System.Windows.Forms.TextBox();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.txb_tel = new System.Windows.Forms.TextBox();
            this.txb_alias = new System.Windows.Forms.TextBox();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(19, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "얼굴영상";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_video
            // 
            this.btn_video.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_video.Location = new System.Drawing.Point(19, 268);
            this.btn_video.Name = "btn_video";
            this.btn_video.Size = new System.Drawing.Size(302, 98);
            this.btn_video.TabIndex = 1;
            this.btn_video.Text = "영상추출";
            this.btn_video.UseVisualStyleBackColor = true;
            this.btn_video.Click += new System.EventHandler(this.btn_video_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txb_cardnum);
            this.groupBox2.Location = new System.Drawing.Point(345, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 53);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "출입카드 정보";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "일련번호";
            // 
            // txb_cardnum
            // 
            this.txb_cardnum.Location = new System.Drawing.Point(77, 20);
            this.txb_cardnum.Name = "txb_cardnum";
            this.txb_cardnum.Size = new System.Drawing.Size(382, 21);
            this.txb_cardnum.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txb_description);
            this.groupBox4.Controls.Add(this.txb_email);
            this.groupBox4.Controls.Add(this.txb_tel);
            this.groupBox4.Controls.Add(this.txb_alias);
            this.groupBox4.Controls.Add(this.txb_name);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(345, 82);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(465, 285);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "상세정보";
            // 
            // txb_description
            // 
            this.txb_description.Location = new System.Drawing.Point(77, 128);
            this.txb_description.Multiline = true;
            this.txb_description.Name = "txb_description";
            this.txb_description.Size = new System.Drawing.Size(382, 151);
            this.txb_description.TabIndex = 13;
            // 
            // txb_email
            // 
            this.txb_email.Location = new System.Drawing.Point(77, 101);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(382, 21);
            this.txb_email.TabIndex = 12;
            // 
            // txb_tel
            // 
            this.txb_tel.Location = new System.Drawing.Point(77, 74);
            this.txb_tel.Name = "txb_tel";
            this.txb_tel.Size = new System.Drawing.Size(382, 21);
            this.txb_tel.TabIndex = 11;
            // 
            // txb_alias
            // 
            this.txb_alias.Location = new System.Drawing.Point(77, 47);
            this.txb_alias.Name = "txb_alias";
            this.txb_alias.Size = new System.Drawing.Size(382, 21);
            this.txb_alias.TabIndex = 8;
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(77, 20);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(382, 21);
            this.txb_name.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "별칭";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "기타";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "전화번호";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "이름";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(488, 373);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(104, 32);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "저장";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancle
            // 
            this.btn_cancle.Location = new System.Drawing.Point(598, 373);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(104, 32);
            this.btn_cancle.TabIndex = 6;
            this.btn_cancle.Text = "취소";
            this.btn_cancle.UseVisualStyleBackColor = true;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(708, 373);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(104, 32);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "초기화";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // VisitorAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 425);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_video);
            this.Controls.Add(this.groupBox1);
            this.Name = "VisitorAddForm";
            this.Text = "출입자 신규등록";
            this.Load += new System.EventHandler(this.VisitorForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_video;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_cardnum;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txb_description;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.TextBox txb_tel;
        private System.Windows.Forms.TextBox txb_alias;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.Button btn_reset;

        
    }
}