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
    public partial class frmDMLoaiHD : RadForm
    {
        clsdmhd c = new clsdmhd();
        //bien luu tru trang thai them hay sua
        int k = 0;
        public frmDMLoaiHD()
        {
            InitializeComponent();
            c.laydl("tbl_LoaiHD");
            //lấy dữ liệu ra textbox
            txtmahd.DataBindings.Add("text", c.ds, "tbl_loaihd.maloaiHD");
            txttenloai.DataBindings.Add("text", c.ds, "tbl_loaihd.TenLoaiHD");
            dgv_DMHD.DataSource = c.ds;
            dgv_DMHD.DataMember = "tbl_LoaiHD";

            dgv_DMHD.Columns[0].HeaderText = "Mã hợp đồng";
            dgv_DMHD.Columns[1].HeaderText = "Lọai hợp đồng";

        }

        public void setbutton(bool b)
        {
            cmdCapnhat.Enabled = b;
            cmdthem.Enabled = b;
            cmdthoat.Enabled = b;
            cmdxoa.Enabled = b;
            cmdluu.Enabled = !b;
        }

        private void frmDMLoaiHD_Load(object sender, EventArgs e)
        {
            setbutton(true);
        }
        private void txtmahd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                RadMessageBox.Show("\nBạn phải nhập số !\n", "Thông báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                txtmahd.Text = "";
                txtmahd.Focus();
            }
        }

        private void cmdthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdthem_Click(object sender, EventArgs e)
        {
            txtmahd.Text = "";
            txttenloai.Text = "";
            txtmahd.ReadOnly = false;
            txttenloai.ReadOnly = false;
            txtmahd.Focus();
            setbutton(false);
            k = 1;
        }

        private void cmdCapnhat_Click(object sender, EventArgs e)
        {
            if (dgv_DMHD.SelectedRows.Count == 0)
            {
                RadMessageBox.Show("\nBạn phải chọn dòng để cập nhật !\n", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                return;
            }
            else
            {
                txttenloai.ReadOnly = false;
                txttenloai.Focus();
                setbutton(false);
                k = 2;
            }
        }

        private void cmdxoa_Click(object sender, EventArgs e)
        {
            if (dgv_DMHD.SelectedRows.Count == 0)
            {
                RadMessageBox.Show("\nBạn phải chọn dòng để xóa !\n", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                return;
            }
            else
            {
                DialogResult rs = RadMessageBox.Show("\nBạn thật sự muốn xóa thông tin này không?\n", "Thông Báo", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    c.xoa("tbl_LoaiHD", int.Parse(txtmahd.Text.Trim()), "Maloaihd");
                    c.laydl("tbl_loaihd");

                }
            }
        }

        private void cmdluu_Click(object sender, EventArgs e)
        {
            DialogResult rs = RadMessageBox.Show("\nBạn thật sự muốn lưu thông tin này không ?\n", "Thông Báo", MessageBoxButtons.YesNo, RadMessageIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (k == 1)
                {
                    if (txtmahd.Text == "" || txttenloai.Text == "")
                    {
                        RadMessageBox.Show(this, "\nBạn phải nhập đầy đủ thông tin vào !\n", "Thông báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        c.them("tbl_LoaiHD", int.Parse(txtmahd.Text.Trim()), txttenloai.Text.Trim());
                    }
                }
                else if (k == 2)
                {
                    if (txtmahd.Text == "" || txttenloai.Text == "")
                    {
                        RadMessageBox.Show(this, "\nBạn phải nhập đầy đủ thông tin vào !\n", "Thông báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                        return;
                    }
                    else
                    {

                        c.sua("tbl_loaihd", int.Parse(txtmahd.Text.Trim()), txttenloai.Text.Trim(), "maloaihd", "tenloaihd");
                    }
                }
            }
            c.laydl("tbl_loaihd");
            txtmahd.ReadOnly = true;
            txttenloai.ReadOnly = true;
            k = 0;
            setbutton(true);
        }
    }
}
                    
