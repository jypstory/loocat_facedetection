namespace CATSEE_GATE_SYSTEM
{
    partial class VisitorListForm
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
            this._grid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txb_description = new System.Windows.Forms.TextBox();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.txb_tel = new System.Windows.Forms.TextBox();
            this.txb_alias = new System.Windows.Forms.TextBox();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txb_cardnum = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_srch_name = new System.Windows.Forms.TextBox();
            this.txb_srch_alias = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_video = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._grid);
            this.groupBox1.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 338);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "출입자 List";
            // 
            // _grid
            // 
            this._grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._grid.Location = new System.Drawing.Point(6, 24);
            this._grid.Name = "_grid";
            this._grid.ReadOnly = true;
            this._grid.RowTemplate.Height = 23;
            this._grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._grid.Size = new System.Drawing.Size(210, 308);
            this._grid.TabIndex = 0;
            this._grid.SelectionChanged += new System.EventHandler(this._grid_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txb_description);
            this.groupBox2.Controls.Add(this.txb_email);
            this.groupBox2.Controls.Add(this.txb_tel);
            this.groupBox2.Controls.Add(this.txb_alias);
            this.groupBox2.Controls.Add(this.txb_name);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(465, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 279);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "상세정보";
            // 
            // txb_description
            // 
            this.txb_description.Location = new System.Drawing.Point(77, 128);
            this.txb_description.Multiline = true;
            this.txb_description.Name = "txb_description";
            this.txb_description.Size = new System.Drawing.Size(264, 135);
            this.txb_description.TabIndex = 13;
            // 
            // txb_email
            // 
            this.txb_email.Location = new System.Drawing.Point(77, 101);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(264, 21);
            this.txb_email.TabIndex = 12;
            // 
            // txb_tel
            // 
            this.txb_tel.Location = new System.Drawing.Point(77, 74);
            this.txb_tel.Name = "txb_tel";
            this.txb_tel.Size = new System.Drawing.Size(264, 21);
            this.txb_tel.TabIndex = 11;
            // 
            // txb_alias
            // 
            this.txb_alias.Location = new System.Drawing.Point(77, 47);
            this.txb_alias.Name = "txb_alias";
            this.txb_alias.Size = new System.Drawing.Size(264, 21);
            this.txb_alias.TabIndex = 8;
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(77, 20);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(264, 21);
            this.txb_name.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "별칭";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 131);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "이름";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txb_cardnum);
            this.groupBox3.Location = new System.Drawing.Point(465, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 53);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "출입카드 정보";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "일련번호";
            // 
            // txb_cardnum
            // 
            this.txb_cardnum.Location = new System.Drawing.Point(77, 20);
            this.txb_cardnum.Name = "txb_cardnum";
            this.txb_cardnum.Size = new System.Drawing.Size(264, 21);
            this.txb_cardnum.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Location = new System.Drawing.Point(246, 75);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(213, 181);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "얼굴 정보";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(410, 24);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(114, 41);
            this.btn_search.TabIndex = 18;
            this.btn_search.Text = "조회";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "이름";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "별칭";
            // 
            // txb_srch_name
            // 
            this.txb_srch_name.Location = new System.Drawing.Point(47, 23);
            this.txb_srch_name.Name = "txb_srch_name";
            this.txb_srch_name.Size = new System.Drawing.Size(129, 21);
            this.txb_srch_name.TabIndex = 7;
            // 
            // txb_srch_alias
            // 
            this.txb_srch_alias.Location = new System.Drawing.Point(234, 20);
            this.txb_srch_alias.Name = "txb_srch_alias";
            this.txb_srch_alias.Size = new System.Drawing.Size(129, 21);
            this.txb_srch_alias.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txb_srch_alias);
            this.groupBox4.Controls.Add(this.txb_srch_name);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(389, 57);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "조회조건";
            // 
            // btn_video
            // 
            this.btn_video.Location = new System.Drawing.Point(246, 265);
            this.btn_video.Name = "btn_video";
            this.btn_video.Size = new System.Drawing.Size(213, 70);
            this.btn_video.TabIndex = 22;
            this.btn_video.Text = "영상추출";
            this.btn_video.UseVisualStyleBackColor = true;
            this.btn_video.Click += new System.EventHandler(this.btn_video_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(531, 24);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(115, 41);
            this.btn_save.TabIndex = 23;
            this.btn_save.Text = "수정";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(652, 24);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(115, 41);
            this.btn_delete.TabIndex = 24;
            this.btn_delete.Text = "삭제";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // VisitorListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 425);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_video);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.groupBox4);
            this.Name = "VisitorListForm";
            this.Text = "출입자 조회 / 수정";
            this.Load += new System.EventHandler(this.VisitorListForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView _grid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txb_description;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.TextBox txb_tel;
        private System.Windows.Forms.TextBox txb_alias;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txb_cardnum;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_srch_name;
        private System.Windows.Forms.TextBox txb_srch_alias;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_video;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;

    }
}