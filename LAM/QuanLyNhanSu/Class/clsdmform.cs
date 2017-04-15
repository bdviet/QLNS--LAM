using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows;
using System.Data.SqlClient;
using Telerik.Data;
using Telerik.WinControls;
using QuanLyNhanSu.Class;

namespace QuanLyNhanSu.Class
{
    class clsdmform
    {
        SqlConnection sc = frmMain.me.sql.connectSQL();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public DataSet laydl()
        {
            string sqlSel = "Select * from tbl_DMForm ";
            sc.Open();
            SqlCommand cmdsel = new SqlCommand(sqlSel, sc);
            sda.SelectCommand = cmdsel;
            sda.Fill(ds, "DMform");
            sc.Close();
            return ds;
        }
        public void insert(string user, string idform, int b)
        {
            string ins = "insert tbl_user_form values ('" + user + "','"
                                               + idform + "'," + b + ")";
            sc.Open();
            SqlCommand scmd = new SqlCommand(ins, sc);
            scmd.ExecuteNonQuery();
            sc.Close();

        }
    }
}
