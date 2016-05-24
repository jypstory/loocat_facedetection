using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CATSEE_GATE_SYSTEM
{
    public partial class AdminAddForm : Form
    {
        dbConn_mysql _db = new dbConn_mysql();
        private DataTable dtList = new DataTable();

        string connStrLocal = "";
        string connStrRemote = "";
        string runMode = "";

        int dupCk = 0;


        private void AdminAddForm_Load(object sender, EventArgs e)
        {
            setConfig();
            cleanTxb();
        }

        public AdminAddForm()
        {
            InitializeComponent();
         

        }
        private void setConfig()
        {
            connStrLocal = Properties.Settings.Default.sqlUrlLocal.ToString();
            connStrRemote = Properties.Settings.Default.sqlUrlRemote.ToString();
            runMode = Properties.Settings.Default.runMode.ToString();

        }

        public void cleanTxb()
        {
            this.txb_id.Text = "";
            this.txb_pw.Text = "";
            this.txb_name.Text = "";
            this.txb_alias.Text = "";
            this.txb_tel.Text = "";
            this.txb_email.Text = "";
            this.txb_description.Text = "";

            this.txb_id.Focus();
            this.btn_dupck.ForeColor = Color.Red;
            dupCk = 0;
        }

        string[] code = new string[9];

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sqlRslt = "";
            if (dupCk == 1)
            {
                code[0] = this.txb_id.Text;
                code[1] = this.txb_pw.Text;
                code[2] = this.txb_name.Text;
                code[3] = this.txb_alias.Text;
                code[4] = this.txb_tel.Text;
                code[5] = this.txb_email.Text;
                code[6] = this.txb_description.Text;

                
                if (runMode.Equals("local")) sqlRslt = _db.insertAdminUser(code);  //return 항목ID
                if (!sqlRslt.Equals("FAIL"))
                {
                    MessageBox.Show("자료가 성공적으로 저장되었습니다.");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("ID 중복체크를 해주세요");
                this.txb_id.Focus();
            }

        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //중복체크
        private void btn_dupck_Click(object sender, EventArgs e)
        {
            String ID = this.txb_id.Text;
            dtList.Rows.Clear();
            if (runMode.Equals("local")) dtList = _db.checkAdminIdDup(ID);
            if (txb_id.Text == "")
            {
                MessageBox.Show("ID를 입력해주세요");
                this.txb_id.Text = "";
                this.txb_id.Focus();
                this.btn_dupck.ForeColor = Color.Red;
                dupCk = 0;
            }
            else if (dtList.Rows.Count.Equals(0))
            {
                MessageBox.Show("사용 가능한 ID입니다.");
                this.btn_dupck.ForeColor = Color.Black;
                dupCk = 1;
            }
            else
            {
                MessageBox.Show("중복된 ID가 있습니다.");
                this.txb_id.Text = "";
                this.txb_id.Focus();
                this.btn_dupck.ForeColor = Color.Red;
                dupCk = 0;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            cleanTxb();
        }

        
    }
}
