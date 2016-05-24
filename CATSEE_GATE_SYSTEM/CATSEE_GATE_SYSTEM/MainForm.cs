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
    public partial class MainForm : Form
    {
        LoginForm loginForm = new LoginForm();

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.txb_welcome.Text = loginForm.getUserName() + "님 반갑습니다";
        }

        public MainForm()
        {
            InitializeComponent();

        }

        public void 출입자신규등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "VisitorAddForm")
                {
                    return;
                }
            }

            VisitorAddForm VisitorFormChild = new VisitorAddForm();
            VisitorFormChild.TopLevel = false;


            this.Controls.Add(VisitorFormChild);
            VisitorFormChild.Parent = this.mainPanel;
            VisitorFormChild.Show();
        }

        //출입자 조회 및 수정
        private void 출입자조회수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "VisitorListForm")
                {
                    return;
                }
            }

            VisitorListForm VisitorListFormChild = new VisitorListForm();
            VisitorListFormChild.TopLevel = false;


            this.Controls.Add(VisitorListFormChild);
            VisitorListFormChild.Parent = this.mainPanel;
            VisitorListFormChild.Show();
        }

        public void 관리자신규등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "AdminAddForm")
                {
                    return;
                }
            }

            AdminAddForm AdminAddFormChild = new AdminAddForm();
            AdminAddFormChild.TopLevel = false;


            this.Controls.Add(AdminAddFormChild);
            AdminAddFormChild.Parent = this.mainPanel;
            //Child.Text = "";
            //
            //Child.ControlBox = false;
            AdminAddFormChild.Show();
        }

        public void 관리자조회수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "AdminListForm")
                {
                    return;
                }
            }

            AdminListForm AdminListFormChild = new AdminListForm();
            AdminListFormChild.TopLevel = false;

            this.Controls.Add(AdminListFormChild);
            AdminListFormChild.Parent = this.mainPanel;
            //Child.Text = "";
            //
            //Child.ControlBox = false;
            AdminListFormChild.Show();
        }


        private void 출입자등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "VisitorAddForm")
                {
                    return;
                }
            }

            VisitorAddForm VisitorFormChild = new VisitorAddForm();
            VisitorFormChild.TopLevel = false;


            this.Controls.Add(VisitorFormChild);
            VisitorFormChild.Parent = this.mainPanel;
            //Child.Text = "";
            //
            //Child.ControlBox = false;
            VisitorFormChild.Show();
        }

        private void 출입자조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "VisitorListForm")
                {
                    return;
                }
            }

            VisitorListForm VisitorListFormChild = new VisitorListForm();
            VisitorListFormChild.TopLevel = false;


            this.Controls.Add(VisitorListFormChild);
            VisitorListFormChild.Parent = this.mainPanel;
            //Child.Text = "";
            //
            //Child.ControlBox = false;
            VisitorListFormChild.Show();
        }


        //로컬Cam 모드
        private void 로컬CamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "LocalCamForm")
                {
                    return;
                }
            }
            */


            LocalCamForm _form = new LocalCamForm();
            _form.TopLevel = false;


            this.Controls.Add(_form);
            _form.Parent = this.mainPanel;
            _form.Show();
        }

        //IPCam 모드
        private void iPCamToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "LocalCamForm")
                {
                    return;
              
            }
            */


            IPCamForm_new _form = new IPCamForm_new();
            _form.TopLevel = false;


            this.Controls.Add(_form);
            _form.Parent = this.mainPanel;
            _form.Show();
        }

        /*
        private void macToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skinEngine1.ApplyAdditionalBuiltInSkins(2);
            if (!skinEngine1.Active)
                skinEngine1.Active = true;
        }
        */



        //도움말
        public void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("Catsee Gate System \r\n\r\n© COPYRIGHT 2015 SK HOLDINGS C&C CO. LTD, Inc.\r\nhttp://cc.sk.co.kr", "About");

        }

        public void aboutCatseeGateSolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Catsee Gate System \r\n\r\n© COPYRIGHT 2015 SK HOLDINGS C&C CO. LTD, Inc.\r\nhttp://cc.sk.co.kr", "About");
        }



        private void 출입모드ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "EnterModeForm")
                {
                    return;

                }
            }

                EnterModeForm _form = new EnterModeForm();
                _form.TopLevel = false;


                this.Controls.Add(_form);
                _form.Parent = this.mainPanel;
                _form.Show();
         
        }
    }
}
