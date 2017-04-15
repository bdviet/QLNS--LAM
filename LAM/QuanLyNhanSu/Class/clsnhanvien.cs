using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace QuanLyNhanSu.Class
{
    class clsnhanvien
    {
        public QuanLyNhanSu.Class.sql sql = new QuanLyNhanSu.Class.sql();
        public SqlConnection sc = frmMain.me.sql.connectSQL();
        public SqlDataAdapter sda = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        public DataSet ds1 = new DataSet();
        public DataSet ds2 = new DataSet();
        //lấy dữ liệu 
        public void laydl()
        {
            ds.Clear();
            //câu lệnh select
            string sel_ = "select * from tbl_nhanvien N inner join tbl_DMDanToc DT on "+
            "N.MaDT = DT.MADT inner join tbl_DMTonGiao TG on N.MaTG =TG.MaTG inner join tbl_PhongBan PB on "+
            "N.MaPhong = PB.MaPhong inner join tbl_DanhMucTo T on N.MaTo = T.MaTo inner join tbl_DMChucVu CV on"+
            " N.MaChucVu = CV.MaChucVu ";
            sc.Open();
            SqlCommand sel = new SqlCommand(sel_, sc);
            sda.SelectCommand = sel;
            sda.Fill(ds, "nhanvien");
            sc.Close();
        }
        //lấy dữ liệu theo mã nhân viên
        public void laydl(string ma)
        {
            ds.Clear();
            //câu lệnh select
            string sel_ = "select * from tbl_nhanvien N left join tbl_DMDanToc DT on " +
            "N.MaDT = DT.MADT left join tbl_DMTonGiao TG on N.MaTG =TG.MaTG left join tbl_PhongBan PB on " +
            "N.MaPhong = PB.MaPhong left join tbl_DanhMucTo T on N.MaTo = T.MaTo left join tbl_DMChucVu CV on" +
            " N.MaChucVu = CV.MaChucVu where N.MaNV='"+ma+"'";
            //mở csdl
            sc.Open();
            //khai báo sqldataadapter
            SqlCommand sel = new SqlCommand(sel_, sc);
            sda.SelectCommand = sel;
            sda.Fill(ds, "nhanvien");
            sc.Close();
        }
        
        public DataSet laydl1(string ma)
        {
            ds2.Clear();
            //câu lệnh select
            string sel_ = "select * from tbl_nhanvien N left join tbl_DMDanToc DT on " +
            "N.MaDT = DT.MADT left join tbl_DMTonGiao TG on N.MaTG =TG.MaTG left join tbl_PhongBan PB on " +
            "N.MaPhong = PB.MaPhong left join tbl_DanhMucTo T on N.MaTo = T.MaTo left join tbl_DMChucVu CV on" +
            " N.MaChucVu = CV.MaChucVu where N.MaNV='" + ma + "'";
            //mở csdl
            sc.Open();
            //khai báo sqldataadapter
            SqlCommand sel = new SqlCommand(sel_, sc);
            sda.SelectCommand = sel;
            sda.Fill(ds2, "nhanvien");           
            sc.Close();
            ds.WriteXmlSchema("HSNhanVien.xml");
            return ds2;
        }
        //them nhan vien co ma to
        public void ThemNV(string manv_1,string ho_2,string ten_3,
                           char gioitinh_4,string socmnd_5,
                           DateTime ngaysinh_6, string noisinh_7,
                           int matg_8,int madt_9,string dienthoai_10,
                           string dtdd_11,string hokhau_12,string choohientai_13,
                           string tinhtranghonnhan_14,string hinhanh_15,
                           int machucvu_16,string maphong_17,string mato_18,
                           DateTime ngayvaolam_19,string sobhyt_20,
                           string sobhxh_21,string sotheatm_22,string ghichu_23,string email_24)
        {
            //them nhan vien moi co to
            sql.ExecuteNonQuery("Insert_tbl_nhanvien",
                 CommandType.StoredProcedure,
                 "@MaNV_1", manv_1,
                 "@Ho_2", ho_2,
                 "@Ten_3", ten_3,
                 "@GioiTinh_4", gioitinh_4,
                 "@SoCMND_5 ", socmnd_5,
                 "@NgaySinh_6", ngaysinh_6,
                 "@NoiSinh_7", noisinh_7,
                 "@MaTG_8", matg_8,
                 "@MaDT_9", madt_9,
                 "@DienThoai_10", dienthoai_10,
                 "@DTDD_11", dtdd_11,
                 "@HoKhauTT_12", hokhau_12,
                 "@ChoOHienTai_13", choohientai_13,
                 "@TinhTrangHonNhan_14", tinhtranghonnhan_14,
                 "@Hinhanh_15", hinhanh_15,
                 "@MaChucVu_16", machucvu_16,
                 "@MaPhong_17", maphong_17,
                 "@MaTo_18", mato_18,
                 "@NgayVaoLam_19", ngayvaolam_19,
                 "@SoBHYT_20", sobhyt_20,
                 "@SoBHXH_21", sobhxh_21,
                 "@SoTheATM_22", sotheatm_22,
                 "@GhiChu_23", ghichu_23,
                 "@Email_24",email_24);
           
        }

        //them nhan vien khong co ma to
        public void ThemNV(string manv_1, string ho_2, string ten_3,
                        char gioitinh_4, string socmnd_5,
                        DateTime ngaysinh_6, string noisinh_7,
                        int matg_8, int madt_9, string dienthoai_10,
                        string dtdd_11, string hokhau_12, string choohientai_13,
                        string tinhtranghonnhan_14,string hinhanh_15,
                        int machucvu_16, string maphong_17, DateTime ngayvaolam_19,
                        string sobhyt_20, string sobhxh_21, string sotheatm_22,
                        string ghichu_23,string email_24)
        {

            sql.ExecuteNonQuery("Insert_tbl_nhanvien_1",
                 CommandType.StoredProcedure,
                 "@MaNV_1", manv_1,
                 "@Ho_2", ho_2,
                 "@Ten_3", ten_3,
                 "@GioiTinh_4", gioitinh_4,
                 "@SoCMND_5 ", socmnd_5,
                 "@NgaySinh_6", ngaysinh_6,
                 "@NoiSinh_7", noisinh_7,
                 "@MaTG_8", matg_8,
                 "@MaDT_9", madt_9,
                 "@DienThoai_10", dienthoai_10,
                 "@DTDD_11", dtdd_11,
                 "@HoKhauTT_12", hokhau_12,
                 "@ChoOHienTai_13", choohientai_13,
                 "@TinhTrangHonNhan_14", tinhtranghonnhan_14,
                 "@Hinhanh_15", hinhanh_15,
                 "@MaChucVu_16", machucvu_16,
                 "@MaPhong_17", maphong_17,
                 "@NgayVaoLam_18", ngayvaolam_19,
                 "@SoBHYT_19", sobhyt_20,
                 "@SoBHXH_20", sobhxh_21,
                 "@SoTheATM_21", sotheatm_22,
                 "@GhiChu_22", ghichu_23,
                 "@Email_23",email_24);
           

        }
        //xóa
        public void XoaNV(string manv_1)
        {
            sql.ExecuteNonQuery("Delete_tbl_nhanvien",
                    CommandType.StoredProcedure, "@MaNV_1", manv_1);     
        }

        //sua nhan vien co ma to
        public void SuaNV(string manv_1, string ho_2, string ten_3,
            char gioitinh_4, string socmnd_5,
            DateTime ngaysinh_6, string noisinh_7,
            int matg_8, int madt_9, string dienthoai_10,
            string dtdd_11, string hokhau_12, string choohientai_13,
            string tinhtranghonnhan_14,string hinhanh_15,
            int machucvu_16, string maphong_17, string mato_18,
            DateTime ngayvaolam_19, string sobhyt_20, string sobhxh_21,
            string sotheatm_22,string ghichu_23,string email_24)
        {

            sql.ExecuteNonQuery("update_tbl_NhanVien_1",
                  CommandType.StoredProcedure,
                 "@MaNV_1", manv_1,
                 "@Ho_2", ho_2,
                 "@Ten_3", ten_3,
                 "@GioiTinh_4", gioitinh_4,
                 "@SoCMND_5 ", socmnd_5,
                 "@NgaySinh_6", ngaysinh_6,
                 "@NoiSinh_7", noisinh_7,
                 "@MaTG_8", matg_8,
                 "@MaDT_9", madt_9,
                 "@DienThoai_10", dienthoai_10,
                 "@DTDD_11", dtdd_11,
                 "@HoKhauTT_12", hokhau_12,
                 "@ChoOHienTai_13", choohientai_13,
                 "@TinhTrangHonNhan_14", tinhtranghonnhan_14,
                 "@Hinhanh_15", hinhanh_15,
                 "@MaChucVu_16", machucvu_16,
                 "@MaPhong_17", maphong_17,
                 "@MaTo_18", mato_18,
                 "@NgayVaoLam_19", ngayvaolam_19,
                 "@SoBHYT_20", sobhyt_20,
                 "@SoBHXH_21", sobhxh_21,
                 "@SoTheATM_22", sotheatm_22,
                 "@GhiChu_23", ghichu_23,
                 "@Email_24",email_24);
           
        }

        //sua nhan vien khong co ma to
        public void SuaNV(string manv_1, string ho_2, string ten_3,
            char gioitinh_4, string socmnd_5,
            DateTime ngaysinh_6, string noisinh_7,
            int matg_8, int madt_9, string dienthoai_10,
            string dtdd_11, string hokhau_12, string choohientai_13,
            string tinhtranghonnhan_14,string hinhanh_15,
            int machucvu_16, string maphong_17,
            DateTime ngayvaolam_19, string sobhyt_20, 
            string sobhxh_21, string sotheatm_22,string ghichu_23,string email_24)
        {

            sql.ExecuteNonQuery("update_tbl_nhanvien", CommandType.StoredProcedure,
                 "@MaNV_1", manv_1,
                 "@Ho_2", ho_2,
                 "@Ten_3", ten_3,
                 "@GioiTinh_4", gioitinh_4,
                 "@SoCMND_5 ", socmnd_5,
                 "@NgaySinh_6", ngaysinh_6,
                 "@NoiSinh_7", noisinh_7,
                 "@MaTG_8", matg_8,
                 "@MaDT_9", madt_9,
                 "@DienThoai_10", dienthoai_10,
                 "@DTDD_11", dtdd_11,
                 "@HoKhauTT_12", hokhau_12,
                 "@ChoOHienTai_13", choohientai_13,
                 "@TinhTrangHonNhan_14", tinhtranghonnhan_14,
                 "@Hinhanh_15", hinhanh_15,
                 "@MaChucVu_16", machucvu_16,
                 "@MaPhong_17", maphong_17,
                 "@NgayVaoLam_18", ngayvaolam_19,
                 "@SoBHYT_19", sobhyt_20,
                 "@SoBHXH_20", sobhxh_21,
                 "@SoTheATM_21", sotheatm_22,
                 "@GhiChu_22", ghichu_23,
                 "@Email_23",email_24);
           
        }

        public DataTable timkiem(string ma)
        {
            ds1.Clear();
            //câu lệnh select
            string sel_ = "select manv,ho,ten from tbl_nhanvien where manv like '" + ma + "%'";
            sc.Open();
            //khai báo sqldataadapter
            SqlCommand sel = new SqlCommand(sel_, sc);
            sda.SelectCommand = sel;
            sda.Fill(ds1, "NV");
            sc.Close();
            return ds1.Tables["NV"];
        }
        //lấy mã nhân viên cuối cùng
        public string laynvcuoi()
        {
            string sel = "select top 1 percent manv from tbl_nhanvien order by manv desc";
            sc.Open();
            SqlCommand sel1 = new SqlCommand(sel,sc);
            object o = sel1.ExecuteScalar();
            sc.Close();
            return o.ToString();
        }
    }
}
