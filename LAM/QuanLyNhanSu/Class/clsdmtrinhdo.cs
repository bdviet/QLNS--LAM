using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Data;


namespace QuanLyNhanSu.Class
{
    class clsdmtrinhdo : clsdm
    {
        public DataTable taocombotd()
        {
            clsdmtrinhdo c = new clsdmtrinhdo();
            c.sc.Open();
            string sql = "Select * from tbl_DMTrinhDo";
            SqlCommand scmd = new SqlCommand(sql, c.sc);
            c.sda.SelectCommand = scmd;
            c.sda.Fill(c.ds, "DMTrinhDo");
            c.sc.Close();
            return c.ds.Tables["DMTrinhDo"];
        }

    }
}