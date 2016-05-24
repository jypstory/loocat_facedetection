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
    public partial class AdminListForm : Form
    {
        dbConn_mysql _db = new dbConn_mysql();
        private DataTable dtList = new DataTable();

        string connStrLocal = "";
        string connStrRemote = "";
        string runMode = "";

        AdminAddForm auaf = null;  //관리자 입력 form

        private void AdminForm_Load(object sender, EventArgs e)
        {
            setConfig();
            cleanTxb();
            InitGrid();
        }

        public AdminListForm()
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
            this.txb_name.Text = "";
            this.txb_alias.Text = "";
            this.txb_tel.Text = "";
            this.txb_email.Text = "";
            this.txb_description.Text = "";
        }


        private void InitGrid()
        {
            _grid.ColumnCount = 2;

            _grid.Columns[0].Name = "아이디";
            _grid.Columns[0].Width = 100;
            _grid.Columns[0].Resizable = DataGridViewTriState.True;
            _grid.Columns[1].Name = "이름";
            _grid.Columns[1].Width = 160;
            _grid.Columns[1].Resizable = DataGridViewTriState.True;
        }

        
        private void btn_search_Click(object sender, EventArgs e)
        {
            //InitGrid();
            _grid.Rows.Clear();

            if (runMode.Equals("local")) dtList = _db.selectAdminUserAll();

            object[] row1 = new object[13];

            if (dtList.Rows.Count.Equals(0))
            {
                MessageBox.Show("계정이 없습니다.");
                cleanTxb();
                return;
            }
            else
            {
                foreach (DataRow dr in dtList.Rows)
                {
                    row1[0] = dr[0].ToString(); //ID
                    row1[1] = dr[1].ToString(); //이름
                    _grid.Rows.Add(row1);
                    row1.Initialize();
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "AdminAddForm")
                {
                    return;
                }
                else
                {
                    AdminAddForm adminAddForm = new AdminAddForm();
                    DialogResult dlgResult = adminAddForm.ShowDialog();
                    
                    break;
                }
            }
           
           
        }

        //수정
        private void btn_save_Click(object sender, EventArgs e)
        {
            string sqlRslt = "";
            string[] code = new string[9];

            code[0] = this.txb_id.Text;
            //code[1] = this.txb_pw.Text;
            code[2] = this.txb_name.Text;
            code[3] = this.txb_alias.Text;
            code[4] = this.txb_tel.Text;
            code[5] = this.txb_email.Text;
            code[6] = this.txb_description.Text;

            if (runMode.Equals("local")) sqlRslt = _db.updateAdminUser(code);  //return 항목ID
            if (!sqlRslt.Equals("FAIL"))
            {
                MessageBox.Show("자료가 성공적으로 수정되었습니다.");
               
            }
        }

        //삭제
        private void btn_delete_Click(object sender, EventArgs e)
        {
            string sqlRslt = "";
            string[] code = new string[9];

            code[0] = this.txb_id.Text;
           

            if (runMode.Equals("local")) sqlRslt = _db.deleteAdminUser(code);  //return 항목ID
            if (!sqlRslt.Equals("FAIL"))
            {
                MessageBox.Show("자료가 성공적으로 수정되었습니다.");

            }
        }


        private void _grid_SelectionChanged(object sender, EventArgs e)
        {

            String ID = _grid.CurrentRow.Cells[0].Value.ToString();

            if (runMode.Equals("local")) dtList = _db.selectAdminUser(ID);
            if (dtList.Rows.Count.Equals(0))
            {
                MessageBox.Show("계정이 없습니다.");
                cleanTxb();
                return;
            }
            else
            {          
                this.txb_id.Text = dtList.Rows[0]["admin_id"].ToString();
                this.txb_name.Text = dtList.Rows[0]["admin_name"].ToString();
                this.txb_alias.Text = dtList.Rows[0]["alias"].ToString();
                this.txb_tel.Text = dtList.Rows[0]["tel"].ToString();
                this.txb_email.Text = dtList.Rows[0]["email"].ToString();
                this.txb_description.Text = dtList.Rows[0]["description"].ToString();
            }
        }
    }
}
