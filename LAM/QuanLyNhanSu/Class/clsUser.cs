using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace QuanLyNhanSu.Class
{
    class clsUser
    {
        public SqlConnection sc = frmMain.me.sql.connectSQL();
        public SqlDataAdapter sda = new SqlDataAdapter();
        public DataSet ds = new DataSet();
       
        public DataSet taocombo()
        {
            ds.Clear();
            sc.Open();
            string sql1 = "Select * from tbl_User where id<>'administrator'";
            SqlCommand scmd = new SqlCommand(sql1,sc);
            sda.SelectCommand = scmd;
            sda.Fill(ds, "User");
            sc.Close();
            return ds;
        }

        public bool KiemTraHopLe(string user, string mk)
        {
            string sql = "Select * from tbl_User where id='" + user +
                            "' and pass='" + mk + "'";
            sc.Open();
            SqlCommand scmd = new SqlCommand(sql, sc);
            object o= scmd.ExecuteScalar();
            sc.Close();
            if (o == null) return false;
            else return true;

        }

        public void them(string uname, string pass, string nhom)
        {
            sql.ExecuteNonQuery("insert_tbl_USER", CommandType.StoredProcedure,
                                  "@ID_1", uname,
                                  "@Pass_2", pass,
                                  "@nhom_3", nhom);
        }

        public void sua(string uname,string pass,string nhom)
        {
            sql.ExecuteNonQuery("update_tbl_USER", CommandType.StoredProcedure,
                                  "@ID_1", uname,
                                  "@Pass_2", pass,
                                  "@nhom_3", nhom);
        }

        public void xoa(string uname)
        {
            sql.ExecuteNonQuery("delete_tbl_USER", CommandType.StoredProcedure,
                                 "@ID_1", uname);
        }
    }
}
