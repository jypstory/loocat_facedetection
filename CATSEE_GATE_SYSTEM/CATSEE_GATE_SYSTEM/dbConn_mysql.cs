using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;



namespace CATSEE_GATE_SYSTEM
{
    class dbConn_mysql
    {
        MySqlConnection conn = new MySqlConnection();

        string connStrLocal = "";
        string connStrRemote = "";
        string runMode = "";


        private void setConfig()
        {
            connStrLocal = Properties.Settings.Default.sqlUrlLocal.ToString();
            connStrRemote = Properties.Settings.Default.sqlUrlRemote.ToString();
            runMode = Properties.Settings.Default.runMode.ToString();
        }

        public dbConn_mysql()
        {
            setConfig();
        }

        //DB 접속정보
        static private string getConnUrlLocal()
        {
            return Properties.Settings.Default.sqlUrlLocal.ToString();
        }
        static private string getConnUrlRemote()
        {
            return Properties.Settings.Default.sqlUrlRemote.ToString();
        }
        
        //DB 연결
        private void ConnDB()
        {
            try
            {
                setConfig();
                if (conn.State.ToString().Equals("Closed"))
                {
                    conn.ConnectionString = getConnUrlLocal();
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                setConfig();
                ClsDB();
                MessageBox.Show(ex.Message, "[ERROR]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        //DB 닫기
        public void ClsDB()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

        //Admin ID 중복체크
        public DataTable checkAdminIdDup(string id)
        {
            ConnDB();
            string sql = "select admin_id from LC.ADMIN_USER where admin_id = '" + id + "' and active='Y';";

            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            try
            {
                adpt.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "[ERROR]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ClsDB();
            }
            return dt;
        }

        public DataTable loginChk(string id, string pw)
        {
            ConnDB();
            string sql = "select admin_id, admin_name, gubun from LC.ADMIN_USER where admin_id = '"+id+"' and admin_pw = '"+pw+"';";

            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            try
            {
                adpt.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "[ERROR]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ClsDB();
            }
            return dt;
        }

        public DataTable selectAdminUserAll()
        {
            ConnDB();
            string sql = "select admin_id, admin_name, gubun from LC.ADMIN_USER where active='Y';";

            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            try
            {
                adpt.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "[ERROR]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ClsDB();
            }
            return dt;
        }

        public DataTable selectAdminUser(String ID)
        {
            ConnDB();
            string sql = "select admin_id, "
                + "admin_pw, "
                + "admin_name, "
                + "alias, "
                + "tel, "
                + "email, "
                + "description, "
                + "active, "
                + "gubun, "                
                + "craete_date, "
                + "modify_date "
                + "from LC.ADMIN_USER "
                + "where active='Y' and admin_id = '" + ID + "';";

            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            try
            {
                adpt.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "[ERROR]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ClsDB();
            }
            return dt;
        }


        public string insertAdminUser(string[] arrVar)
        {
            ConnDB();
            try
            {
                String SystemTime = System.DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"); 

                 MySqlCommand cmd = new MySqlCommand("INSERT INTO LC.ADMIN_USER VALUES ('"
                    + arrVar[0] + "','"  //id
                    + arrVar[1] + "','"  //pw
                    + arrVar[2] + "','"  //이름
                    + arrVar[3] + "','"  //별칭
                    + arrVar[4] + "','"  //전화번호
                    + arrVar[5] + "','"  //email
                    + arrVar[6] + "','"  //기타
                    + "Y" + "','"   //active
                    + "1" + "','"    //gubun
                    + SystemTime +"','"
                    + SystemTime + "'); ", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "[ERROR]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "FAIL";
            }
            finally
            {
                ClsDB();
            }

            return "SUCCESS";

        }

        public string updateAdminUser(string[] arrVar)
        {
            ConnDB();
            try
            {
                String SystemTime = System.DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

                //update ABCDE set column1='xyz' where no='3'

                MySqlCommand cmd = new MySqlCommand("UPDATE LC.ADMIN_USER SET "
                   + "admin_name = '" + arrVar[2] + "',"
                   + "alias = '" + arrVar[3] + "',"
                   + "tel = '" + arrVar[4] + "',"
                   + "email = '" + arrVar[5] + "',"
                   + "description = '" + arrVar[6] + "',"
                   + "modify_date = '" + SystemTime
                   + "' where admin_id='" + arrVar[0] +"';", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "[ERROR]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "FAIL";
            }
            finally
            {
                ClsDB();
            }

            return "SUCCESS";

        }

        public string deleteAdminUser(string[] arrVar)
        {
            ConnDB();
            try
            {
                String SystemTime = System.DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

                //update ABCDE set column1='xyz' where no='3'

                MySqlCommand cmd = new MySqlCommand("UPDATE LC.ADMIN_USER SET "
                   + "active = 'N', "
                   + "modify_date = '" + SystemTime
                   + "' where admin_id='" + arrVar[0] + "';", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "[ERROR]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "FAIL";
            }
            finally
            {
                ClsDB();
            }

            return "SUCCESS";

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="_NAME"></param>
        /// <param name="_DEPT"></param>
        /// <returns></returns>

        public DataTable selectVisitorAll(string _NAME, string _ALIAS)
        {
            ConnDB();
            string sql = "select user_seq, "
                + "cardnum, "
                + "user_name, "
                + "alias, "
                + "tel, "
                + "email, "
                + "description, "
                + "active, "
                + "email, "
                + "gubun, "
                + "create_admin_id, "
                + "modify_admin_id, "
                + "craete_date, "
                + "modify_date "
                + "from LC.VISIT_USER "
                + "where active='Y' ";

            if (!_NAME.Equals("")) sql = sql + "and user_name = '" + _NAME + "'";
            if (!_ALIAS.Equals("")) sql = sql + "and alias = '" + _ALIAS + "'";

            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            try
            {
                adpt.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "[ERROR]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ClsDB();
            }
            return dt;
        }

        public DataTable selectVisitorUser(string _USER_SEQ)
        {
            ConnDB();
            string sql = "select user_seq, "
                + "cardnum, "
                + "user_name, "
                + "alias, "
                + "tel, "
                + "email, "
                + "description, "
                + "img_dir, "
                + "img_filename, "
                + "active, "
                + "gubun, "
                + "create_admin_id, "
                + "modify_admin_id, "
                + "craete_date, "
                + "modify_date "
                + "from LC.VISIT_USER "
                + "where active='Y' ";

            if (!_USER_SEQ.Equals("")) sql = sql + "and user_seq = '" + _USER_SEQ + "'";
            
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            try
            {
                adpt.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "[ERROR]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ClsDB();
            }
            return dt;
        }



        public string insertVisitUser(String[] arrVar)
        {
            ConnDB();
            try
            {
                String SystemTime = System.DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

                MySqlCommand cmd = new MySqlCommand(
                     "INSERT INTO LC.VISIT_USER (cardnum,user_name,alias,tel,email,description,img_dir,img_filename,active, "
                   +                                  "gubun,create_admin_id,modify_admin_id,craete_date,modify_date) VALUES ('"
                   + arrVar[0] + "','"
                   + arrVar[1] + "','"
                   + arrVar[2] + "','"
                   + arrVar[3] + "','"
                   + arrVar[4] + "','"
                   + arrVar[5] + "','"
                   + arrVar[6] + "','"
                   + arrVar[7] + "','"
                   + arrVar[8] + "','"
                   + arrVar[9] + "','"
                   + arrVar[10] + "','"
                   + arrVar[11] + "','"
                   + SystemTime + "','"
                   + SystemTime + "'); ", conn);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "[ERROR]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "FAIL";
            }
            finally
            {
                ClsDB();
            }

            return "SUCCESS";

        }
    }
}
