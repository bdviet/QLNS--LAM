using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace QuanLyNhanSu.Class
{
    class clschitietngoaingu
    {
        public SqlConnection sc = frmMain.me.sql.connectSQL();
        public SqlDataAdapter sda = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        //lấy dữ liệu theo mã nhân viên
        public DataSet laydl(string manv)
        {
            ds.Clear();
            string sel_ = "select a.id,a.mangoaingu,a.trinhdo,a.noicap,a.ngaycap "
            + "from tbl_Chitietngoaingu a where a.manv='"+manv+"'";
            sc.Open();
            SqlCommand sel = new SqlCommand(sel_, sc);
            sda.SelectCommand = sel;
            sda.Fill(ds, "NV_Ngoaingu");
            sc.Close();
            return ds;
        }
        //
        public void CapNhatNN(string ma)
        {
            //tao ket noi
            sc.Open();
            string sel = "select id,manv,mangoaingu,trinhdo,noicap,ngaycap "
            + "from tbl_Chitietngoaingu  where manv = '" + ma + "'";
            SqlCommand sel_ = new SqlCommand(sel, sc);
            sda.SelectCommand = sel_;
            //insert
            string ins = "Insert tbl_chitietngoaingu values(@id,'" + ma + "',@mangoaingu,@trinhdo,@noicap,@ngaycap)";
            SqlCommand scmdins = new SqlCommand(ins, sc);
            SqlParameter id = new SqlParameter("@id", SqlDbType.NVarChar, 8, "id");            
            SqlParameter mangoaingu = new SqlParameter("@mangoaingu", SqlDbType.Int, 9, "mangoaingu");
            SqlParameter trinhdo = new SqlParameter("@trinhdo", SqlDbType.NVarChar, 20, "trinhdo");
            SqlParameter ngaycap = new SqlParameter("@ngaycap", SqlDbType.DateTime, 8, "ngaycap");
            SqlParameter noicap = new SqlParameter("@noicap", SqlDbType.NVarChar, 50, "noicap");
            scmdins.Parameters.AddRange(new SqlParameter[] { id, mangoaingu, trinhdo, ngaycap, noicap });
            sda.InsertCommand = scmdins;
            //update
            string upd = "Update tbl_chitietngoaingu set mangoaingu=@mangoaingu1," +
                        "trinhdo=@trinhdo1,noicap=@noicap1,ngaycap=@ngaycap1 where id=@id1";
            SqlCommand scmdupd = new SqlCommand(upd, sc);
            SqlParameter id1 = new SqlParameter("@id1", SqlDbType.NVarChar, 8, "id");            
            SqlParameter mangoaingu1 = new SqlParameter("@mangoaingu1", SqlDbType.Int, 9, "mangoaingu");
            SqlParameter trinhdo1 = new SqlParameter("@trinhdo1", SqlDbType.NVarChar, 20, "trinhdo");
            SqlParameter ngaycap1 = new SqlParameter("@ngaycap1", SqlDbType.DateTime, 8, "ngaycap");
            SqlParameter noicap1 = new SqlParameter("@noicap1", SqlDbType.NVarChar, 50, "noicap");
            id1.SourceVersion = DataRowVersion.Original;
            scmdupd.Parameters.AddRange(new SqlParameter[] { mangoaingu1, trinhdo1, ngaycap1, noicap1, id1 });
            sda.UpdateCommand = scmdupd;
            //delete
            string del = "Delete tbl_chitietngoaingu where id=@id2";
            SqlCommand scmddel = new SqlCommand(del, sc);
            SqlParameter id2 = new SqlParameter("@id2", SqlDbType.NVarChar, 8, "id");
            scmddel.Parameters.AddRange(new SqlParameter[] { id2 });
            sda.DeleteCommand = scmddel;
            ds.Clear();
            sda.Fill(ds, "NV_ngoaingu1");
            sc.Close();
        }

    }
}
