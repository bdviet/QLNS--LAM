using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace QuanLyNhanSu.Class
{
      
    class clsQuanHeGD
    {
        public QuanLyNhanSu.Class.sql sql = new QuanLyNhanSu.Class.sql();
        public SqlConnection sc = frmMain.me.sql.connectSQL();
        public SqlConnection sc1 = frmMain.me.sql.connectSQL();
        public SqlDataAdapter sda = new SqlDataAdapter();
        public SqlDataAdapter sda1 = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        public DataSet ds1 = new DataSet();
        public DataSet ds2 = new DataSet();
        public void laydl(string ma)
        {
            ds.Clear();
            //câu lệnh select
            //string sel_ = "select MaNV,Ho,Ten from tbl_nhanvien NV inner join tbl_QuanHeGiaDinh QH on " +
            //"NV.MaNV = QH.M inner join tbl_DMTonGiao TG on N.MaTG =TG.MaTG inner join tbl_PhongBan PB on " +
            //"N.MaPhong = PB.MaPhong inner join tbl_DanhMucTo T on N.MaTo = T.MaTo inner join tbl_DMChucVu CV on" +
            //" N.MaChucVu = CV.MaChucVu ";

            string sel_ = "select NV.Ho as 'HoNV',NV.Ten as 'TenNV',QH.* from tbl_NhanVien as NV,tbl_QuanHeGiaDinh as QH where QH.MaNV='" + ma + "' and NV.MaNV = '"+ma+"'";
            sc.Open();
            SqlCommand sel = new SqlCommand(sel_, sc);
            sda.SelectCommand = sel;
            sda.Fill(ds, "quanhe");
            sc.Close();
        }
        public void laydl_(int MaQH,string MaNV)
        {
            ds1.Clear();
            //câu lệnh select
            //string sel_ = "select MaNV,Ho,Ten from tbl_nhanvien NV inner join tbl_QuanHeGiaDinh QH on " +
            //"NV.MaNV = QH.M inner join tbl_DMTonGiao TG on N.MaTG =TG.MaTG inner join tbl_PhongBan PB on " +
            //"N.MaPhong = PB.MaPhong inner join tbl_DanhMucTo T on N.MaTo = T.MaTo inner join tbl_DMChucVu CV on" +
            //" N.MaChucVu = CV.MaChucVu ";

            string sel = "select NV.Ho as 'HoNV',NV.Ten as 'TenNV',QH.* from tbl_NhanVien as NV,tbl_QuanHeGiaDinh as QH where QH.MaQH='" + MaQH + "' and NV.MaNV='"+MaNV+"'" ;
            
                sc1.Open();
            
            
            SqlCommand select = new SqlCommand(sel, sc1);
            sda1.SelectCommand = select;
            sda1.Fill(ds1, "quanhe");
            sc1.Close();
        }
        public void them(string MaNV_1, string Ho_2, string Ten_3, string GioiTinh_4, string LoaiQuanHe_5, DateTime NgaySinh_6, string HoKhauTT_7, string ChoOHienTai_8, string DienThoai_9, string NgheNghiep_10, string NoiCongTac_11, string ConSong_12, string NhanVienCongTy_13, string GhiChu_14)
        {
            sql.ExecuteNonQuery("insert_tbl_QuanHeGiaDinh", CommandType.StoredProcedure,
                "@MaNV_1", MaNV_1,
                "@Ho_2", Ho_2,
                "@Ten_3", Ten_3,
                "@GioiTinh_4", GioiTinh_4,
                "@LoaiQuanHe_5", LoaiQuanHe_5,
                "@NgaySinh_6", NgaySinh_6,
                "@HoKhauTT_7", HoKhauTT_7,
                "@ChoOHienTai_8", ChoOHienTai_8,
                "@DienThoai_9", DienThoai_9,
                "@NgheNghiep_10", NgheNghiep_10,
                "@NoiCongTac_11", NoiCongTac_11,
                "@ConSong_12", ConSong_12,
                "@NhanVienCongTy_13", NhanVienCongTy_13,
                "@GhiChu_14", GhiChu_14
                );

        }
        public void xoa(int MaQH)
        {

            sql.ExecuteNonQuery("delete_tbl_QuanHeGiaDinh", CommandType.StoredProcedure, "@MaQH", MaQH);

        }
        public void sua(int MaQH_0, string MaNV_1, string Ho_2, string Ten_3, string GioiTinh_4, string LoaiQuanHe_5, DateTime NgaySinh_6, string HoKhauTT_7, string ChoOHienTai_8, string DienThoai_9, string NgheNghiep_10, string NoiCongTac_11, string ConSong_12, string NhanVienCongTy_13, string GhiChu_14)
        {
            sql.ExecuteNonQuery("update_tbl_QuanHeGiaDinh", CommandType.StoredProcedure,
                "@MaQH_0",MaQH_0,
                "@MaNV_1", MaNV_1,
                "@Ho_2", Ho_2,
                "@Ten_3", Ten_3,
                "@GioiTinh_4", GioiTinh_4,
                "@LoaiQuanHe_5", LoaiQuanHe_5,
                "@NgaySinh_6", NgaySinh_6,
                "@HoKhauTT_7", HoKhauTT_7,
                "@ChoOHienTai_8", ChoOHienTai_8,
                "@DienThoai_9", DienThoai_9,
                "@NgheNghiep_10", NgheNghiep_10,
                "@NoiCongTac_11", NoiCongTac_11,
                "@ConSong_12", ConSong_12,
                "@NhanVienCongTy_13", NhanVienCongTy_13,
                "@GhiChu_14", GhiChu_14
                );

        }
    }
}
