using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Luxand;


namespace CATSEE_GATE_SYSTEM
{
    public partial class VisitorAddForm : Form
    {

        dbConn_mysql _db = new dbConn_mysql();
        private DataTable dtList = new DataTable();

        String connStrLocal = "";
        String connStrRemote = "";
        String runMode = "";
        String dataRootDir = "";
        String activeKey = "";
        String img_filename = "";
        String img_dir = "";

        private void setConfig()
        {
            Config conf = new Config();
            connStrLocal = conf.getConnStrLocal();
            connStrRemote = conf.getConnStrRemote();
            runMode = conf.getRunMode();
            dataRootDir = conf.getDataRootDir();
            activeKey = conf.getActiveKey();
        }

        public void cleanTxb()
        {
            this.txb_name.Text = "";
            this.txb_alias.Text = "";
            this.txb_tel.Text = "";
            this.txb_email.Text = "";
            this.txb_description.Text = "";
            this.txb_cardnum.Text = "";

            this.pictureBox1.ImageLocation = null;
            this.txb_cardnum.Focus();

        }

        // WinAPI procedure to release HBITMAP handles returned by FSDKCam.GrabFrame
        [DllImport("gdi32.dll")]
        static extern bool DeleteObject(IntPtr hObject);


        private void VisitorForm_Load(object sender, EventArgs e)
        {
            this.setConfig();
            this.cleanTxb();

            if (FSDK.FSDKE_OK != FSDK.ActivateLibrary(activeKey))
            {
                MessageBox.Show("Please run the License Key Wizard (Start - Luxand - FaceSDK - License Key Wizard)", "Error activating FaceSDK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            FSDK.InitializeLibrary();
        }

        VisitorVideoCapture vvc = null;

        public VisitorAddForm()
        {
            InitializeComponent();
         
        }
        private void btn_video_Click(object sender, EventArgs e)
        {
            if (txb_cardnum.Text=="")
            {
                MessageBox.Show("출입카드정보를 등록해주세요");
                txb_cardnum.Focus();
                return;
            }

            //VisitorVideoCapture가 열려 있으면 return
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "VisitorVideoCapture")
                {
                    return;
                }
            }

            vvc = new VisitorVideoCapture();
            vvc.StartPosition = FormStartPosition.Manual;
            vvc.Location = new Point(this.Location.X + 10, this.Location.Y);
            vvc.visit_name = this.txb_name.Text;
            
            if (DialogResult.OK == vvc.ShowDialog())
            {
                img_filename = vvc.visitorImgFileName;
                img_dir = vvc.visitorDataDir;
                pictureBox1.ImageLocation = System.IO.Path.Combine(img_dir, img_filename);
            }
        }

        string[] code = new string[20];

        private void btn_save_Click(object sender, EventArgs e)
        {
            /* 
user_id varchar(30) NOT NULL,  -- 사번
user_name varchar(30) NOT NULL,
department varchar(100),   -- 소속
job varchar(100),     -- 직책
position varchar(100),  -- 직급
tel varchar(30),
email varchar(100),
active varchar(1), 
gubun varchar(2),
description varchar(1000),
img_pos varchar(4000),  -- 이미지 파일 저장위치
cardnum varchar(4000),  -- 출입카드정보
create_admin_id varchar(30),
modify_admin_id varchar(30),
craete_date TIMESTAMP,
modify_date TIMESTAMP,
            */
            code[0] = this.txb_cardnum.Text;
            code[1] = this.txb_name.Text;
            code[2] = this.txb_alias.Text;
            code[3] = this.txb_tel.Text;
            code[4] = this.txb_email.Text;
            code[5] = this.txb_description.Text;
            code[6] = img_dir;
            code[7] = img_filename;
            code[8] = "Y";
            code[9] = "1";
            code[10] = ""; //create_admin_id
            code[11] = ""; //modify_admin_id
            string sqlRslt = "";
            if (runMode.Equals("local")) sqlRslt = _db.insertVisitUser(code);  //return 항목ID
            if (!sqlRslt.Equals("FAIL"))
            {
                MessageBox.Show("자료가 성공적으로 저장되었습니다.");
                this.Close();
            }
        }
        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.cleanTxb();
            this.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.cleanTxb();
        }
    }
}
