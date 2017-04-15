using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
//using System.Data.SqlClient;
using Telerik.WinControls;
using System.Text.RegularExpressions;
using Telerik.WinControls.UI;

namespace QuanLyNhanSu.Class
{
    public class sql
    {
        private string user = "";

        private string scon = "";

        public SqlConnection con;
        DataSet ds = new DataSet();
        SqlDataAdapter sda = new SqlDataAdapter();
        QuanLyNhanSu.Class.readFile c = new readFile();

        public sql(string servername, string data, string u, string p)
        {
            scon = "server=" + servername.Trim() + ";database=" + data.Trim() +
                ";uid=" + u.Trim() + ";pwd=" + p.Trim();
            user = u.Trim();
        }
        public sql(sql sql)
        {
            user = sql.user;
            scon = sql.scon;

        }
        public sql()
        {
            //c.readfile();
            //string strServerName = "";
            //string strDatabase = "";
            //string strUsername = "";

            //string strPassword = "";

            //if (c.strLine1.Contains("Server:") == true) strServerName = c.strLine1.Substring(7);
            //if (c.strLine2.Contains("Database:") == true) strDatabase = c.strLine2.Substring(9);
            //if (c.strLine3.Contains("Username:") == true) strUsername = c.strLine3.Substring(9);
            //if (c.strLine4.Contains("Password:") == true) strPassword = c.strLine4.Substring(9);
            //try
            //{
            //    con = new SqlConnection("Data Source='" + strServerName + "';Initial Catalog='" + strDatabase + "';uid='" + strUsername + "';pwd='" + strPassword + "';Integrated Security=True;");
            //    //con = new SqlConnection("Data Source = THANHDAT ;Initial Catalog = MyProjectIII ; uid= sa ;pwd= 123456 ;Integrated Security=True;");
                
            //}
            //catch
            //{
            //    MessageBox.Show("Không thể kết nối đến Database !", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Application.Exit();
                
            //}

        }
        public string GetUser()
        {
            return user;
        }

