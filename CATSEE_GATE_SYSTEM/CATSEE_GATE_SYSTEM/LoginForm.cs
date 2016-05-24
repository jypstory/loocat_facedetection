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
    public partial class LoginForm : Form
    {

        string connStrLocal = "";
        string connStrRemote = "";
        string runMode = "";
        
        public static string userName = "";


        dbConn_mysql _db = new dbConn_mysql();
        private DataTable dtList = new DataTable();

        private void LoginForm_Load(object sender, EventArgs e)
        {
            InitEvent();
            cleanTxb();
            
            Config conf = new Config();
            connStrLocal = conf.getConnStrLocal();
            connStrRemote = conf.getConnStrRemote();
            runMode = conf.getRunMode();
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        protected void InitEvent()
        {
            txb_pw.KeyDown += new KeyEventHandler(txb_pw_KeyDown);
        }

        //getter setter
        public string getUserName()
        {
            return userName;
        }
        public void setUserName(string param)
        {
            userName = param;
        }

        //
        public void cleanTxb()
        {
            this.txb_id.Text = "";
            this.txb_pw.Text = "";
            txb_id.Focus();
        }

        //패스워드에서 엔터 처리에 대한 event handler
        void txb_pw_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                btn_login_Click(sender, e);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.txb_id.Text.Equals("") && !this.txb_pw.Text.Equals(""))
                {

                    //계정 조회
                    dtList.Rows.Clear();
                    if (runMode.Equals("local")) dtList = _db.loginChk(txb_id.Text, txb_pw.Text);
                    if (dtList.Rows.Count.Equals(0))
                    {
                        MessageBox.Show("존재하지 않는 계정입니다.");
                        cleanTxb();
                        return;
                    }
                    else
                    {
                        this.Visible = false;  //현재 창 disable
                        setUserName(dtList.Rows[0]["admin_name"].ToString());  //set username

                        MainForm mainForm = new MainForm();
                        mainForm.StartPosition = FormStartPosition.Manual;
                        mainForm.Location = new Point(this.Location.X + 180, this.Location.Y);
                        
                        mainForm.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("계정 또는 설정을 확인해주세요", "[ERROR]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txb_id.Text = "";
                this.txb_pw.Text = "";
                this.txb_id.Focus();
                MessageBox.Show(ex.Message, "[ERROR]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }
        }

        private void txb_pw_Click(object sender, EventArgs e)
        {
            this.txb_pw.Text = "";
        }

      

    }
}
