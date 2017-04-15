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
    public partial class frmDMTo : RadForm
    {
        //khai báo biến toàn cục
        clsDMTo c = new clsDMTo();
        clsdmpb cPhong = new clsdmpb();
        int k = 0;
        public frmDMTo()
        {
            InitializeComponent();
            c.laydldmto();            
            cbomaphong.DataSource =cPhong.taocombo ();
            cbomaphong.DisplayMember = "tbl_PhongBan.TenPhong";
            cbomaphong.ValueMember = "tbl_PhongBan.MaPhong";
            txtmato.DataBindings.Add("text", c.ds, "phongto.MaTo");
            txttento.DataBindings.Add("text", c.ds, "phongto.TenTo");
            cbomaphong.DataBindings.Add("text", c.ds, "phongto.tenPhong");
            dgv_DMTO.DataSource = c.ds;
            dgv_DMTO.DataMember = "phongto";

            dgv_DMTO.Columns[0].HeaderText = "Mã";
            dgv_DMTO.Columns[1].HeaderText = "Tổ";
            dgv_DMTO.Columns[2].HeaderText = "Phòng";
            
        }
        public void setbutton(bool b)
        {
            cmdCapnhat.Enabled = b;
            cmdthem.Enabled = b;
            cmdthoat.Enabled = b;
            cmdxoa.Enabled = b;
            cmdluu.Enabled = !b;
        }
        public void settextbox(bool b)
        {
            txtmato.ReadOnly = b;
            txttento.ReadOnly = b;
            cbomaphong.Enabled = !b;
        }

        private void frmDMTo_Load(object sender, EventArgs e)
        {
            settextbox(true);
            setbutton(true);
        }

        private void cmdthem_Click(object sender, EventArgs e)
        {
            settextbox(false);
            setbutton(false);
            txtmato.Focus();
            txtmato.Text = "";
            txttento.Text = "";
            
            k = 1;
        }

        private void cmdCapnhat_Click(object sender, EventArgs e)
        {
            if (dgv_DMTO.SelectedRows.Count == 0)
                RadMessageBox.Show("\nBạn phải chọn dòng để cập nhật !\n", "Thông báo");
            else
            {
                settextbox(false);
                txttento.Focus();
                setbutton(false);
                k = 2;
            }
        }

        private void cmdxoa_Click(object sender, EventArgs e)
        {
            if (dgv_DMTO.SelectedRows.Count == 0)
            {
                RadMessageBox.Show("\nBạn phải chọn dòng để xóa !\n", "Thông báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                return;
            }
            else
            {
                DialogResult rs = RadMessageBox.Show("\nBạn thật sự muốn xóa thông tin này không ?\n", "Thông báo", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    c.xoa("tbl_danhmucto", txtmato.Text.Trim(), "mato",3);
                    c.laydldmto();
                    
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
                    if (txtmato.Text == "" || txttento.Text == "")
                    {
                        RadMessageBox.Show(this, "\nBạn phải nhập đầy đủ thông tin vào !\n", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        c.them("tbl_DanhMucTo", txtmato.Text.Trim(),
                            cbomaphong.SelectedValue.ToString().Trim(),
                            txttento.Text.Trim());

                    }
                }
                else if (k == 2)
                {
                    if (txtmato.Text == "" || txttento.Text == "")
                    {
                        RadMessageBox.Show(this, "\nBạn phải nhập đầy đủ thông tin vào !\n", "Thông báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        c.suato("tbl_DanhMucTo", txtmato.Text.Trim(),
                            cbomaphong.SelectedValue.ToString().Trim(), txttento.Text.Trim(),
                            "mato", "maphong", "tento");
                    }
                }
            }
            c.laydldmto();
            settextbox(true);
            setbutton(true);
            k = 0;
        }

        private void cmdthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}