        public SqlConnection connectSQL()
        {
            c.readfile();
            string strServerName = "";
            string strDatabase = "";
            string strUsername = "";

            string strPassword = "";

            if (c.strLine1.Contains("Server:") == true) strServerName = c.strLine1.Substring(7);
            if (c.strLine2.Contains("Database:") == true) strDatabase = c.strLine2.Substring(9);
            if (c.strLine3.Contains("Username:") == true) strUsername = c.strLine3.Substring(9);
            if (c.strLine4.Contains("Password:") == true) strPassword = c.strLine4.Substring(9);
            if (strUsername.Trim() != String.Empty && strPassword.Trim() != String.Empty)
            {
                try
                {
                    con = new SqlConnection("Data Source='" + strServerName + "';Initial Catalog='" + strDatabase + "';uid='" + strUsername + "';pwd='" + strPassword + "';Integrated Security=True;");
                    //con = new SqlConnection("Data Source = THANHDAT ;Initial Catalog = MyProjectIII ; uid= sa ;pwd= 123456 ;Integrated Security=True;");
                    return con;
                }
                catch
                {
                    RadMessageBox.Show("\nKhông thể kết nối đến Database !\n", "Thông báo", MessageBoxButtons.OK, RadMessageIcon.Error);
                    Application.Exit();
                    return null;
                }
            }
            else
            {
                try
                {
                    con = new SqlConnection("Data Source='" + strServerName + "';Initial Catalog='" + strDatabase + "';Integrated Security=True;");
                    //con = new SqlConnection("Data Source = THANHDAT ;Initial Catalog = MyProjectIII ; uid= sa ;pwd= 123456 ;Integrated Security=True;");
                    return con;
                }
                catch
                {
                    RadMessageBox.Show("\nKhông thể kết nối đến Database !\n", "Thông báo", MessageBoxButtons.OK, RadMessageIcon.Error);
                    Application.Exit();
                    return null;
                }
            }


        }
        public SqlConnection getCon()
        {
            return new SqlConnection(scon);
        }
        public DataSet LoadDataToCombobox(ComboBox cmb, string sql,string tbl, SqlConnection con)
        {
            //con.Open();

            SqlCommand scmd = new SqlCommand(sql,con);
            sda.SelectCommand = scmd;
            sda.Fill(ds, tbl);
 
            
            //con.Close();
            return ds;
        }
        public void LoadDataToCombobox(RadComboBox cmb, string sql, int col, SqlConnection con)
        {
            con.Open();
            SqlDataReader sqlDataReader = null;
            SqlCommand scmd = new SqlCommand(sql, con);
            sqlDataReader = scmd.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    RadComboBoxItem cmbi = new RadComboBoxItem();
                    cmbi.Text = sqlDataReader.GetValue(col).ToString();
                    cmb.Items.Add(cmbi);
                }
            }
            else
            {

            }
            con.Close();
        }
        public static void ExecuteNonQuery(
            string sql1,
            CommandType commandType,
            params object[] pars)
        {
            //sql c = new sql();
            sql con = new sql(frmMain.me.sql);
            SqlConnection con1 = con.getCon();
            con1.Open();

            SqlCommand com = new SqlCommand(sql1, con1);
            com.CommandType = commandType;

            for (int i = 0; i < pars.Length; i += 2)
            {
                SqlParameter par = new SqlParameter(pars[i].ToString(),
                    pars[i + 1]);
                com.Parameters.Add(par);
            }
            try
            {
                com.ExecuteNonQuery();
                
            }
            catch (SqlException e)
            {
                if (e.Number == 2627)
                {
                    RadMessageBox.Show("\nMã này đã tồn tại !\n", "Thông Báo",MessageBoxButtons.OK,RadMessageIcon.Exclamation);
                    
                }
                else if (e.Number == 229)
                {

                    RadMessageBox.Show("\nBạn không có quyền chỉnh sửa thông tin này !\n", "Thông Báo",MessageBoxButtons.OK,RadMessageIcon.Exclamation);

                }
                else
                {
                    RadMessageBox.Show("" + e.Number + " " + e.Errors + e.Message);
                }

            }
            con1.Close();
        }
        //hàm trả về ngày từ một chuỗi nhập vào textbox, flag =0 :laydl len, flag=1 :them
        static public DateTime TraVeNgay(string s, int flag)
        {
            try
            {
                int ngay = 0, thang = 0, nam = 0;
                string m = s;
                nam = Int32.Parse(s.Substring(s.Length - 4, 4));
                s = s.Substring(0, s.Length - 4);
                for (int i = s.Length; i > 0; i--)
                    if (s.Contains("/") == true) s = s.Substring(0, s.Length - 1);
                thang = Int32.Parse(s);
                ngay = Int32.Parse(m.Substring(s.Length + 1,
                    m.Length - 6 - s.Length));
                return flag == 0 ? new DateTime(nam, thang, ngay) : new DateTime(nam, ngay, thang);
            }
            catch(Exception ex)
            {
                return DateTime.Now;
            }
          
        }

        //ham trả ngày về chuỗi
        public string NgayToString(string n)
        {
            if (n == "") return "";
            n = n.Substring(0, 10);
            for (int i = 0; i < n.Length; i++)
            {
                if (n.Contains(" ") == true)
                    n = n.Substring(0, 10 - i - 1);
                else break;
            }
            DateTime d = TraVeNgay(n, 0);
            string ng = "", th = "", na = "";
            ng = d.Day.ToString();
            th = d.Month.ToString();
            na = d.Year.ToString();
            return ng + "/" + th + "/" + na;
        }

        //ham kiem tra ngay
        public bool KiemTraNgay(string s)
        {
            try
            {
                string snam = s.Substring(s.LastIndexOf("/") + 1,
                    s.Length - s.LastIndexOf("/") - 1);
                string sngay = s.Substring(0, s.IndexOf("/"));
                string sthang = s.Substring(s.IndexOf("/") + 1,
                    s.Length - sngay.Length - snam.Length - 2);
                int nam = int.Parse(snam);
                int thang = int.Parse(sthang);
                int ngay = int.Parse(sngay);

                if ((nam < 1900) || (nam > 9999))
                    return false;
                if ((thang > 12) || (thang < 1))
                    return false;
                else
                {
                    switch (thang)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            if (ngay > 31)
                                return false;
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            if (ngay > 30)
                                return false;
                            break;
                        default:
                            if ((nam % 4) == 0 && (nam % 100) != 0 || (nam % 1000) == 0)
                            {
                                if (ngay > 29)
                                    return false;
                            }
                            else
                                if (ngay > 28)
                                    return false;
                            break;
                    }
                }
            }
            catch
            {
                RadMessageBox.Show("Bạn phải nhập đúng định dạng ngày !", "Thông báo",MessageBoxButtons.OK,RadMessageIcon.Exclamation);

            }

            return true;
        }
        public bool IsEmail(string inputEmail)
        {
            
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }



    }
}
