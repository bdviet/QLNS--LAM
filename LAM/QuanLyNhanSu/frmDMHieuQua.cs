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
    public partial class frmDMHieuQua : RadForm
    {
        clshieuqua c = new clshieuqua();
        int k = 0; 
        public frmDMHieuQua()
        {
            InitializeComponent();
            c.laydl("tbl_hieuqua");
            txtmahq.DataBindings.Add("text", c.ds, "tbl_hieuqua.Mahieuqua");
            txtphucap.DataBindings.Add("text", c.ds, "tbl_hieuqua.phucap");
            dgv_DMhieuqua.DataSource = c.ds;
            dgv_DMhieuqua.DataMember = "tbl_hieuqua";
            dgv_DMhieuqua.Columns[0].HeaderText = "Mã hiệu quả";
            dgv_DMhieuqua.Columns[1].HeaderText = "Tỉ lệ lương";
        }
        
        public void setbutton(bool b)
        {
            cmdCapnhat.Enabled = b;
            cmdthem.Enabled = b;
            cmdthoat.Enabled = b;
            cmdxoa.Enabled = b;
            cmdluu.Enabled = !b;
        }
        private void cmdthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDMHieuQua_Load(object sender, EventArgs e)
        {
            setbutton(true);
        }

        private void cmdthem_Click(object sender, EventArgs e)
        {
            txtmahq.Text = "";
            txtphucap.Text = "0";
            txtmahq.ReadOnly = false;
            txtphucap.ReadOnly = false;
            txtmahq.Focus();
            setbutton(false);
            k = 1;
        }
        private void cmdxoa_Click(object sender, EventArgs e)
        {
            if (dgv_DMhieuqua.SelectedRows.Count == 0)
            {
                RadMessageBox.Show("\nBạn phải chọn dòng để xóa !\n", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                return;
            }
            else
            {
                DialogResult rs = RadMessageBox.Show("\nBạn thật sực muốn xóa thông tin này không ?\n", "Thông Báo", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    c.xoa("tbl_hieuqua", txtmahq.Text.Trim(), "mahieuqua",2);
                    c.laydl("tbl_hieuqua");
                    
                }
            }
        }

        private void cmdCapnhat_Click(object sender, EventArgs e)
        {
            if (dgv_DMhieuqua.SelectedRows.Count == 0)
            {
                RadMessageBox.Show("\nBạn phải chọn dòng để cập nhật !\n", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                return;
            }
            else
            {
                txtphucap.ReadOnly = false;
                txtphucap.Focus();
                setbutton(false);
                k = 2;
            }
        }

        private void cmdluu_Click(object sender, EventArgs e)
        {
            DialogResult rs = RadMessageBox.Show("\nBạn thật sự muốn lưu thông tin này không ?\n", "Thông Báo", MessageBoxButtons.YesNo, RadMessageIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (k == 1)
                {
                    if (txtmahq.Text == "" || txtphucap.Text == "")
                    {
                        RadMessageBox.Show(this, "\nBạn phải nhập đầy đủ thông tin vào !\n", "Thông báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        c.them("tbl_hieuqua",txtmahq.Text.Trim(),
                            txtphucap.Text !=""?double.Parse(txtphucap.Text.Trim()):1);
                        c.laydl("tbl_hieuqua");                        
                    }
                }
                else if (k == 2)
                {
                    if (txtmahq.Text == "" || txtphucap.Text == "")
                    {
                        RadMessageBox.Show(this, "\nBạn phải nhập đầy đủ thông tin vào !\n", "Thông báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        c.sua("tbl_hieuqua", txtmahq.Text.Trim(), txtphucap.Text != "" ? double.Parse(txtphucap.Text.Trim()) : 1,
                            "mahieuqua", "phucap");
                    }                  

                }
            }
            txtmahq.ReadOnly = true;
            txtphucap.ReadOnly = true;
            k = 0;
            setbutton(true);
        }
    }
}