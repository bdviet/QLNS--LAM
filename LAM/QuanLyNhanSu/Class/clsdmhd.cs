using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
namespace QuanLyNhanSu.Class
{
    class clsdmhd:clsdm
    {
        public DataTable taocombohd()
        {
            clsdmhd c = new clsdmhd();
            c.sc.Open();
            string sql = "Select * from tbl_LoaiHD";
            SqlCommand scmd = new SqlCommand(sql, c.sc);
            c.sda.SelectCommand = scmd;
            c.sda.Fill(c.ds, "LoaiHD");
            c.sc.Close();
            return c.ds.Tables["LoaiHD"];
        }
    }
}
