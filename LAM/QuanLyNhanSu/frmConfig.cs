using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Data;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.IO;
//using Microsoft.SqlServer.Management.Common;

//using Microsoft.SqlServer.Management.Smo ;
using System.Data.SqlClient;

//using Microsoft.SqlServer.Management.Smo;

namespace QuanLyNhanSu
{
    public partial class frmConfig : Telerik.WinControls.RadForm
    {
        QuanLyNhanSu.Class.readFile c = new QuanLyNhanSu.Class.readFile();
        QuanLyNhanSu.Class.sql sql = new QuanLyNhanSu.Class.sql();

        static public string server = "";
        static public string data = "";

        public SqlConnection con;
        
        public static frmConfig me;
        public frmConfig()
        {
            me = this;
            InitializeComponent();
            try
            {
                SqlConnection sc = new SqlConnection("Data Source =DESKTOP-76NH8MU;Initial Catalog = master;Integrated Security=True;");
                sc.Open();
                SqlCommand scmd = new SqlCommand("select * from sysservers", sc);
                SqlDataReader sdr = scmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        RadComboBoxItem cmbi = new RadComboBoxItem();
                        cmbi.Value = sdr.GetValue(2).ToString().Trim();
                        cmbi.Text = sdr.GetValue(2).ToString().Trim();
                        cmbServer.Items.Add(cmbi);



                    }

                }
                RadComboBoxItem cmbi1 = new RadComboBoxItem();
                cmbi1.Text = "Window Authentication";
                cmbi1.Value = ".";
                cmbServer.Items.Add(cmbi1);

