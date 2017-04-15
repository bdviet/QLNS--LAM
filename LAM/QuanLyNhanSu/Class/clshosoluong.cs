using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace QuanLyNhanSu.Class
{
    class clshosoluong
    {
        public QuanLyNhanSu.Class.sql sql = new QuanLyNhanSu.Class.sql();
        public SqlConnection sc = frmMain.me.sql.connectSQL();
        public SqlDataAdapter sda = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        public DataSet ds1 = new DataSet();

        //lấy dữ liệu theo mã nhân viên
        public DataTable  laydl(string ma)
        {
            ds1.Clear();
            string sel_ = "select a.* from tbl_HoSoLuong a inner join tbl_chitiethopdong b on a.sohd =b.sohd where b.manv = '" + ma + "'";
            sc.Open();
            SqlCommand sel = new SqlCommand(sel_, sc);
            sda.SelectCommand = sel;
            sda.Fill(ds1, "HoSoLuong");
            sc.Close();
            return ds1.Tables["HoSoLuong"];
        }
        //lấy dữ liệu 
        public void laydl()
        {
            ds.Clear();
            //câu lệnh select
            string sel_ = "select * from tbl_HoSoLuong ";
            //mở csdl
            sc.Open();
            //khai báo sqldataadapter

            SqlCommand sel = new SqlCommand(sel_, sc);
            sda.SelectCommand = sel;
            sda.Fill(ds, "HoSoLuong");
            sc.Close();
        }
        //thêm
        public void them(string ma, DateTime ngayll, int mucluong)
        {
                sql.ExecuteNonQuery("insert_tbl_HoSoLuong", CommandType.StoredProcedure,
                                        "@sohd_1", ma,
                                        "@NgayLL_2", ngayll,
                                        "@MucLuong_3", mucluong);
        }
        
        //xóa
        public void xoa(string ma, DateTime ngayll)
        {
            sql.ExecuteNonQuery("Delete_tbl_HoSoLuong", CommandType.StoredProcedure,
                                        "@sohd_1", ma,
                                        "@NgayLL_2",ngayll);
            
        }

        //sửa
        public void sua(string ma, DateTime ngayll, int mucluong)
        {
            sql.ExecuteNonQuery("UpDate_tbl_HoSoLuong", CommandType.StoredProcedure,
                                        "@sohd_1", ma,
                                        "@NgayLL_2", ngayll,
                                        "@MucLuong_3", mucluong);
           
        }
        public bool kiemtra(string ma)
        {
            sc.Open();
            string sel_ = "select a.* from tbl_HoSoLuong a inner join tbl_chitiethopdong b on a.sohd =b.sohd where b.manv = '" + ma + "'";
            SqlCommand sel = new SqlCommand(sel_, sc);
            object o = sel.ExecuteScalar();
            sc.Close();
            if (o == null)
                return false;
            else
                return true;
        }
        //tạo combo lấy SoHD theo mã nhân viên
        public DataTable  taocombo(string ma)
        {
            ds.Clear();
            string sel_ = " select sohd from tbl_ChiTietHopDong where manv = '" + ma + "'";
            SqlCommand sel = new SqlCommand(sel_, sc);
            sda.SelectCommand = sel;
            sda.Fill(ds, "SoHopDong");
            sc.Close();
            return ds.Tables["SoHopDong"];
        }

        //tạo combo lấy sohd trong hồ sơ lương
        public DataTable taocombohd(string ma)
        {
            ds.Clear();
            string sel_ = " select a.sohd from tbl_HoSoLuong a inner join tbl_chitietHopDong b"+
                " on a.sohd = b.sohd where b.manv = '"+ma+"'";
            SqlCommand sel = new SqlCommand(sel_, sc);
            sda.SelectCommand = sel;
            sda.Fill(ds, "HSL_SoHD");
            sc.Close();
            return ds.Tables["HSL_SoHD"];
        }
        
    }
}
