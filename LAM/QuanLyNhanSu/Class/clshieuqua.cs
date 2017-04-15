using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace QuanLyNhanSu.Class
{
    class clshieuqua 
    {
        public SqlConnection sc = frmMain.me.sql.connectSQL();
        public SqlDataAdapter sda = new SqlDataAdapter();
        public DataSet ds = new DataSet();
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
        public DataSet taocombo()
        {
            clshieuqua c = new clshieuqua();
            sc.Open();
            string sql1 = "Select * from tbl_HieuQua";
            SqlCommand scmd = new SqlCommand(sql1, c.sc);
            sda.SelectCommand = scmd;
            sda.Fill(c.ds, "hieuqua");
            sc.Close();
            return c.ds;
        }
        //lấy dữ liệu hiệu quả của nhân viên trong tháng năm
        public void them(string tenbang, string ma, double phucap)
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
                    MessageBox.Show("Mã này đã có", "Thông báo");
                else
                    MessageBox.Show("Bạn Không Thêm Được");
            }
            finally
            {
            }
            sc.Close();
        }

        public void sua(string tenbang, string ma, double phucap, string tencotma,
            string tencotphucap)
        {
            //dung rieng cho form danh muc hieu gua
            sc.Open();
            //câu lệnh update
            string sqlupd = "update "+tenbang +" set "+tencotphucap+"=@"+tencotphucap+" where "+tencotma+"=@"+tencotma;
            SqlCommand upd = new SqlCommand(sqlupd, sc);
            SqlParameter umahq = new SqlParameter("@"+tencotma, SqlDbType.NVarChar, 2, tencotma);
            SqlParameter uphucap = new SqlParameter("@"+tencotphucap , SqlDbType.Real ,4, tencotphucap );
            uphucap.Value = phucap;
            umahq.Value = ma ;
            upd.Parameters.AddRange(new SqlParameter[] { umahq, uphucap });
            sda.UpdateCommand = upd;
            try
            {
                upd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Không thể thực hiện", "Thông Báo");
            }
            sc.Close();
        }

        public void xoa(string tenbang, string ma, string tencotma,int chieudai)
        {
            sc.Open();
            //câu lệnh xóa
            string sqldel = "delete "+tenbang+" where "+tencotma+"=@"+tencotma;
            SqlCommand del = new SqlCommand(sqldel, sc);
            SqlParameter dMahq = new SqlParameter("@"+tencotma, SqlDbType.NVarChar, chieudai, tencotma);
            dMahq.Value = ma;
            del.Parameters.AddRange(new SqlParameter[] { dMahq });
            sda.DeleteCommand = del;
            try
            {
                del.ExecuteNonQuery();
            }
            catch 
            {
                MessageBox.Show("Không thể thực hiện", "Thông Báo");
            }
            sc.Close();
        }

        //hàm trả về mảng lưu trữ mã hiệu quả
        public  string[] bangphanloai()
        {
            int i = taocombo().Tables["hieuqua"].Rows.Count;
            string[] tenmahq = new string[i];
            for (int j = 0; j < i; j++)
            {
                tenmahq[j] = taocombo().Tables["hieuqua"].Rows[j]["MaHieuQua"].ToString();
            }
            return tenmahq;
        }
        //hàm trả về mảng lấy tỉ lệ trong từng mã hiệu quả
        public double [] tilehq()
        {
            int i = taocombo().Tables["hieuqua"].Rows.Count;
            double [] tilehq = new double [i];
            for (int j = 0; j < i; j++)
            {
                tilehq[j] = double.Parse(taocombo().Tables["hieuqua"].Rows[j]["phucap"].ToString());
            }
            return tilehq;
        }
    }
}
