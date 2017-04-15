using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace QuanLyNhanSu.Class
{
    class clsUser_Right
    {
        public SqlConnection sc = frmMain.me.sql.connectSQL();
        public SqlDataAdapter sda = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        public DataSet  laydl()
        {
            sc.Open();
            string sql = "Select F.icon,F.tenform,U.rights from tbl_user_form U inner join " +
                        "tbl_DMform F on U.idform=F.id";
            SqlCommand scmd = new SqlCommand(sql, sc);
            sda.SelectCommand = scmd;
            ds.Clear();
            sda.Fill(ds,"User_Right");
            sc.Close();
            return ds;
                        
        }
        public DataSet laydl(string ma)
        {
            sc.Open();
            string sql = "Select U.idform,F.tenform,U.rights from tbl_user_form U inner join " +
                        "tbl_DMform F on U.idform=F.id where U.username='"+ma+"'";
            SqlCommand scmd = new SqlCommand(sql,sc);
            sda.SelectCommand = scmd;
            ds.Clear();
            sda.Fill(ds,"User_Right");
            sc.Close();
            return ds;

        }
        
        
    }
}
