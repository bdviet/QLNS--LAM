using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace QuanLyNhanSu.Class
{
    class clschitietchuyenmon
    {
        //khai báo và khởi tạo biến
        public SqlConnection sc = frmMain.me.sql.connectSQL();
        public SqlDataAdapter sda = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        //lấy dữ liệu theo mã nhân viên
        public DataSet laydl(string manv)
        {
            ds.Clear();
            string sel_ = "select * "
            + "from tbl_Chitietchuyenmon a where a.MaNV ='" + manv + "'";
            sc.Open();
            SqlCommand sel = new SqlCommand(sel_, sc);
            sda.SelectCommand = sel;
            sda.Fill(ds, "NV_ChuyenMon");
            sc.Close();
            return ds;
        }
        //phương thức thêm xóa và cập nhật
        public void CapNhatCM(string ma)
        {
            //tao ket noi
            sc.Open();
            string sel = "select * "
            + "from tbl_ChitietChuyenMon  where manv = '" + ma + "'";
            SqlCommand sel_ = new SqlCommand(sel, sc);
            sda.SelectCommand = sel_;
            //insert
            string ins = "Insert tbl_chitietChuyenMon values(@id,'" + ma + "',@maChuyenMon,@MaTrinhDo,@ngaycap,@truong)";
            SqlCommand scmdins = new SqlCommand(ins, sc);
            SqlParameter id = new SqlParameter("@id", SqlDbType.NVarChar , 8, "id");
            SqlParameter macm = new SqlParameter("@machuyenmon", SqlDbType.Int, 9, "machuyenmon");
            SqlParameter matrinhdo = new SqlParameter("@matrinhdo", SqlDbType.Int, 9, "matrinhdo");
            SqlParameter ngaycap = new SqlParameter("@ngaycap", SqlDbType.DateTime, 8, "ngaycap");
            SqlParameter noicap = new SqlParameter("@truong", SqlDbType.NVarChar, 50, "truong");
            scmdins.Parameters.AddRange(new SqlParameter[] { id, macm, matrinhdo, ngaycap, noicap });
            sda.InsertCommand = scmdins;
            //update
            string upd = "Update tbl_chitietchuyenmon set machuyenmon=@machuyenmon1," +
                        "matrinhdo=@matrinhdo1,ngaycap=@ngaycap1,truong=@truong1 where id=@id1";
            SqlCommand scmdupd = new SqlCommand(upd, sc);
            SqlParameter id1 = new SqlParameter("@id1", SqlDbType.NVarChar, 8, "id");
            SqlParameter macm1 = new SqlParameter("@machuyenmon1", SqlDbType.Int, 9, "machuyenmon");
            SqlParameter matrinhdo1 = new SqlParameter("@matrinhdo1", SqlDbType.Int , 9, "matrinhdo");
            SqlParameter ngaycap1 = new SqlParameter("@ngaycap1", SqlDbType.DateTime, 8, "ngaycap");
            SqlParameter noicap1 = new SqlParameter("@truong1", SqlDbType.NVarChar, 50, "truong");
            id1.SourceVersion = DataRowVersion.Original;
            scmdupd.Parameters.AddRange(new SqlParameter[] { macm1, matrinhdo1, noicap1, ngaycap1, id1 });
            sda.UpdateCommand = scmdupd;
            //delete
            string del = "Delete tbl_chitietchuyenmon where id=@id2";
            SqlCommand scmddel = new SqlCommand(del, sc);
            SqlParameter id2 = new SqlParameter("@id2", SqlDbType.NVarChar, 8, "id");
            scmddel.Parameters.AddRange(new SqlParameter[] { id2 });
            sda.DeleteCommand = scmddel;
            ds.Clear();
            sda.Fill(ds, "NV_ChuyenMon1");
            sc.Close();
        }
    }
}
        
