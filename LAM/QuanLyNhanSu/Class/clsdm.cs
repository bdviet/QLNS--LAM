using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows;
using System.Data.SqlClient;
using Telerik.Data;
using Telerik.WinControls;
using QuanLyNhanSu.Class;

namespace QuanLyNhanSu.Class
{
    
    //class này dùng chung cho các form danh mục 
    public class clsdm
    {
        public sql cnn = new sql();

        public SqlConnection sc = frmMain.me.sql.connectSQL();
        public SqlDataAdapter sda = new SqlDataAdapter();

        public DataSet ds = new DataSet();

        public void them(string tenbang, int ma, string ten)
        {
            sc.Open();
            //them moi           
            string insert = "insert into " + tenbang + " values ("
                + ma + ",N'" +
                ten + "')";
            SqlCommand ins = new SqlCommand(insert, sc);

            try
            {
                ins.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                if (e.Number == 2627)
                    RadMessageBox.Show("\nMã này đã có\n", "Thông báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                else
                    RadMessageBox.Show("\nBạn Không Thêm Được\n", "Thông báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
            }
            finally
            {
            }
            sc.Close();
        }

        public void them(string tenbang, int ma, string ten, int phucap)
        {
            sc.Open();
            int i = phucap > 0 ? phucap : 0;
            string insert = "insert into " + tenbang + " values (" +
                ma + ",N'" + ten + "'," + phucap + ")";
            SqlCommand ins = new SqlCommand(insert, sc);

            try
            {
                ins.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                if (e.Number == 2627)
                    RadMessageBox.Show("\nMã này đã có\n", "Thông báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                else
                    RadMessageBox.Show("\nBạn Không Thêm Được\n", "Thông báo",MessageBoxButtons.OK, RadMessageIcon.Exclamation);
            }
            finally
            {
            }
            sc.Close();
        }

        public void them(string tenbang, string ma, int phucap)
        {
            sc.Open();
            //them moi           
            string insert = "insert into " + tenbang + " values('"
                + ma + "'," + phucap + ")";
            SqlCommand ins = new SqlCommand(insert, sc);

            try
            {
                ins.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                if (e.Number == 2627)
                    RadMessageBox.Show("\nMã này đã có\n", "Thông báo",MessageBoxButtons.OK,RadMessageIcon.Exclamation);
                else
                    RadMessageBox.Show("\nBạn Không Thêm Được\n", "Thông báo",MessageBoxButtons.OK, RadMessageIcon.Exclamation);
            }
            finally
            {
            }
            sc.Close();
        }

        public void them(string tenbang, string ma, string ten, string dt)
        {
            sc.Open();
            //them moi           
            string insert = "insert into " + tenbang + " values('"
                + ma + "',N'" +
                ten + "','" + dt + "')";
            SqlCommand ins = new SqlCommand(insert, sc);

            try
            {
                ins.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                if (e.Number == 2627)
                    RadMessageBox.Show("Mã này đã có", "Thông báo",MessageBoxButtons.OK,RadMessageIcon.Exclamation);
                else
                    RadMessageBox.Show("Bạn Không Thêm Được","Thông báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
            }
            finally
            {
            }
            sc.Close();
        }

        public void sua(string tenbang, int ma, string ten, string tencotma,
            string tencotten)
        {
            sc.Open();
            //câu lệnh update
            string sqlupd = "update " + tenbang + " set " + tencotten + "=@" + tencotten +
            " where " + tencotma + "=@" + tencotma;
            SqlCommand upd = new SqlCommand(sqlupd, sc);
            SqlParameter uma = new SqlParameter("@" + tencotma, SqlDbType.Int, 9, tencotma);
            SqlParameter uten = new SqlParameter("@" + tencotten, SqlDbType.NVarChar, 50, tencotten);
            uma.Value = ma;
            uten.Value = ten;
            upd.Parameters.AddRange(new SqlParameter[] { uma, uten });
            sda.UpdateCommand = upd;
            try
            {
                upd.ExecuteNonQuery();
            }
            catch
            {
                RadMessageBox.Show("Không thể thực hiện", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
            }
            sc.Close();
        }

        public void sua(string tenbang, int ma, string ten, int phucap,
            string tencotma, string tencotten, string tencotphucap)
        {
            //dung trong form chuc vu
            sc.Open();
            //câu lệnh update
            string sqlupd = "update " + tenbang + " set " + tencotten + "=@tenchucvu," + tencotphucap +
                "=@Phucap where " + tencotma + "=@machucvu";
            SqlCommand upd = new SqlCommand(sqlupd, sc);
            SqlParameter umaCV = new SqlParameter("@machucvu", SqlDbType.Int, 9, tencotma);
            SqlParameter utenCV = new SqlParameter("@tenchucvu", SqlDbType.NVarChar,
                50, tencotten);
            SqlParameter uPhuCap = new SqlParameter("@phucap", SqlDbType.Int, 9,
                tencotphucap);
            umaCV.Value = ma;
            utenCV.Value = ten;
            uPhuCap.Value = phucap;
            upd.Parameters.AddRange(new SqlParameter[] { umaCV, utenCV, uPhuCap });
            sda.UpdateCommand = upd;
            try
            {
                upd.ExecuteNonQuery();
            }
            catch
            {
                RadMessageBox.Show("Không thể thực hiện", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
            }
            sc.Close();
        }


        public void sua(string tenbang, string ma, string ten, string dt,
            string tencotma, string tencotten, string tencotdt)
        {
            //dùng cho danh mục phòng ban
            sc.Open();
            //câu lệnh update
            string sqlupd = "update " + tenbang + " set " + tencotten + "=@" + tencotten + "," +
            tencotdt + "=@" + tencotdt + " where " + tencotma + "=@" + tencotma;
            SqlCommand upd = new SqlCommand(sqlupd, sc);
            SqlParameter uma = new SqlParameter("@" + tencotma, SqlDbType.NVarChar, 5, tencotma);
            SqlParameter uten = new SqlParameter("@" + tencotten, SqlDbType.NVarChar, 50, tencotten);
            SqlParameter udt = new SqlParameter("@" + tencotdt, SqlDbType.NVarChar, 12, tencotdt);
            uma.Value = ma;
            uten.Value = ten;
            udt.Value = dt;
            upd.Parameters.AddRange(new SqlParameter[] { uma, uten, udt });
            sda.UpdateCommand = upd;
            try
            {
                upd.ExecuteNonQuery();
            }
            catch
            {
                RadMessageBox.Show("Không thể thực hiện", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
            }
            sc.Close();
        }

        public void suato(string tenbang, string mato, string maphong,
            string tento, string tencotma, string tencotmaphong, string tencotten)
        {
            //dùng cho danh mục phòng ban
            sc.Open();
            //câu lệnh update
            string sqlupd = "update " + tenbang + " set " + tencotmaphong
                + "=@" + tencotmaphong + "," +
            tencotten + "=@" + tencotten + " where " + tencotma + "=@" + tencotma;
            SqlCommand upd = new SqlCommand(sqlupd, sc);
            SqlParameter uma = new SqlParameter("@" + tencotma, SqlDbType.NVarChar, 3, tencotma);
            SqlParameter uten = new SqlParameter("@" + tencotmaphong, SqlDbType.NVarChar, 5, tencotmaphong);
            SqlParameter udt = new SqlParameter("@" + tencotten, SqlDbType.NVarChar, 50, tencotten);
            uma.Value = mato;
            uten.Value = maphong;
            udt.Value = tento;
            upd.Parameters.AddRange(new SqlParameter[] { uma, uten, udt });
            sda.UpdateCommand = upd;
            try
            {
                upd.ExecuteNonQuery();
            }
            catch
            {
                RadMessageBox.Show("Không thể thực hiện", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
            }
            sc.Close();
        }

        public void xoa(string tenbang, int ma, string tencotma)
        {

            sc.Open();
            //câu lệnh xóa
            string sqldel = "delete " + tenbang + " where " + tencotma + "=@" + tencotma;
            SqlCommand del = new SqlCommand(sqldel, sc);
            SqlParameter dMa = new SqlParameter("@" + tencotma, SqlDbType.Int, 9, tencotma);
            dMa.Value = ma;
            del.Parameters.AddRange(new SqlParameter[] { dMa });
            sda.DeleteCommand = del;
            try
            {
                del.ExecuteNonQuery();
                //MessageBox.Show("dữ liệu đã được xóa", "Thông Báo");
            }
            catch
            {
                RadMessageBox.Show("Không thể thực hiện", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
            }
            sc.Close();

        }

        public void xoa(string tenbang, string ma, string tencotma, int chieudai)
        {
            //dung cho form danh muc phong ban,danh muc hieu qua,danh muc to
            sc.Open();
            //câu lệnh xóa
            string sqldel = "delete " + tenbang + " where " + tencotma + "=@" + tencotma;
            SqlCommand del = new SqlCommand(sqldel, sc);
            SqlParameter dMahq = new SqlParameter("@" + tencotma, SqlDbType.NVarChar, chieudai, tencotma);
            dMahq.Value = ma;
            del.Parameters.AddRange(new SqlParameter[] { dMahq });
            sda.DeleteCommand = del;
            try
            {
                del.ExecuteNonQuery();
                //MessageBox.Show("dữ liệu đã được xóa", "Thông Báo");
            }
            catch
            {
                RadMessageBox.Show("Không thể thực hiện", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
            }
            sc.Close();
        }

        public void laydl(string tenbang)
        {
            ds.Clear();
            //câu lệnh select
            string sel_ = "select * from " + tenbang;
            //mở csdl
            sc.Open();
            SqlCommand sel = new SqlCommand(sel_, sc);
            sda.SelectCommand = sel;
            sda.Fill(ds, tenbang);
            sc.Close();
        }

        public void laydldmto()
        {
            ds.Clear();
            //câu lệnh select
            string sel_ = "select a.mato,a.tento,b.tenphong from tbl_danhmucto a inner join" +
                " tbl_PhongBan b on a.maphong = b.maphong";
            //mở csdl
            sc.Open();
            SqlCommand sel = new SqlCommand(sel_, sc);
            sda.SelectCommand = sel;
            sda.Fill(ds, "phongto");
            sc.Close();
        }
    }
}
