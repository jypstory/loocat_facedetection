namespace CATSEE_GATE_SYSTEM
{
    partial class AdminAddForm
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
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_dupck = new System.Windows.Forms.Button();
            this.txb_pw = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txb_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_description = new System.Windows.Forms.TextBox();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.txb_tel = new System.Windows.Forms.TextBox();
            this.txb_alias = new System.Windows.Forms.TextBox();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(124, 357);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(90, 30);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "저장";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancle
            // 
            this.btn_cancle.Location = new System.Drawing.Point(223, 357);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(90, 30);
            this.btn_cancle.TabIndex = 11;
            this.btn_cancle.Text = "취소";
            this.btn_cancle.UseVisualStyleBackColor = true;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_dupck);
            this.groupBox2.Controls.Add(this.txb_pw);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txb_id);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txb_description);
            this.groupBox2.Controls.Add(this.txb_email);
            this.groupBox2.Controls.Add(this.txb_tel);
            this.groupBox2.Controls.Add(this.txb_alias);
            this.groupBox2.Controls.Add(this.txb_name);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(12, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 348);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "정보입력";
            // 
            // btn_dupck
            // 
            this.btn_dupck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_dupck.Location = new System.Drawing.Point(249, 28);
            this.btn_dupck.Name = "btn_dupck";
            this.btn_dupck.Size = new System.Drawing.Size(81, 26);
            this.btn_dupck.TabIndex = 17;
            this.btn_dupck.Text = "중복확인";
            this.btn_dupck.UseVisualStyleBackColor = true;
            this.btn_dupck.Click += new System.EventHandler(this.btn_dupck_Click);
            // 
            // txb_pw
            // 
            this.txb_pw.Location = new System.Drawing.Point(77, 60);
            this.txb_pw.Name = "txb_pw";
            this.txb_pw.Size = new System.Drawing.Size(166, 25);
            this.txb_pw.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "PW";
            // 
            // txb_id
            // 
            this.txb_id.Location = new System.Drawing.Point(77, 29);
            this.txb_id.Name = "txb_id";
            this.txb_id.Size = new System.Drawing.Size(166, 25);
            this.txb_id.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "ID";
            // 
            // txb_description
            // 
            this.txb_description.Location = new System.Drawing.Point(77, 245);
            this.txb_description.Multiline = true;
            this.txb_description.Name = "txb_description";
            this.txb_description.Size = new System.Drawing.Size(382, 82);
            this.txb_description.TabIndex = 9;
            // 
            // txb_email
            // 
            this.txb_email.Location = new System.Drawing.Point(77, 214);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(166, 25);
            this.txb_email.TabIndex = 8;
            // 
            // txb_tel
            // 
            this.txb_tel.Location = new System.Drawing.Point(77, 179);
            this.txb_tel.Name = "txb_tel";
            this.txb_tel.Size = new System.Drawing.Size(166, 25);
            this.txb_tel.TabIndex = 7;
            // 
            // txb_alias
            // 
            this.txb_alias.Location = new System.Drawing.Point(77, 146);
            this.txb_alias.Name = "txb_alias";
            this.txb_alias.Size = new System.Drawing.Size(166, 25);
            this.txb_alias.TabIndex = 5;
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(77, 113);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(166, 25);
            this.txb_name.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "별칭";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "기타";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "전화번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(319, 357);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(90, 30);
            this.btn_reset.TabIndex = 12;
            this.btn_reset.Text = "초기화";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // AdminAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 397);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.btn_save);
            this.Name = "AdminAddForm";
            this.Text = "관리자 신규등록";
            this.Load += new System.EventHandler(this.AdminAddForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txb_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_description;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.TextBox txb_tel;
        private System.Windows.Forms.TextBox txb_alias;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_pw;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_dupck;
        private System.Windows.Forms.Button btn_reset;

    }
}