                sc.Close();
            }
            catch
            {
            }
            this.cmbServer.SelectedIndex = 0;
                        
        }
        public void khoitao(string servername, string database, string usernamesa, string passsa)
        {
            string sqlcon = "";
            string sqlcon1 = "";
            if (usernamesa.Trim() != String.Empty && passsa.Trim() != String.Empty)
            {
               sqlcon = "server =" + servername + " ; database = " + database +
                    "; uid = " + usernamesa + "; pwd =" + passsa;
               sqlcon1 = "server =" + servername + " ; database = master" +
                    "; uid = " + usernamesa + "; pwd =" + passsa;
            }
            else
            {
                sqlcon = "Data Source =" + servername + " ; Initial Catalog = " + database +
                   ";Integrated Security=True ";
                sqlcon1 = "Data Source =" + servername + " ; Initial Catalog = master" +
                    ";Integrated Security=True";
            }
            server = servername;
            data = database;
            SqlConnection sc = new SqlConnection(sqlcon);
            SqlConnection sc1 = new SqlConnection(sqlcon);
            SqlConnection sc2 = new SqlConnection(sqlcon1);
            
            FileInfo file = new FileInfo(Application.StartupPath + "\\File\\script1.sql");
            string script = file.OpenText().ReadToEnd();
            
            //Server servers = new Server(new ServerConnection(sc));
            //servers.ConnectionContext.ExecuteNonQuery(script);
            sc.Close();

            
            sc2.Open();
            SqlCommand scmd0u0 = new SqlCommand("KiemTraLogin", sc2);
            SqlParameter ulogu0 = new SqlParameter("@loginname", "u0");
            scmd0u0.CommandType = CommandType.StoredProcedure;
            scmd0u0.Parameters.AddRange(new SqlParameter[] { ulogu0 });
            object o1u0 = scmd0u0.ExecuteScalar();
            sc2.Close();
            if (o1u0 == null)
            {
                sc1.Open();
                SqlCommand scmd2u0 = new SqlCommand("KiemTraUser", sc1);
                SqlParameter uu0 = new SqlParameter("@username", "u0");
                scmd2u0.CommandType = CommandType.StoredProcedure;
                scmd2u0.Parameters.AddRange(new SqlParameter[] { uu0 });
                object ou0 = scmd2u0.ExecuteScalar();
                sc1.Close();
                if (ou0 != null)
                {
                    sc1.Open();
                    SqlCommand scmd3u0 = new SqlCommand("Dropuser", sc1);
                    SqlParameter nameu0 = new SqlParameter("@username", "u0");
                    scmd3u0.CommandType = CommandType.StoredProcedure;
                    scmd3u0.Parameters.AddRange(new SqlParameter[] { nameu0 });
                    scmd3u0.ExecuteNonQuery();
                    sc1.Close();
                }
                sc1.Open();
                SqlCommand scmd1u0 = new SqlCommand("AddLogIn", sc1);
                SqlParameter maloginu0 = new SqlParameter("@name", "u0");
                SqlParameter passloginu0 = new SqlParameter("@pass", "123");
                scmd1u0.CommandType = CommandType.StoredProcedure;
                scmd1u0.Parameters.AddRange(new SqlParameter[] { maloginu0, passloginu0 });
                scmd1u0.ExecuteNonQuery();
                sc1.Close();

                sc1.Open();
                SqlCommand scmd4u0 = new SqlCommand("AddUser", sc1);
                SqlParameter loginnameu0 = new SqlParameter("@loginname", "u0");
                SqlParameter usernameu0 = new SqlParameter("@username", "u0");
                scmd4u0.CommandType = CommandType.StoredProcedure;
                scmd4u0.Parameters.AddRange(new SqlParameter[] { loginnameu0, usernameu0 });
                scmd4u0.ExecuteNonQuery();
                sc1.Close();
            }
            else
            {
                sc1.Open();
                SqlCommand scmd2u0 = new SqlCommand("KiemTraUser", sc1);
                SqlParameter uu0 = new SqlParameter("@username", "u0");
                scmd2u0.CommandType = CommandType.StoredProcedure;
                scmd2u0.Parameters.AddRange(new SqlParameter[] { uu0 });
                object ou0 = scmd2u0.ExecuteScalar();
                sc1.Close();
                if (ou0 != null)
                {
                    sc1.Open();
                    SqlCommand scmd3u0 = new SqlCommand("Dropuser", sc1);
                    SqlParameter nameu0 = new SqlParameter("@username", "u0");
                    scmd3u0.CommandType = CommandType.StoredProcedure;
                    scmd3u0.Parameters.AddRange(new SqlParameter[] { nameu0 });
                    scmd3u0.ExecuteNonQuery();
                    sc1.Close();



                }
                sc1.Open();
                SqlCommand scmd4u0 = new SqlCommand("AddUser", sc1);
                SqlParameter loginnameu0 = new SqlParameter("@loginname", "u0");
                SqlParameter usernameu0 = new SqlParameter("@username", "u0");
                scmd4u0.CommandType = CommandType.StoredProcedure;
                scmd4u0.Parameters.AddRange(new SqlParameter[] { loginnameu0, usernameu0 });
                scmd4u0.ExecuteNonQuery();
                sc1.Close();


            }


            //kiem tra trong bang user va tao
            sc.Open();
            string sqluser = "select * from tbl_user";
            SqlCommand scmd = new SqlCommand(sqluser, sc);
            SqlDataReader sdr = scmd.ExecuteReader();

            while (sdr.Read())
            {
                string ma = sdr.GetString(0).Trim();
                string pass = sdr.GetString(1).Trim();
                string grp = sdr.GetString(2).Trim();

                sc2.Open();
                SqlCommand scmd0 = new SqlCommand("KiemTraLogin", sc2);
                SqlParameter ulog = new SqlParameter("@loginname", ma);
                scmd0.CommandType = CommandType.StoredProcedure;
                scmd0.Parameters.AddRange(new SqlParameter[] { ulog });
                object o1 = scmd0.ExecuteScalar();
                sc2.Close();
                if (o1 == null)
                {
                    sc1.Open();
                    SqlCommand scmd2 = new SqlCommand("KiemTraUser", sc1);
                    SqlParameter u = new SqlParameter("@username", ma);
                    scmd2.CommandType = CommandType.StoredProcedure;
                    scmd2.Parameters.AddRange(new SqlParameter[] { u });
                    object o = scmd2.ExecuteScalar();
                    sc1.Close();
                    if (o != null)
                    {
                        sc1.Open();
                        SqlCommand scmd3 = new SqlCommand("Dropuser", sc1);
                        SqlParameter name = new SqlParameter("@username", ma);
                        scmd3.CommandType = CommandType.StoredProcedure;
                        scmd3.Parameters.AddRange(new SqlParameter[] { name });
                        scmd3.ExecuteNonQuery();
                        sc1.Close();
                    }
                    sc1.Open();
                    SqlCommand scmd1 = new SqlCommand("AddLogIn", sc1);
                    SqlParameter malogin = new SqlParameter("@name", ma);
                    SqlParameter passlogin = new SqlParameter("@pass", pass);
                    scmd1.CommandType = CommandType.StoredProcedure;
                    scmd1.Parameters.AddRange(new SqlParameter[] { malogin, passlogin });
                    scmd1.ExecuteNonQuery();
                    sc1.Close();
                    sc1.Open();
                    SqlCommand scmd4 = new SqlCommand("AddUser", sc1);
                    SqlParameter loginname = new SqlParameter("@loginname", ma);
                    SqlParameter username = new SqlParameter("@username", ma);
                    scmd4.CommandType = CommandType.StoredProcedure;
                    scmd4.Parameters.AddRange(new SqlParameter[] { loginname, username });
                    scmd4.ExecuteNonQuery();
                    sc1.Close();
                }
                else
                {
                    sc1.Open();
                    SqlCommand scmd2 = new SqlCommand("KiemTraUser", sc1);
                    SqlParameter u = new SqlParameter("@username", ma);
                    scmd2.CommandType = CommandType.StoredProcedure;
                    scmd2.Parameters.AddRange(new SqlParameter[] { u });
                    object o = scmd2.ExecuteScalar();
                    sc1.Close();
                    if (o != null)
                    {
                        sc1.Open();
                        SqlCommand scmd3 = new SqlCommand("Dropuser", sc1);
                        SqlParameter name = new SqlParameter("@username", ma);
                        scmd3.CommandType = CommandType.StoredProcedure;
                        scmd3.Parameters.AddRange(new SqlParameter[] { name });
                        scmd3.ExecuteNonQuery();
                        sc1.Close();

                    }

                    sc1.Open();
                    SqlCommand scmd5 = new SqlCommand("Droplogin", sc1);
                    SqlParameter ma_login = new SqlParameter("@loginname", ma);
                    scmd5.CommandType = CommandType.StoredProcedure;
                    scmd5.Parameters.AddRange(new SqlParameter[] { ma_login });
                    scmd5.ExecuteNonQuery();
                    sc1.Close();
                    sc1.Open();

                    SqlCommand scmd1 = new SqlCommand("AddLogIn", sc1);
                    SqlParameter malogin = new SqlParameter("@name", ma);
                    SqlParameter passlogin = new SqlParameter("@pass", pass);
                    scmd1.CommandType = CommandType.StoredProcedure;
                    scmd1.Parameters.AddRange(new SqlParameter[] { malogin, passlogin });
                    scmd1.ExecuteNonQuery();
                    sc1.Close();
                    sc1.Open();

                    SqlCommand scmd4 = new SqlCommand("AddUser", sc1);
                    SqlParameter loginname1 = new SqlParameter("@loginname", ma);
                    SqlParameter username = new SqlParameter("@username", ma);
                    scmd4.CommandType = CommandType.StoredProcedure;
                    scmd4.Parameters.AddRange(new SqlParameter[] { loginname1, username });
                    scmd4.ExecuteNonQuery();
                    sc1.Close();

                }

                if (ma != "administrator")
                {
                    sc1.Open();
                    SqlCommand scmd5 = new SqlCommand("AddRolesMember", sc1);
                    SqlParameter rolename = new SqlParameter("@rolesname", grp);
                    SqlParameter uname = new SqlParameter("@username", ma);
                    scmd5.CommandType = CommandType.StoredProcedure;
                    scmd5.Parameters.AddRange(new SqlParameter[] { rolename, uname });
                    scmd5.ExecuteNonQuery();
                    sc1.Close();
                }
                else
                {
                    sc1.Open();
                    SqlCommand scmd6 = new SqlCommand("AddVip", sc1);
                    SqlParameter useradmin = new SqlParameter("@useradmin", ma);
                    SqlParameter role = new SqlParameter("@rolename", grp);
                    scmd6.CommandType = CommandType.StoredProcedure;
                    scmd6.Parameters.AddRange(new SqlParameter[] { useradmin, role });
                    scmd6.ExecuteNonQuery();
                    sc1.Close();
                }
            }
            sc.Close();

        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            this.cmbDatabase.Items.Clear();
            //if (this.txtUserName.Text != String.Empty && this.txtPassword.Text != String.Empty)
            //{
            
                c.readfile();
                string strDatabase = "";
                if (c.strLine1.Contains("Server:") == true) cmbServer.SelectedValue = c.strLine1.Substring(7);
                if (c.strLine2.Contains("Database:") == true) strDatabase = c.strLine2.Substring(9);
                if (c.strLine3.Contains("Username:") == true) txtUserName.Text = c.strLine3.Substring(9);
                if (c.strLine4.Contains("Password:") == true) txtPassword.Text = c.strLine4.Substring(9);


                if (txtUserName.Text.Trim() != String.Empty && txtPassword.Text.Trim() != String.Empty)
                {

                    try
                    {
                        con = new SqlConnection("Data Source='" + cmbServer.SelectedValue.ToString() + "';Initial Catalog='" + strDatabase + "';User ID='" + txtUserName.Text + "';Password='" + txtPassword.Text + "'");

                        con.Open();

                        SqlCommand scmd = new SqlCommand("select * from tbl_NhanVien", con);
                        scmd.ExecuteNonQuery();
                        khoitao(cmbServer.SelectedValue.ToString(), strDatabase, txtUserName.Text, txtPassword.Text);

                        frmDangNhap obj = new frmDangNhap();
                        obj.ShowDialog();
                        this.Close();
                        con.Close();



                    }
                    catch (Exception ex)
                    {
                        //RadMessageBox.Show("\nĐường dẫn kết nối không đúng ! \nVui lòng xem lại !\n", "Thông báo", MessageBoxButtons.OKCancel, RadMessageIcon.Exclamation);
                    }
                }
                else if (txtUserName.Text.Trim() == String.Empty && txtPassword.Text.Trim() == String.Empty)
                {
                    try
                    {
                        con = new SqlConnection("Data Source='" + cmbServer.SelectedValue.ToString() + "';Initial Catalog='" + strDatabase + "';Integrated Security=True");

                        con.Open();

                        SqlCommand scmd = new SqlCommand("select * from tbl_NhanVien", con);
                        scmd.ExecuteNonQuery();
                        khoitao(cmbServer.SelectedValue.ToString(), strDatabase, "", "");
                        frmDangNhap obj = new frmDangNhap();
                        obj.ShowDialog();
                        this.Close();
                        con.Close();



                    }
                    catch (Exception ex)
                    {
                        //RadMessageBox.Show("\nĐường dẫn kết nối không đúng ! \nVui lòng xem lại !\n", "Thông báo", MessageBoxButtons.OKCancel, RadMessageIcon.Exclamation);
                    }
                }
                else
                {


                    //RadMessageBox.Show("\nĐường dẫn kết nối không đúng ! \nVui lòng xem lại !\n", "Thông báo", MessageBoxButtons.OKCancel, RadMessageIcon.Exclamation);

                }
            
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            if (this.txtUserName.Text != String.Empty && this.txtPassword.Text != String.Empty)
            {
                try
                {
                    khoitao(cmbServer.SelectedValue.ToString(), this.cmbDatabase.Text.Trim(), txtUserName.Text.Trim(), txtPassword.Text.Trim());
                    con = new SqlConnection("Data Source='" + cmbServer.SelectedValue.ToString() + "';Initial Catalog='" + this.cmbDatabase.Text + "';User ID='" + txtUserName.Text + "';Password='" + txtPassword.Text + "'");
                    con.Open();

                    c.writefile(cmbServer.SelectedValue.ToString(), this.cmbDatabase.Text.Trim(), this.txtUserName.Text.Trim(), this.txtPassword.Text.Trim());




                    frmDangNhap obj = new frmDangNhap();
                    obj.ShowDialog();
                    this.Close();
                    con.Close();



                }
                catch (Exception ex)
                {
                    RadMessageBox.Show("\nĐường dẫn kết nối không đúng !\n", "Thông báo", MessageBoxButtons.OKCancel, RadMessageIcon.Exclamation);
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                try
                {
                    khoitao(cmbServer.SelectedValue.ToString(), this.cmbDatabase.Text.Trim(), "", "");
                    con = new SqlConnection("Data Source='" + cmbServer.SelectedValue.ToString() + "';Initial Catalog='" + this.cmbDatabase.Text + "';Integrated Security=True");
                    con.Open();

                    c.writefile(cmbServer.SelectedValue.ToString(), this.cmbDatabase.Text.Trim(), this.txtUserName.Text.Trim(), this.txtPassword.Text.Trim());




                    frmDangNhap obj = new frmDangNhap();
                    obj.ShowDialog();
                    this.Close();
                    con.Close();



                }
                catch (Exception ex)
                {
                    RadMessageBox.Show("\nĐường dẫn kết nối không đúng !\n", "Thông báo", MessageBoxButtons.OKCancel, RadMessageIcon.Exclamation);
                    MessageBox.Show(ex.ToString());
                }
            }
            
        }

        private void cmbDatabase_Click(object sender, EventArgs e)
        {
            this.cmbDatabase.Items.Clear();
            if (this.txtUserName.Text != String.Empty && this.txtPassword.Text != String.Empty)
            {
                try
                {
                    con = new SqlConnection("Data Source='" + cmbServer.SelectedValue.ToString() + "';Initial Catalog=master;User ID='" + txtUserName.Text + "';Password='" + txtPassword.Text + "'");
                    sql.LoadDataToCombobox(this.cmbDatabase, "select * from sys.databases", 0, con);

                }
                catch (Exception ex)
                {
                    RadMessageBox.Show("\nĐường dẫn kết nối không đúng !\n", "Thông báo", MessageBoxButtons.OKCancel, RadMessageIcon.Exclamation);
                }
            }
            else if (this.txtUserName.Text == String.Empty && this.txtPassword.Text == String.Empty)
            {
                try
                {
                    con = new SqlConnection("Data Source='" + cmbServer.SelectedValue.ToString() + "';Initial Catalog=master;Integrated Security=True");
                    sql.LoadDataToCombobox(this.cmbDatabase, "select * from sys.databases", 0, con);

                }
                catch (Exception ex)
                {
                    RadMessageBox.Show("\nĐường dẫn kết nối không đúng !\n", "Thông báo", MessageBoxButtons.OKCancel, RadMessageIcon.Exclamation);
                }
            }
            else
            {
                RadMessageBox.Show("\nĐường dẫn kết nối không đúng !\n", "Thông báo", MessageBoxButtons.OKCancel, RadMessageIcon.Exclamation);
            }
            
        }

        private void cmbServer_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
            if(this.cmbServer.SelectedItem!=null)
            {
                if (this.cmbServer.SelectedIndex == 1)
                {
                    this.txtUserName.Enabled = false;
                    this.txtPassword.Enabled = false;
                    this.txtUserName.Text = "";
                    this.txtPassword.Text = "";
                }
                else
                {
                    this.txtUserName.Enabled = true;
                    txtUserName.Text="sa";
                    this.txtPassword.Enabled = true;
                    txtPassword.Focus();
                }
            }
           
        }

        

       
        
    }
}
