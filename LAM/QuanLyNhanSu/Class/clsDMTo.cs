using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace QuanLyNhanSu.Class
{
    class clsDMTo : clsdm
    {
        public DataSet taocombo(string maphong)
        {
            clsDMTo c = new clsDMTo();
            c.sc.Open();
            string sql1 = "Select * from tbl_DanhMucTo where maphong ='"+maphong+"'";
            SqlCommand scmd = new SqlCommand(sql1, c.sc);
            c.sda.SelectCommand = scmd;
            c.sda.Fill(c.ds, "DanhMucTo");
            c.sc.Close();
            return c.ds;
        }
        //dùng cho form nhân viên
        public DataTable laydlList(string maphong,string mato)
        {
            clsDMTo c = new clsDMTo();
            c.sc.Open();
            if (mato != null)
            {
                string sql = "Select N.MaNV,N.Ho,N.Ten from tbl_Nhanvien N inner join tbl_DanhMucTo T" +
                    " on N.MaTo=T.MaTo where " +
                            " N.MaPhong= '" + maphong + "' and N.MaTo='" + mato + "'";
                SqlCommand scmd = new SqlCommand(sql, c.sc);
                c.sda.SelectCommand = scmd;
                c.sda.Fill(c.ds, "NV_To");
                c.sc.Close();
            }
            else
            {
                string sql = "Select N.MaNV,N.Ho,N.Ten from tbl_Nhanvien N inner join tbl_PhongBan P" +
                    " on N.MaPhong=P.MaPhong where " +
                            " N.MaPhong= '" + maphong + "'";
                SqlCommand scmd = new SqlCommand(sql, c.sc);
                c.sda.SelectCommand = scmd;
                c.sda.Fill(c.ds, "NV_To");
                c.sc.Close();
            }
            return c.ds.Tables["NV_To"];
        }
        //dùng cho form bảng lương
        public DataTable laydlList(string maphong, string mato,string thang,
                                   string nam)
        {
            clsDMTo c = new clsDMTo();
            c.sc.Open();
            if (mato != null)
            {
                string sql = "Select BL.MaNV,N.Ho,N.Ten from tbl_bangluong BL inner join tbl_DanhMucTo T" +
                    " on BL.MaTo=T.MaTo  inner join tbl_nhanvien N on BL.MaNV = N.MaNV where " +
                            " BL.MaPhong= '" + maphong + "' and BL.MaTo='" + mato +
                            "' and BL.thang ='"+thang+"' and BL.nam ='"+nam+"'";
                SqlCommand scmd = new SqlCommand(sql, c.sc);
                c.sda.SelectCommand = scmd;
                c.sda.Fill(c.ds, "NV_To");
                c.sc.Close();
            }
            else
            {
                string sql = "Select BL.MaNV,N.Ho,N.Ten from tbl_BangLuong BL inner join tbl_PhongBan P" +
                    " on BL.MaPhong=P.MaPhong inner join tbl_NhanVien N on BL.MaNV = N.MaNV where " +
                            " BL.MaPhong= '" + maphong + "' and BL.thang ='" + thang + "' and BL.nam ='" + nam + "'";
                SqlCommand scmd = new SqlCommand(sql, c.sc);
                c.sda.SelectCommand = scmd;
                c.sda.Fill(c.ds, "NV_To");
                c.sc.Close();
            }
            return c.ds.Tables["NV_To"];
        }

        public string laytenTo(string maTo)
        {
            if (maTo == "") return "";
            clsdmchucvu c = new clsdmchucvu();
            c.sc.Open();
            string sql1 = "Select TenTo from tbl_DanhMucTo where MaTo='" + maTo + "'";
            SqlCommand scmd = new SqlCommand(sql1, c.sc);
            object ten = scmd.ExecuteScalar();
            c.sc.Close();
            return ten.ToString();
        }
    }
}
