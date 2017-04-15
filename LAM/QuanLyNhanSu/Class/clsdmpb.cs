using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace QuanLyNhanSu.Class
{
    class clsdmpb: clsdm
    {   
        public DataSet taocombo()
        {
            
            clsdmpb c=new clsdmpb();
            c.sc.Open();
            
            string sql1 = "Select * from tbl_PhongBan";
            SqlCommand scmd = new SqlCommand(sql1, c.sc);
            c.sda.SelectCommand = scmd;
            c.sda.Fill(c.ds, "tbl_PhongBan");
            c.sc.Close();
            return c.ds;
        }
        //dùng cho form nhân viên
        public DataTable laydlList(string maphong)
        {
            clsdmpb c = new clsdmpb();
            c.sc.Open();
            string sql="Select N.MaNV,N.Ho,N.Ten from tbl_Nhanvien N inner join tbl_phongban P"+
                " on N.MaPhong=P.MaPhong where N.MaPhong='"+maphong+"'";
            SqlCommand scmd = new SqlCommand(sql, c.sc);
            c.sda.SelectCommand = scmd;
            c.sda.Fill(c.ds, "NV_Phong");
            c.sc.Close();
            return c.ds.Tables["NV_Phong"];

        }
        //dùng cho form bảng lương
        public DataTable laydlList(string maphong,string thang,string nam)
        {
            clsdmpb c = new clsdmpb();
            c.sc.Open();
            string sql = "Select BL.MaNV,N.Ho,N.Ten from tbl_BangLuong BL inner join tbl_phongban P" +
                " on BL.MaPhong=P.MaPhong inner join tbl_NhanVien N on BL.MaNV = N.MaNV where BL.MaPhong='" + maphong +
                "' and BL.thang ='" + thang + "' and BL.nam ='" + nam + "'";
            SqlCommand scmd = new SqlCommand(sql, c.sc);
            c.sda.SelectCommand = scmd;
            c.sda.Fill(c.ds, "NV_Phong");
            c.sc.Close();
            return c.ds.Tables["NV_Phong"];

        }

        public string laytenPB(string ma)
        {
            if (ma == "") return "";
            clsdmchucvu c = new clsdmchucvu();
            c.sc.Open();
            string sql1 = "Select TenPhong from tbl_PhongBan where MaPhong='" + ma + "'";
            SqlCommand scmd = new SqlCommand(sql1, c.sc);
            object ten = scmd.ExecuteScalar();
            c.sc.Close();
            return ten.ToString();
        }
        
    }
}
