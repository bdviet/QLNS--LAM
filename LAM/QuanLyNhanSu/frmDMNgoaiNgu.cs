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
using System.Data.SqlClient;

using QuanLyNhanSu.Class;

namespace QuanLyNhanSu
{
    public partial class frmDMNgoaiNgu : RadForm
    {
        clsdmngoaingu c = new clsdmngoaingu();
        int k = 0; 
        public frmDMNgoaiNgu()
        {
            InitializeComponent();
            c.laydl("tbl_dmngoaingu");
            txtmaNN.DataBindings.Add("text", c.ds, "tbl_DMNgoaiNgu.MaNgoaiNgu");
            txttenNN.DataBindings.Add("text", c.ds, "tbl_DMNgoaiNgu.tenNgoaiNgu");
            dgv_DMNN.DataSource = c.ds;
            dgv_DMNN.DataMember = "tbl_DMNgoaiNgu";

            dgv_DMNN.Columns[0].HeaderText = "Mã ngoại ngữ";
            dgv_DMNN.Columns[1].HeaderText = "Tên ngoại ngữ";
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

        private void frmDMNgoaiNgu_Load(object sender, EventArgs e)
        {
            setbutton(true);
        }

        private void txtmaNN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                RadMessageBox.Show("\n Bạn phải nhập số !\n", "Thông báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                txtmaNN.Text = "";
                txtmaNN.Focus();
            }
        }

        private void cmdxoa_Click(object sender, EventArgs e)
        {
            if (dgv_DMNN.SelectedRows.Count == 0)
            {
                RadMessageBox.Show("\nBạn phải chọn dòng để xóa !\n", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                return;
            }
            else
            {
                DialogResult rs = RadMessageBox.Show("\nBạn thật sự muốn xóa thông tin này ?", "Thông Báo", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    c.xoa("tbl_dmngoaingu", int.Parse(txtmaNN.Text.Trim()), "mangoaingu");
                    c.laydl("tbl_dmngoaingu");
                    
                }
            }
        }

        private void cmdthem_Click(object sender, EventArgs e)
        {
            txtmaNN.Text = "";
            txttenNN.Text = "";
            txtmaNN.ReadOnly = false;
            txttenNN.ReadOnly = false;
            txtmaNN.Focus();
            setbutton(false);
            k = 1;
        }

        private void cmdCapnhat_Click(object sender, EventArgs e)
        {
            if (dgv_DMNN.SelectedRows.Count == 0)
            {
                RadMessageBox.Show("\nBạn phải chọn dòng để cập nhật thông tin!\n", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                return;
            }
            else
            {
                txttenNN.ReadOnly = false;
                txttenNN.Focus();
                setbutton(false);
                k = 2;
            }

        }

        private void cmdluu_Click(object sender, EventArgs e)
        {
            DialogResult rs = RadMessageBox.Show("\nBạn muốn lưu không thông tin này ?\n", "Thông Báo", MessageBoxButtons.YesNo, RadMessageIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (k == 1)
                {
                    if (txtmaNN.Text == "" || txttenNN.Text == "")
                    {
                        RadMessageBox.Show(this, "\nBạn phải nhập đầy đủ thông tin vào !\n", "Thông báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        c.them("tbl_dmngoaingu", int.Parse(txtmaNN.Text.Trim())
                            , txttenNN.Text.Trim());
                    }
                }
                else if (k == 2)
                {
                    if (txtmaNN.Text == "" || txttenNN.Text == "")
                    {
                        RadMessageBox.Show(this, "\nBạn phải nhập đầy đủ thông tin vào !\n", "Thông báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        //cập nhật mẩu tin
                        c.sua("tbl_DMngoaingu", int.Parse(txtmaNN.Text.Trim()),
                            txttenNN.Text.Trim(), "mangoaingu", "tenngoaingu");
                    }
                }
            }
            c.laydl("tbl_DMngoaingu");
            txtmaNN.ReadOnly = true;
            txttenNN.ReadOnly = true;
            k = 0;
            setbutton(true);            
        }
    }
}