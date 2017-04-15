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
    class clsdmchuyenmon : clsdm
    {
        public DataTable taocombocm()
        {
            clsdmchuyenmon c = new clsdmchuyenmon();
            c.sc.Open();
            string sql = "Select * from tbl_DMChuyenMon";
            SqlCommand scmd = new SqlCommand(sql, c.sc);
            c.sda.SelectCommand = scmd;
            c.sda.Fill(c.ds, "DMChuyenMon");
            c.sc.Close();
            return c.ds.Tables["DMChuyenMon"];
        }

    }
}
