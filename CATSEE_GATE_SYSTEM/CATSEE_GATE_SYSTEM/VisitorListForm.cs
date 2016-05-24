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
    public partial class VisitorListForm : Form
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

        public VisitorListForm()
        {
            InitializeComponent();
        }

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
            this.txb_cardnum.Text = ""; 
            this.txb_name.Text = "";
            this.txb_alias.Text = "";
            this.txb_tel.Text = "";
            this.txb_email.Text = "";
            this.txb_description.Text = "";
            img_filename = "";
            img_dir = "";
        }


        private void InitGrid()
        {
            _grid.ColumnCount = 3;
            _grid.Columns[0].Name = "순번";
            _grid.Columns[0].Width = 30;
            _grid.Columns[0].Resizable = DataGridViewTriState.True;
            _grid.Columns[1].Name = "이름";
            _grid.Columns[1].Width = 100;
            _grid.Columns[1].Resizable = DataGridViewTriState.True;
            _grid.Columns[2].Name = "별칭";
            _grid.Columns[2].Width = 160;
            _grid.Columns[2].Resizable = DataGridViewTriState.True;
        }

        private void VisitorListForm_Load(object sender, EventArgs e)
        {
            setConfig();
            cleanTxb();
            InitGrid();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            if (runMode.Equals("local")) dtList = _db.selectVisitorAll(txb_srch_name.Text, txb_srch_alias.Text);
            object[] row1 = new object[13];
            if (dtList.Rows.Count.Equals(0))
            {
                MessageBox.Show("조회내역이 없습니다.");
                cleanTxb();
                return;
            }
            else
            {
                _grid.Rows.Clear();

                foreach (DataRow dr in dtList.Rows)
                {
                    row1[0] = dr[0].ToString(); //순번
                    row1[1] = dr[1].ToString(); //이름
                    row1[2] = dr[2].ToString(); //별칭
                    _grid.Rows.Add(row1);
                    row1.Initialize();
                }
            }
        }

        private void _grid_SelectionChanged(object sender, EventArgs e)
        {
            String USER_SEQ = _grid.CurrentRow.Cells[0].Value.ToString();

            if (runMode.Equals("local")) dtList = _db.selectVisitorUser(USER_SEQ);
            if (dtList.Rows.Count.Equals(0))
            {
                MessageBox.Show("조회내역이 없습니다.");
                cleanTxb();
                return;
            }
            else
            {
                this.txb_cardnum.Text = dtList.Rows[0]["cardnum"].ToString();
                this.txb_name.Text = dtList.Rows[0]["user_name"].ToString();
                this.txb_alias.Text = dtList.Rows[0]["alias"].ToString();
                this.txb_tel.Text = dtList.Rows[0]["tel"].ToString();
                this.txb_email.Text = dtList.Rows[0]["email"].ToString();
                this.txb_description.Text = dtList.Rows[0]["description"].ToString();
                img_filename = dtList.Rows[0]["img_filename"].ToString();
                img_dir = dtList.Rows[0]["img_dir"].ToString();

                pictureBox1.ImageLocation = System.IO.Path.Combine(dataRootDir, img_filename);

            }
        }

        private void btn_video_Click(object sender, EventArgs e)
        {
            //VisitorVideoCapture가 열려 있으면 return
            VisitorVideoCapture vvc = null;
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
    }
}
