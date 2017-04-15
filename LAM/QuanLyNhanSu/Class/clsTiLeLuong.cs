using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Telerik.Data;
using Telerik.WinControls.UI;
using QuanLyNhanSu.Class;
using Telerik.WinControls;

namespace QuanLyNhanSu.Class
{
    class clsTiLeLuong
    {
        public SqlConnection sc = frmMain.me.sql.connectSQL();
        public SqlDataAdapter sda = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        public DataSet ds1 = new DataSet();
        public void laydl()
        {
            ds.Clear();
            string sql = "Select L.ID,L.mato,L.thang,L.nam,P.tenphong,T.tento,L.tileluong,L.songaycongthang from tbl_tileluongtheophong L inner join tbl_phongban P " +
                        "on L.maphong=P.maphong left join tbl_danhmucto T on L.mato=T.mato Order By L.nam, L.thang";
            sc.Open();
            SqlCommand scmd = new SqlCommand(sql, sc);
            sda.SelectCommand = scmd;
            sda.Fill(ds, "TiLeLuong");
            sc.Close();

        }
        public DataTable laydl(string thang, string nam,
                               string maphong, string to)
        {
            ds1.Clear();
            string sel = "select songaycongthang,tileluong from tbl_tileluongtheophong where id = '" + thang + nam + maphong + to + "'";
            sc.Open();
            SqlCommand scmd = new SqlCommand(sel, sc);
            sda.SelectCommand = scmd;
            sda.Fill(ds1, "TiLeLuong");
            sc.Close();
            return ds1.Tables["TiLeLuong"];
        }
        public void them(int t,int n,string phong,string to,
                         double tll,int ngaycong)
        {
            sql.ExecuteNonQuery("Insert_tbl_tileluongtheophong", CommandType.StoredProcedure,
                                "@id_1", t +""+ n + phong + to,
                                "@thang_2", t,
                                "@nam_3", n,
                                "@maphong_4", phong,
                                "@mato_5", to,
                                "@tileluong_6", tll,
                                "@songaycongthang_7", ngaycong);

        }
        public void them(int t, int n, string phong,
                         double tll, int ngaycong)
        {
            sql.ExecuteNonQuery("Insert_tbl_tileluongtheophong_koto", CommandType.StoredProcedure,
                                "@id_1", t +""+ n + phong,
                                "@thang_2", t,
                                "@nam_3", n,
                                "@maphong_4", phong,
                                "@tileluong_5", tll,
                                "@songaycongthang_6", ngaycong);

        }
        public void sua(string ma, double tll, int ngaycong)
        {
            sql.ExecuteNonQuery("Update_tbl_tileluongtheophong",
                                 CommandType.StoredProcedure,
                                "@id_1",ma,
                                "@tileluong_2", tll,
                                "@songaycongthang_3", ngaycong);
        }
        public void xoa(string ma)
        {
            sql.ExecuteNonQuery("Delete_tbl_tileluongtheophong", CommandType.StoredProcedure,
                                "@id_1", ma);
        }
    }
}
