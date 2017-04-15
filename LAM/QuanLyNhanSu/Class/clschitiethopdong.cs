using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
namespace QuanLyNhanSu.Class
{
    class clschitiethopdong
    {
        public QuanLyNhanSu.Class.sql sql = new QuanLyNhanSu.Class.sql();
        public SqlConnection sc = frmMain.me.sql.connectSQL();
        public SqlDataAdapter sda = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        public DataSet ds1 = new DataSet();
        //lấy dữ liệu theo mã nhân viên
        public DataSet laydl(string manv)
        {
            ds.Clear();
            string sel_ = " select a.sohd,a.manv,a.maloaihd,b.tenloaihd,a.ngayky,a.ngayketthuc,a.luongcoban"
                        + " from tbl_chitiethopdong a inner join tbl_loaihd b on a.maloaihd=b.maloaihd where a.manv ='"+manv+"'";
            sc.Open();
            SqlCommand sel = new SqlCommand(sel_, sc);
            sda.SelectCommand = sel;
            sda.Fill(ds, "NV_HopDong");
            sc.Close();
            return ds;
        }
        //thêm dữ liệu trong tbl_Chitiethopdong
        public void them(string sohd_1, int maloaihd_2, string manv_3, DateTime ngayky_4, DateTime ngaykt_5, int luongcb_6)
        {
            sql.ExecuteNonQuery("Insert_tbl_ChitietHopDong", CommandType.StoredProcedure, "@SoHD_1", sohd_1,
                "@MaLoaiHD_2", maloaihd_2,
                "@MaNV_3", manv_3,
                "@NgayKy_4", ngayky_4,
                "@NgayKetThuc_5", ngaykt_5,
                "@LuongCoBan_6", luongcb_6);
          
        }
        //xóa dữ liệu trong tbl_ChiTietHopDong
        public void xoa(string sohd_1)
        {

            sql.ExecuteNonQuery("Delete_tbl_ChiTietHopDong", CommandType.StoredProcedure, "@SoHD_1", sohd_1);
           
        }
        //sửa dữ liệu trong tbl_ChiTietHopDong
        public void sua(string sohd_1, int maloaihd_2, string manv_3, DateTime ngayky_4, DateTime ngaykt_5, int luongcb_6)
        {

            sql.ExecuteNonQuery("Update_tbl_ChitietHopDong", CommandType.StoredProcedure, "@SoHD_1", sohd_1,
                "@MaLoaiHD_2", maloaihd_2,
                "@MaNV_3", manv_3,
                "@NgayKy_4", ngayky_4,
                "@NgayKetThuc_5", ngaykt_5,
                "@LuongCoBan_6", luongcb_6);
        }
        //kiểm tra xem nhân viên đó có hợp đồng hay không
        public bool kiemtra(string ma)
        {
            sc.Open();
            string sel_ = "select manv from tbl_ChiTietHopDong where manv ='" + ma + "'";
            SqlCommand sel = new SqlCommand(sel_, sc);
            object o = sel.ExecuteScalar();
            sc.Close();
            if (o == null)
                return false;
            else
                return true; 
        }
        //lấy dữ liệu theo mã hợp đồng
        public DataTable laytthd(string ma)
        {
            ds.Clear();
            sc.Open();
            string sel_ = " select * from tbl_ChiTietHopDong where SoHD = '" + ma + "'";
            SqlCommand sel = new SqlCommand(sel_, sc);
            sda.SelectCommand = sel;
            sda.Fill(ds, "HopDong");
            sc.Close();
            return ds.Tables["HopDong"];
        }
        //lấy ra những nv có hợp đồng đã hết hạn
        public DataTable layNV_HDhethan(string chuoidk)
        {
            ds1.Clear();
            sc.Open();
            sql.ExecuteNonQuery("kiemtrahopdong", CommandType.StoredProcedure);
            string sel = "Select * from view_KTHDhethan where "+chuoidk;
            SqlCommand scmd = new SqlCommand(sel, sc);
            sda.SelectCommand = scmd;
            sda.Fill(ds1,"NV_HDhethan");
            sc.Close();
            return ds1.Tables["NV_HDhethan"];
        }
        //Lấy mã hợp đồng cuối cùng
        public string laysohd()
        {
            string sel = "select top 1 percent sohd from tbl_chitiethopdong order by sohd desc";
            sc.Open();
            SqlCommand sel1 = new SqlCommand(sel, sc);
            object o = sel1.ExecuteScalar();
            sc.Close();
            return o.ToString();
        }
    }
}
