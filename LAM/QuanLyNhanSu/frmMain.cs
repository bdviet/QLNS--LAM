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
using Telerik.Data;
using QuanLyNhanSu.Class;

namespace QuanLyNhanSu
{
    public partial class frmMain : RadRibbonForm
    {
        public static frmMain me;
        public QuanLyNhanSu.Class.sql sql;
        
        public frmMain()
        {
            readFile c = new readFile();
            c.readfile();
            string strServerName = "";
            string strDatabase = "";
            if (c.strLine1.Contains("Server:") == true) strServerName = c.strLine1.Substring(7);
            if (c.strLine2.Contains("Database:") == true) strDatabase = c.strLine2.Substring(9);

            InitializeComponent();
            sql = new sql(strServerName, strDatabase,
                "U0", "123");
            me = this;

        }
        private Form KiemTraTonTai(Type formType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formType)
                    return f;
            }
            return null;
        }
        private string ChuoiTruyCapForm(string ten)
        {
            return "Select * from tbl_user_form U inner join " +
                "tbl_DMform F on U.IDform=F.ID where U.username='" + sql.GetUser() + "' and  F.tenform='" + ten + "' and U.rights=1";
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = RadMessageBox.Show("\nBạn có thực sự muốn thoát chương trình ?\n","Thông báo",MessageBoxButtons.YesNo,RadMessageIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
            }
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Form1_ obj_ = new Form1_();
            obj_.ShowDialog();
            frmConfig obj = new frmConfig();
            obj.ShowDialog();
            //DateTime.Parse(layngay());

            //MessageBox.Show(layngay());


        }
        public string layngay()
        {
            string sel = "select top 1 percent Start from Appointments order by Start desc";
            SqlConnection con = frmMain.me.sql.connectSQL();
            con.Open();
            SqlCommand sel1 = new SqlCommand(sel, con);
            object o = sel1.ExecuteScalar();
            con.Close();
            return o.ToString();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            SqlConnection con = frmMain.me.sql.connectSQL();
            con.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmNhanvien"), con);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmNhanvien));
                if (frm != null)
                    frm.Activate();
                else
                {
                    
                    frmNhanvien f = new frmNhanvien();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                RadMessageBox.Show("\nBạn không có quyền truy cập !\n", "Thông Báo",MessageBoxButtons.OK,RadMessageIcon.Exclamation);
            con.Close();
        }

        private void btnTyLeLuongThang_Click(object sender, EventArgs e)
        {
            SqlConnection sc = frmMain.me.sql.connectSQL();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmbangtileluong"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmbangtileluong));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmbangtileluong f = new frmbangtileluong();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                RadMessageBox.Show("\nBạn không có quyền truy cập !\n", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
            sc.Close();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            SqlConnection sc = frmMain.me.sql.connectSQL();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmkiemtrabangluong"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmkiemtrabangluong));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmkiemtrabangluong f = new frmkiemtrabangluong();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                RadMessageBox.Show("\nBạn không có quyền truy cập !\n", "Thông Báo",MessageBoxButtons.OK,RadMessageIcon.Exclamation);
            sc.Close();
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            SqlConnection sc = frmMain.me.sql.connectSQL();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmDMChucVu"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmDMChucVu));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmDMChucVu f = new frmDMChucVu();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                RadMessageBox.Show("\nBạn không có quyền truy cập !\n", "Thông Báo",MessageBoxButtons.OK,RadMessageIcon.Exclamation);
            sc.Close();
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmPhanQuyen));
            if (frm != null)
                frm.Activate();
            else
            {
                frmPhanQuyen f = new frmPhanQuyen();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBCLuongThang_Click(object sender, EventArgs e)
        {
            SqlConnection sc = frmMain.me.sql.connectSQL();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmchonbcluong"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmchonbcluong));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmchonbcluong f = new frmchonbcluong();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                RadMessageBox.Show("\nBạn không có quyền truy cập !\n", "Thông Báo",MessageBoxButtons.OK,RadMessageIcon.Exclamation);
            sc.Close();           
        }

        private void btnBCNhanSu_Click(object sender, EventArgs e)
        {
            SqlConnection sc = frmMain.me.sql.connectSQL();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmchonbcnv"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmchonbcnv));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmchonbcnv f = new frmchonbcnv();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                RadMessageBox.Show("\nBạn không có quyền truy cập !\n", "Thông Báo",MessageBoxButtons.OK,RadMessageIcon.Error);
            sc.Close();         
        }

        private void btnHDHetHan_Click(object sender, EventArgs e)
        {
            SqlConnection sc = frmMain.me.sql.connectSQL();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmKiemTraHDHetHan"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmKiemTraHDHetHan));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmKiemTraHDHetHan f = new frmKiemTraHDHetHan();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                RadMessageBox.Show("\nBạn không có quyền truy cập !\n", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Error);
            sc.Close();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {

            //Application.Restart();
            frmDangNhap obj = new frmDangNhap();
            obj.ShowDialog();
            
            
        }

        private void btnDoiMatKau_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmDoiMatKhau));
            if (frm != null)
                frm.Activate();
            else
            {
                frmDoiMatKhau f = new frmDoiMatKhau();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTonGiao_Click(object sender, EventArgs e)
        {
            SqlConnection sc = frmMain.me.sql.connectSQL();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmDMTonGiao"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmDMTonGiao));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmDMTonGiao f = new frmDMTonGiao();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                RadMessageBox.Show("\nBạn không có quyền truy cập !\n", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Error);
            sc.Close();
        }

        private void btnDanToc_Click(object sender, EventArgs e)
        {
            SqlConnection sc = frmMain.me.sql.connectSQL();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmDMDanToc"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmDMDanToc));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmDMDanToc f = new frmDMDanToc();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                RadMessageBox.Show("\nBạn không có quyền truy cập !\n", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Error);
            sc.Close();
        }

        private void btnTrinhDo_Click(object sender, EventArgs e)
        {
            SqlConnection sc = frmMain.me.sql.connectSQL();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmDMTrinhDo"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmDMTrinhDo));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmDMTrinhDo f = new frmDMTrinhDo();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                RadMessageBox.Show("\nBạn không có quyền truy cập !\n", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Error);
            sc.Close();
        }

        private void btnChuyenMon_Click(object sender, EventArgs e)
        {
            SqlConnection sc = frmMain.me.sql.connectSQL();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmDMChuyenMon"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmDMChuyenMon));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmDMChuyenMon f = new frmDMChuyenMon();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                RadMessageBox.Show("\nBạn không có quyền truy cập !\n", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Error);
            sc.Close();
        }

        private void btnNgoaiNgu_Click(object sender, EventArgs e)
        {
            SqlConnection sc = frmMain.me.sql.connectSQL();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmDMNgoaiNgu"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmDMNgoaiNgu));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmDMNgoaiNgu f = new frmDMNgoaiNgu();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                RadMessageBox.Show("\nBạn không có quyền truy cập !\n", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Error);
            sc.Close();
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            SqlConnection sc = frmMain.me.sql.connectSQL();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmDMPhongBan"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmDMPhongBan));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmDMPhongBan f = new frmDMPhongBan();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                RadMessageBox.Show("\nBạn không có quyền truy cập !\n", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Error);
            sc.Close();
        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            SqlConnection sc = frmMain.me.sql.connectSQL();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmDMTo"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmDMTo));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmDMTo f = new frmDMTo();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                RadMessageBox.Show("\nBạn không có quyền truy cập !\n", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Error);
            sc.Close();
        }

        private void btnLoaiHopDong_Click(object sender, EventArgs e)
        {
            SqlConnection sc = frmMain.me.sql.connectSQL();
            sc.Open();
            SqlCommand scmd = new SqlCommand(ChuoiTruyCapForm("frmDMLoaiHD"), sc);
            if (scmd.ExecuteReader().Read())
            {
                Form frm = KiemTraTonTai(typeof(frmDMLoaiHD));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmDMLoaiHD f = new frmDMLoaiHD();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
                RadMessageBox.Show("\nBạn không có quyền truy cập !\n", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Error);
            sc.Close();
        }

        private void btnTaoNguoiDung_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmUser));
            if (frm != null)
                frm.Activate();
            else
            {
                frmUser f = new frmUser();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmThongTin));
            if (frm != null)
                frm.Activate();
            else
            {
                frmThongTin f = new frmThongTin();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDMHieuQua_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmDMHieuQua));
            if (frm != null)
                frm.Activate();
            else
            {
                frmDMHieuQua f = new frmDMHieuQua();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void radImageButtonElement1_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmLichLamViec));
            if (frm != null)
                frm.Activate();
            else
            {
                frmLichLamViec f = new frmLichLamViec();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dr = RadMessageBox.Show("\nBạn có thực sự muốn thoát chương trình ?\n", "Thông báo", MessageBoxButtons.YesNo, RadMessageIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
            }
        }


        
    }
}
