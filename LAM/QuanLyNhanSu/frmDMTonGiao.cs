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
    public partial class frmDMTonGiao : RadForm
    {
        clsdmtongiao c = new clsdmtongiao();
        int k = 0;
        public frmDMTonGiao()
        {
            InitializeComponent();
            c.laydl("tbl_DMTonGiao");
            txtmatg.DataBindings.Add("text", c.ds, "tbl_DMTonGiao.MaTG");
            txttentg.DataBindings.Add("text", c.ds, "tbl_DMTonGiao.TenTG");
            dgv_DMTG.DataSource = c.ds;
            dgv_DMTG.DataMember = "tbl_DMTonGiao";

            dgv_DMTG.Columns[0].HeaderText = "Mã tôn giáo";
            dgv_DMTG.Columns[1].HeaderText = "Tên tôn giáo";
        }
        public void setbutton(bool b)
        {
            cmdCapnhat.Enabled = b;
            cmdthem.Enabled = b;
            cmdthoat.Enabled = b;
            cmdxoa.Enabled = b;
            cmdluu.Enabled = !b;
        }

        private void frmDMTonGiao_Load(object sender, EventArgs e)
        {
            setbutton(true);
        }

        private void cmdthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtmatg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                RadMessageBox.Show("\nBạn phải nhập số !\n", "Thông báo",MessageBoxButtons.OK,RadMessageIcon.Error);
                txtmatg.Text = "";
                txtmatg.Focus();
            }
        }

        private void cmdxoa_Click(object sender, EventArgs e)
        {
            if (dgv_DMTG.SelectedRows.Count == 0)
            {
                RadMessageBox.Show("\nBạn phải chọn dòng để xóa !\n", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
            else
            {
                DialogResult rs = RadMessageBox.Show("\nBạn thật sự muốn xóa thông tin này !?\n", "Thông Báo", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    c.xoa("tbl_DMTonGiao", int.Parse(txtmatg.Text.Trim()), "MaTG");
                    c.laydl("tbl_DMTonGiao");
                    
                }
            }
        }

        private void cmdthem_Click(object sender, EventArgs e)
        {
            txtmatg.Text = "";
            txttentg.Text = "";
            txtmatg.ReadOnly = false;
            txttentg.ReadOnly = false;
            txtmatg.Focus();
            setbutton(false);
            k = 1;
        }

        private void cmdCapnhat_Click(object sender, EventArgs e)
        {
            if (dgv_DMTG.SelectedRows.Count == 0)
            {
                RadMessageBox.Show("\nBạn phải chọn dòng để cập nhật !\n", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
            else
            {
                txttentg.ReadOnly = false;
                txttentg.Focus();
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
                    if (txtmatg.Text == "" || txttentg.Text == "")
                    {
                        RadMessageBox.Show(this, "\nBạn phải nhập đầy đủ thông tin vào !\n", "Thông báo", MessageBoxButtons.OK, RadMessageIcon.Error);
                        return;
                    }
                    else
                    {   //thêm mẩu tin mới vào datagirdview
                        c.them("tbl_dmTonGiao", int.Parse(txtmatg.Text.Trim())
                            , txttentg.Text.Trim());                        
                    }
                }
                else if (k == 2)
                {
                    if (txtmatg.Text == "" || txttentg.Text == "")
                    {
                        RadMessageBox.Show(this, "\nBạn phải nhập đầy đủ thông tin vào !\n", "Thông báo", MessageBoxButtons.OK, RadMessageIcon.Error);
                        return;
                    }
                    else
                    {
                        //cập nhật mẩu tin
                        c.sua("tbl_DMTonGiao", int.Parse(txtmatg.Text.Trim()),
                            txttentg.Text.Trim(), "MaTG", "tenTG");
                    }
                }
            }
            //load lại dữ liệu
            c.laydl("tbl_DMTonGiao");
            txtmatg.ReadOnly = true;
            txttentg.ReadOnly = true;
            k = 0;
            setbutton(true);
        }
    }
}
        