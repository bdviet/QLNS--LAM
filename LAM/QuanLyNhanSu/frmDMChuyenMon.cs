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
    public partial class frmDMChuyenMon : RadForm
    {
        //khai báo biến toàn cục
        clsdmchuyenmon c = new clsdmchuyenmon();
        int k = 0;
        public frmDMChuyenMon()
        {
            InitializeComponent();
            c.laydl("tbl_DMChuyenMon");
            //lấy dữ liệu ra textbox
            txtmaCM.DataBindings.Add("text", c.ds, "tbl_DMChuyenMon.MaChuyenMon");
            txttenCM.DataBindings.Add("text", c.ds, "tbl_DMChuyenMon.TenChuyenMon");
            dgv_DMchuyenmon.DataSource = c.ds;
            dgv_DMchuyenmon.DataMember = "tbl_DMChuyenMon";
            dgv_DMchuyenmon.Columns[0].HeaderText = "Mã";
            dgv_DMchuyenmon.Columns[1].HeaderText = "Tên chuyên môn";
        }
        
        public void setbutton(bool b)
        {
            cmdcapnhat.Enabled = b;
            cmdthem.Enabled = b;
            cmdthoat.Enabled = b;
            cmdxoa.Enabled = b;
            cmdluu.Enabled = !b;
        }
        private void frmDMChuyenMon_Load(object sender, EventArgs e)
        {
            setbutton(true);
        }

        private void cmdthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtmaCM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                RadMessageBox.Show("\nBạn phải nhập số", "Thông báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
            }
        }

        private void cmdthem_Click(object sender, EventArgs e)
        {
            txtmaCM.Text = "";
            txttenCM.Text = "";
            txtmaCM.ReadOnly = false;
            txttenCM.ReadOnly = false;
            txtmaCM.Focus();
            setbutton(false);
            k = 1;
        }

        private void cmdxoa_Click(object sender, EventArgs e)
        {
            if (dgv_DMchuyenmon.SelectedRows.Count == 0)
            {
                RadMessageBox.Show("\nBạn phải chọn dòng để xóa !\n", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                return;
            }
            else
            {
                DialogResult rs = RadMessageBox.Show("\nBạn thật sự muốn xóa thông tin này không ?\n", "Thông Báo", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    c.xoa("tbl_DMChuyenMon", int.Parse(txtmaCM.Text.Trim()), "MaChuyenMon");
                    c.laydl("tbl_DMChuyenMon");
                   
                }
            }
        }

        private void cmdcapnhat_Click(object sender, EventArgs e)
        {
            if (dgv_DMchuyenmon.SelectedRows.Count == 0)
            {
                RadMessageBox.Show("\nBạn phải chọn dòng để cập nhật !\n", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                return;
            }
            else
            {
                txttenCM.ReadOnly = false;
                txttenCM.Focus();
                setbutton(false);
                k = 2;
            }
        }

        private void cmdluu_Click(object sender, EventArgs e)
        {
            DialogResult rs = RadMessageBox.Show("\nBạn thật muốn lưu thông tin này không ?\n", "Thông Báo", MessageBoxButtons.YesNo, RadMessageIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (k == 1)
                {
                    if (txtmaCM.Text == "" || txttenCM.Text == "")
                    {
                        RadMessageBox.Show(this, "\nBạn phải nhập đầy đủ thông tin vào !\n", "Thông báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                    }
                    else
                    {
                        //them moi
                        c.them("tbl_dmchuyenmon", int.Parse(txtmaCM.Text.Trim()), txttenCM.Text.Trim());
                        c.laydl("tbl_DMChuyenMon");
                        txtmaCM.ReadOnly = true;
                        txttenCM.ReadOnly = true;
                        k = 0;
                        setbutton(true);
                    }


                }
                else if (k == 2)              
                    if (txtmaCM.Text == "" || txttenCM.Text == "")
                    {
                        RadMessageBox.Show(this, "\nBạn phải nhập đầy đủ thông tin vào !\n", "Thông báo", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                    }
                    else                    
                        //update
                        c.sua("tbl_DMChuyenMon", int.Parse(txtmaCM.Text.Trim()), txttenCM.Text.Trim(),
                            "machuyenmon", "tenchuyenmon");
            }
                    c.laydl("tbl_DMChuyenMon");
                    txttenCM.ReadOnly = true;
                    setbutton(true);                   
                    k = 0;
            }
        }
    }