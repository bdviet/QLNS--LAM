using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.Data;
using QuanLyNhanSu.Class;

namespace QuanLyNhanSu
{
    public partial class frmchonbcnv : RadForm
    {
        //khai báo biến toàn cục
        public SqlConnection sc = frmMain.me.sql.connectSQL();
        public SqlDataAdapter sda = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        clsdmpb cphong = new clsdmpb();
        clsDMTo cto = new clsDMTo();
        static public string maphong = "";
        static public string mato = "";
        static public string manv = "";
        public frmchonbcnv()
        {
            InitializeComponent();
            cbophong.DataSource = cphong.taocombo();
            cbophong.DisplayMember = "tbl_phongban.tenphong";
            cbophong.ValueMember = "tbl_phongban.maphong";
        }
        //kiểm tra có tồn tại nhân viên nào thuộc tổ này hay không
        private bool kiemtra(string maphong, string mato)
        {
            ds.Clear();
            string sel = "select * from tbl_nhanvien where maphong ='" + maphong
                          + "' and mato ='" + mato + "'";
            sc.Open();
            SqlCommand scmd = new SqlCommand(sel, sc);
            object o = scmd.ExecuteScalar();
            sc.Close();
            if (o != null)
                return true;
            else
                return false;
        }
        //kiểm tra có tồn tại nhân viên nào thuộc tổ này hay không
        private bool kiemtra(string maphong)
        {
            ds.Clear();
            string sel = "select * from tbl_nhanvien where maphong ='" + maphong + "'";
            sc.Open();
            SqlCommand scmd = new SqlCommand(sel, sc);
            object o = scmd.ExecuteScalar();
            sc.Close();
            if (o != null)
                return true;
            else
                return false;
        }
        //kiểm tra xem nhân viên đó có trong bảng tbl_nhân viên hay không?
        private bool kiemtranv(string manv)
        {
            ds.Clear();
            string sel = "select * from tbl_nhanvien where manv ='" + manv + "'";
            sc.Open();
            SqlCommand scmd = new SqlCommand(sel, sc);
            object o = scmd.ExecuteScalar();
            sc.Close();
            if (o != null)
                return true;
            else
                return false;
        }
        //lấy ds nhân viên theo tổ đưa vào file xml;
        static public DataSet bcnhanvien(string maphong, string mato)
        {
            SqlConnection sc = frmMain.me.sql.connectSQL();
            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            ds.Clear();
            sc.Open();
            string sel = "select * from tbl_nhanvien where maphong ='" + maphong
                          + "' and mato ='" + mato + "'";
            SqlCommand scmd = new SqlCommand(sel, sc);
            sda.SelectCommand = scmd;
            sda.Fill(ds, "nhanvien");
            string sel1 = "select * from tbl_danhmucto";
            SqlCommand scmd1 = new SqlCommand(sel1, sc);
            sda.SelectCommand = scmd1;
            sda.Fill(ds, "dmto");
            string sel2 = "select * from tbl_phongban";
            SqlCommand scmd2 = new SqlCommand(sel2, sc);
            sda.SelectCommand = scmd2;
            sda.Fill(ds, "phong");
            string sel3 = "select * from tbl_dmchucvu";
            SqlCommand scmd3 = new SqlCommand(sel3, sc);
            sda.SelectCommand = scmd3;
            sda.Fill(ds, "chucvu");
            sc.Close();
            ds.WriteXmlSchema("bcnhanvien.xml");
            return ds;
        }
        //lấy ds nhân viên theo phòng đưa vào file xml;
        static public DataSet bcnhanvien(string maphong)
        {
            SqlConnection sc = frmMain.me.sql.connectSQL();
            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            ds.Clear();
            sc.Open();
            string sel = "select * from tbl_nhanvien where maphong ='" + maphong + "'";
            SqlCommand scmd = new SqlCommand(sel, sc);
            sda.SelectCommand = scmd;
            sda.Fill(ds, "nhanvien");
            string sel2 = "select * from tbl_phongban";
            SqlCommand scmd2 = new SqlCommand(sel2, sc);
            sda.SelectCommand = scmd2;
            sda.Fill(ds, "phong");
            string sel3 = "select * from tbl_dmchucvu";
            SqlCommand scmd3 = new SqlCommand(sel3, sc);
            sda.SelectCommand = scmd3;
            sda.Fill(ds, "chucvu");
            sc.Close();
            ds.WriteXmlSchema("bcnhanvien.xml");
            return ds;
        }
        //lấy lý lịch nhân viên đưa vào file xml;
        static public DataSet lylichnv(string manv)
        {
            SqlConnection sc = frmMain.me.sql.connectSQL();
            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            ds.Clear();
            sc.Open();
            //nhanvien
            string sel = "select * from tbl_NhanVien where manv ='" + manv + "'";
            SqlCommand scmd = new SqlCommand(sel, sc);
            sda.SelectCommand = scmd;
            sda.Fill(ds, "nhanvien");
            //to
            string sel1 = "select * from tbl_danhmucto";
            SqlCommand scmd1 = new SqlCommand(sel1, sc);
            sda.SelectCommand = scmd1;
            sda.Fill(ds, "dmto");
            //phongban
            string sel2 = "select * from tbl_phongban";
            SqlCommand scmd2 = new SqlCommand(sel2, sc);
            sda.SelectCommand = scmd2;
            sda.Fill(ds, "phong");
            //chucvu
            string sel3 = "select * from tbl_dmchucvu";
            SqlCommand scmd3 = new SqlCommand(sel3, sc);
            sda.SelectCommand = scmd3;
            sda.Fill(ds, "chucvu");
            //tongiao
            string sel4 = "select * from tbl_DMtongiao";
            SqlCommand scmd4 = new SqlCommand(sel4, sc);
            sda.SelectCommand = scmd4;
            sda.Fill(ds, "tongiao");
            //dantoc
            string sel5 = "select * from tbl_DMdantoc";
            SqlCommand scmd5 = new SqlCommand(sel5, sc);
            sda.SelectCommand = scmd5;
            sda.Fill(ds, "dantoc");
            sc.Close();
            ds.WriteXmlSchema("HSNhanVien.xml");
            return ds;

        }
        private void cbophong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboto.DataSource = cto.taocombo(cbophong.SelectedValue.ToString());
            cboto.DisplayMember = "DanhMucto.tento";
            cboto.ValueMember = "DanhMucto.mato";
            cboto.Text = "";
        }

        private void cmdin_Click(object sender, EventArgs e)
        {
            if (cboto.Text.Trim() == "")
            {
                if (kiemtra(cbophong.SelectedValue.ToString()) == true)
                {
                    maphong = cbophong.SelectedValue.ToString();
                    frmrptbcnhanvien f = new frmrptbcnhanvien();
                    f.MdiParent = this.MdiParent;
                    f.Show();
                }
            }
            else if (cboto.Text.Trim() != "")
            {
                if (kiemtra(cbophong.SelectedValue.ToString(), cboto.SelectedValue.ToString()) == true)
                {
                    maphong = cbophong.SelectedValue.ToString();
                    mato = cboto.SelectedValue.ToString();
                    frmrptbcnhanvien f = new frmrptbcnhanvien();
                    f.MdiParent = this.MdiParent;
                    f.Show();
                }
            }
            maphong = ""; mato = "";
        }

        private void frmchonbcnv_Load(object sender, EventArgs e)
        {
            maphong = ""; mato = ""; manv = "";
        }
    }
}
