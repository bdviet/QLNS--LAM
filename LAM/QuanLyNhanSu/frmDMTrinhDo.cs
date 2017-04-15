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
    public partial class frmDMTrinhDo : RadForm
    {
        clsdmngoaingu c = new clsdmngoaingu();
        int k = 0; 
        public frmDMTrinhDo()
        {
            InitializeComponent();
            c.laydl("tbl_dmtrinhdo");
            txtmaTD.DataBindings.Add("text", c.ds, "tbl_DMtrinhdo.Matrinhdo");
            txttenTD.DataBindings.Add("text", c.ds, "tbl_DMtrinhdo.tentrinhdo");
            dgv_DMTD.DataSource = c.ds;
            dgv_DMTD.DataMember = "tbl_DMtrinhdo";

            dgv_DMTD.Columns[0].HeaderText = "Mã trình độ";
            dgv_DMTD.Columns[1].HeaderText = "Tên trình độ";
        }
        public void setbutton(bool b)
        {
            cmdCapnhat.Enabled = b;
            cmdthem.Enabled = b;
            cmdthoat.Enabled = b;
            cmdxoa.Enabled = b;
            cmdluu.Enabled = !b;
        }

        private void frmDMTrinhDo_Load(object sender, EventArgs e)
        {
            setbutton(true);
        }

        private void cmdthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtmaTD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                RadMessageBox.Show("\nBạn phải nhập số !", "Thông báo", MessageBoxButtons.OK, RadMessageIcon.Error);
                txtmaTD.Text = "";
                txtmaTD.Focus();
            }
        }

        private void cmdxoa_Click(object sender, EventArgs e)
        {
            if (dgv_DMTD.SelectedRows.Count == 0)
            {
                RadMessageBox.Show("\nBạn phải chọn dòng để xóa !", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
            else
            {
                DialogResult rs = RadMessageBox.Show("\nBạn thật sự muốn xóa thông tin này ?\n", "Thông Báo", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    c.xoa("tbl_dmtrinhdo", int.Parse(txtmaTD.Text.Trim()), "matrinhdo");
                    c.laydl("tbl_dmtrinhdo");
                    
                }
            }
        }

        private void cmdthem_Click(object sender, EventArgs e)
        {
            txtmaTD.Text = "";
            txttenTD.Text = "";
            txtmaTD.ReadOnly = false;
            txttenTD.ReadOnly = false;
            txtmaTD.Focus();
            setbutton(false);
            k = 1;
        }

        private void cmdCapnhat_Click(object sender, EventArgs e)
        {
            if (dgv_DMTD.SelectedRows.Count == 0)
            {
                RadMessageBox.Show("\nBạn phải chọn dòng để cập nhật !\n ", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
            else
            {
                txttenTD.ReadOnly = false;
                txttenTD.Focus();
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
                    if (txtmaTD.Text == "" || txttenTD.Text == "")
                    {
                        RadMessageBox.Show(this, "\nBạn phải nhập đầy đủ thông tin vào !\n", "Thông báo", MessageBoxButtons.OK, RadMessageIcon.Error);
                        return;
                    }
                    else
                    {   //thêm mẩu tin mới vào datagirdview
                        c.them("tbl_dmtrinhdo", int.Parse(txtmaTD.Text.Trim())
                            , txttenTD.Text.Trim());                        
                    }
                }
                else if (k == 2)
                {
                    if (txtmaTD.Text == "" || txttenTD.Text == "")
                    {
                        RadMessageBox.Show(this, "\nBạn phải nhập đầy đủ thông tin vào !\n", "Thông báo", MessageBoxButtons.OK, RadMessageIcon.Error);
                        return;
                    }
                    else
                    {
                        //cập nhật mẩu tin
                        c.sua("tbl_DMTrinhDo", int.Parse(txtmaTD.Text.Trim()),
                            txttenTD.Text.Trim(), "maTrinhDo", "tenTrinhDo");
                    }
                }
            }
            //load lại dữ liệu
            c.laydl("tbl_DMTrinhDo");
            txtmaTD.ReadOnly = true;
            txttenTD.ReadOnly = true;
            k = 0;
            setbutton(true);
        }
    }
}

          