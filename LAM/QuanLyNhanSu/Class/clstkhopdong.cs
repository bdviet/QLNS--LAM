using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
namespace QuanLyNhanSu.Class
{
    class clstkhopdong
    {
        public SqlConnection sc = frmMain.me.sql.getCon();
        public SqlDataAdapter sda = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        public DataSet laydl()
        {
            ds.Clear();
            string sel_ = "select * from V_NV_HopDong";
            sc.Open();
            SqlCommand sel = new SqlCommand(sel_, sc);
            sda.SelectCommand = sel;
            sda.Fill(ds, "TC_HD");
            sc.Close();
            return ds;
        }
        public DataSet laydl(string chuoidk)
        {
            ds.Clear();
            string sel_ = "select * from V_NV_HopDong where " + chuoidk;
            sc.Open();
            SqlCommand sel = new SqlCommand(sel_, sc);
            sda.SelectCommand = sel;
            sda.Fill(ds, "TC_HD");
            sc.Close();
            return ds;
        }
    }
}
