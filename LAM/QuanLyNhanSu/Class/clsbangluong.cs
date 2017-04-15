using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyNhanSu.Class;

namespace QuanLyNhanSu.Class
{
    class clsbangluong
    {
        public QuanLyNhanSu.Class.sql sql = new QuanLyNhanSu.Class.sql();
        public SqlConnection sc = frmMain.me.sql.connectSQL();
        public SqlDataAdapter sda = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        public DataSet ds1 = new DataSet();
        //nhập dữ liệu nhân viên vào bảng lương
        public void them(string ma,string thang,string nam)
        {
           
            sql.ExecuteNonQuery("insert_tblbangluong", CommandType.StoredProcedure,
                                    "@manv", ma,
                                    "@thang", thang,
                                    "@nam", nam);
        }
        //lấy dữ liệu theo tháng năm và mã nhân viên trong bảng lương
        public void laydl(string thang, string nam,string ma)
        {
            ds.Clear();
            sc.Open();
            string sel = "select * from tbl_bangluong where thang ='" + thang + "' and nam ='" + nam + "' and manv = '"+ma+"'";
            SqlCommand scmd = new SqlCommand(sel, sc);
            sda.SelectCommand = scmd;
            sda.Fill(ds, "bangluong");
            sc.Close();
        }
        //2 phương thức lấy dữ liệu đưa vào datagirdview
        public DataSet laydlgird(string thang, string nam, string maphong)
        {
            ds1.Clear();
            sc.Open();
            string sel = "select [Thang],[Nam],BL.[MaNV],N.Ho,N.Ten,BL.[maphong],BL.[mato],[Luongcoban],[MaHieuQua],[tilehq],[SongayLV],[SogioTangCa],[SogioTangCaCN],[SoNgayNghiPhep],[songaynghingungviec],[tileccvasinhhoat],[LuongLamViec],[LuongTangCa],[BHXHvaBHYT],[phucapcv],[pcsinhhoatcc],[phucapkhac],[ThucLanh] from tbl_bangluong BL inner join tbl_NhanVien N on BL.MaNV = N.MaNV where BL.thang ='" + thang + "' and BL.nam ='" +
                         nam + "' and BL.maphong = '" + maphong + "'";
            //string sel = "select BL.*,N.Ho,N.Ten from tbl_bangluong BL inner join tbl_NhanVien N on BL.MaNV = N.MaNV where BL.thang ='" + thang + "' and BL.nam ='" +
                         //nam + "' and BL.maphong = '" + maphong +"'";
            SqlCommand scmd = new SqlCommand(sel, sc);
            sda.SelectCommand = scmd;
            sda.Fill(ds1, "bangluong");
            string sel1 = "select * from tbl_phongban";
            SqlCommand scmd1 = new SqlCommand(sel1, sc);
            sda.SelectCommand = scmd1;
            sda.Fill(ds1, "phongban");
            sc.Close();
            ds1.WriteXmlSchema("luongtheophong.xml");
            return ds1;
        }
        public DataSet laydlgird(string thang, string nam, string maphong, string mato)
        {
            ds1.Clear();
            sc.Open();
            string sel = "select [Thang],[Nam],BL.[MaNV],N.Ho,N.Ten,BL.[maphong],BL.[mato],[Luongcoban],[MaHieuQua],[tilehq],[SongayLV],[SogioTangCa],[SogioTangCaCN],[SoNgayNghiPhep],[songaynghingungviec],[tileccvasinhhoat],[LuongLamViec],[LuongTangCa],[BHXHvaBHYT],[phucapcv],[pcsinhhoatcc],[phucapkhac],[ThucLanh] from tbl_bangluong BL inner join tbl_NhanVien N on BL.MaNV = N.MaNV where BL.thang ='" + thang + "' and BL.nam ='" +
                         nam + "' and BL.maphong = '" + maphong + "' and BL.mato ='" + mato + "'";
            //string sel = "select BL.*,N.Ho,N.Ten from tbl_bangluong BL inner join tbl_NhanVien N on BL.MaNV = N.MaNV where BL.thang ='" + thang + "' and BL.nam ='" +
                         //nam + "' and BL.maphong = '" + maphong + "' and BL.mato ='" + mato + "'";
            SqlCommand scmd = new SqlCommand(sel, sc);
            sda.SelectCommand = scmd;
            sda.Fill(ds1, "bangluong");
            string sel1 = "select * from tbl_danhmucto";
            SqlCommand scmd1 = new SqlCommand(sel1, sc);
            sda.SelectCommand = scmd1;
            sda.Fill(ds1, "dmto");            
            sc.Close();
            ds1.WriteXmlSchema("luongtheoto.xml");
            return ds1;
        }
        //chấm công
        public void chamcong(string thang, string nam, string manv,
                             string pl, int songaycong, 
                             int sogioot1, int sogioot2, int songaynghiphep,
                             int songayngungviec, double tile,int pckhac)
        {
            sql.ExecuteNonQuery("update_tbl_BangLuong", CommandType.StoredProcedure,
                                   "@Thang_1", thang,
                                   "@nam_2", nam,
                                   "@MaNV_3", manv,
                                   "@MaHieuQua_4", pl,
                                   "@SoNgayLV_5", songaycong,
                                   "@SogioTangCa_6", sogioot1,
                                   "@SogioTangCaCN_7", sogioot2,
                                   "@SoNgayNghiPhep_8", songaynghiphep,
                                   "@songaynghingungviec_9 ", songayngungviec,
                                   "@tileccvasinhhoat_10", tile,
                                   "@phucapkhac",pckhac);

        }
        //tính lương
        public void tinhluong(string thang, string nam, string manv,
                              int luongcoban, double tilehq, int songaylv,
                              int sogioot1, int sogioot2, int songaynghiphep,
                              int songayngungviec, double tilecc, int pccv,
                              int ngaycongchuan, double tiletb, int pckhac)
        {
            sql.ExecuteNonQuery("update_tbl_bangluong_1", CommandType.StoredProcedure,
                                  "@Thang", thang,
                                   "@nam", nam,
                                   "@MaNV", manv,
                                   "@Luongcoban", luongcoban,
                                   "@tilehq", tilehq,
                                   "@SongayLV", songaylv,
                                   "@SogioTangCa", sogioot1,
                                   "@SogioTangCaCN", sogioot2,
                                   "@SoNgayNghiPhep", songaynghiphep,
                                   "@songaynghingungviec", songayngungviec,
                                   "@tileccvasinhhoat", tilecc,
                                   "@phucapcv", pccv,
                                   "@songaycongchuan", ngaycongchuan,
                                   "@TileTB", tiletb,
                                   "@phucapkhac", pckhac);
        }

    }
}
