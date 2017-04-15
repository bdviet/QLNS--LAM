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
    public partial class frmDMPhongBan : RadForm
    {
        clsdmpb c = new clsdmpb();
        int k = 0;

        public frmDMPhongBan()
        {
            InitializeComponent();
            c.laydl("tbl_PhongBan");
            txtmaPB.DataBindings.Add("text", c.ds, "tbl_PhongBan.Maphong");
            txttenPB.DataBindings.Add("text", c.ds, "tbl_PhongBan.tenphong");
            txtdienthoai.DataBindings.Add("text", c.ds, "tbl_PhongBan.dienthoai");
            dgv_DMPB.DataSource = c.ds;
            dgv_DMPB.DataMember = "tbl_PhongBan";

            dgv_DMPB.Columns[0].HeaderText = "Mã phòng ban";
            dgv_DMPB.Columns[1].HeaderText = "Tên phòng ban";
            dgv_DMPB.Columns[2].HeaderText = "Điện thoại";
            
        }

        public void setbutton(bool b)
        {
            cmdcapnhat.Enabled = b;
            cmdthem.Enabled = b;
            cmdthoat.Enabled = b;
            cmdxoa.Enabled = b;
            cmdluu.Enabled = !b;
        }

        private void cmdthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDMPhongBan_Load(object sender, EventArgs e)
        {
            setbutton(true);
        }

        private void cmdthem_Click(object sender, EventArgs e)
        {
            txtmaPB.Text = "";
            txttenPB.Text = "";
            txtdienthoai.Text = "";
            txtmaPB.ReadOnly = false;
            txttenPB.ReadOnly = false;
            txtdienthoai.ReadOnly = false;
            txtmaPB.Focus();
            setbutton(false);
            k = 1;
        }

        private void cmdcapnhat_Click(object sender, EventArgs e)
        {
            if (dgv_DMPB.SelectedRows.Count == 0)
            {
                RadMessageBox.Show("\nBạn phải chọn dòng để cập nhật !\n", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                return;
            }
            else
            {
                txttenPB.ReadOnly = false;
                txtdienthoai.ReadOnly = false;
                txttenPB.Focus();
                setbutton(false);
                k = 2;
            }
        }

        private void cmdxoa_Click(object sender, EventArgs e)
        {
            if (dgv_DMPB.SelectedRows.Count == 0)
            {
                RadMessageBox.Show("\nBạn phải chọn dòng để xóa !\n", "Thông Báo", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                return;
            }
            else
            {
                DialogResult rs = RadMessageBox.Show("\nBạn thật sự muốn xóa thông tin này không ?\n", "Thông Báo", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    c.xoa("tbl_PhongBan", txtmaPB.Text.Trim(), "maphong",5);
                    c.laydl("tbl_phongban");
                    
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
                    if (txtmaPB.Text == "" || txttenPB.Text == "")
                    {
                        RadMessageBox.Show(this, "\nBạn phải nhập đầy đủ thông tin vào !\n", "Thông báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                    }
                    else
                    {
                        //them moi
                        c.them("tbl_PhongBan", txtmaPB.Text.Trim(),
                            txttenPB.Text.Trim(), txtdienthoai.Text.Trim());                        
                    }
                }
                else if (k == 2)
                {
                    if (txtmaPB.Text == "" || txttenPB.Text == "")
                    {
                        RadMessageBox.Show(this, "\nBạn phải nhập đầy đủ thông tin vào !\n", "Thông báo", MessageBoxButtons.OK,RadMessageIcon.Exclamation);
                    }
                    else
                    {
                        //update
                        c.sua("tbl_PhongBan", txtmaPB.Text.Trim(), txttenPB.Text.Trim(),
                            txtdienthoai.Text.Trim(), "maphong", "tenphong", "dienthoai");
                    }
                }
            }
            c.laydl("tbl_Phongban");
            txtmaPB.ReadOnly = true;
            txttenPB.ReadOnly = true;
            txtdienthoai.ReadOnly = true;
            k = 0;
            setbutton(true);
        }
    }
}