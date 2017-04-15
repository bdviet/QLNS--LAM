using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLyNhanSu.Class
{
    class clsnhomnguoidung
    {
        SqlConnection sc = frmMain.me.sql.connectSQL();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public DataTable taocombo()
        {
            ds.Clear();
            sc.Open();
            string sql1 = "Select nhom from tbl_nhomnguoidung";
            SqlCommand scmd = new SqlCommand(sql1, sc);
            sda.SelectCommand = scmd;
            sda.Fill(ds, "Group");
            sc.Close();
            return ds.Tables["Group"];
        }
    }
}
