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
using QuanLyNhanSu.Class;
namespace QuanLyNhanSu
{
    public partial class frmDoiMatKhau : RadForm
    {
        clsUser cUser = new clsUser();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void txtmkcu_Validated(object sender, EventArgs e)
        {
            if (cUser.KiemTraHopLe(frmMain.me.sql.GetUser(), txtmkcu.Text.Trim()) == false)
            {
                RadMessageBox.Show("\nMật khẩu không hợp lệ !\n", "Thông báo",MessageBoxButtons.OK,RadMessageIcon.Error);
                txtmkcu.Text = "";
                this.picNotValidMK.Visible=true;
                this.picValidMK.Visible=false;
            }
            else
            {
                this.picNotValidMK.Visible=false;
                this.picValidMK.Visible=true;
            }
        }

        private void txtmkmoi2_Validated(object sender, EventArgs e)
        {
            if (txtmkmoi.Text.Trim() != txtmkmoi2.Text.Trim())
            {
                RadMessageBox.Show("\nMật khẩu mới không trùng khớp !\n", "Thông báo", MessageBoxButtons.OK, RadMessageIcon.Error);
                txtmkmoi2.Text = "";
                txtmkmoi2.Focus();
                this.picNotValidMKMoi2.Visible = true;
                this.picNotValidMKMoi.Visible = true;

                           
                this.picValidMKMoi2.Visible = false;
                this.picValidMKMoi.Visible = false;
            }
            else
            {
                this.picValidMKMoi2.Visible = true;
                this.picValidMKMoi.Visible = true;

                this.picNotValidMKMoi2.Visible = false;
                this.picNotValidMKMoi.Visible = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult rs = RadMessageBox.Show("\nBạn muốn lưu mật khẩu mới ?\n", "Thông báo", MessageBoxButtons.YesNo,RadMessageIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (txtmkmoi.Text.Trim() != txtmkmoi2.Text.Trim())
                {
                    RadMessageBox.Show("\nMật khẩu mới không trùng khớp !\n", "Thông báo", MessageBoxButtons.OK, RadMessageIcon.Error);
                    txtmkmoi2.Text = "";
                    txtmkmoi2.Focus();
                    this.picNotValidMKMoi2.Visible = true;
                    this.picNotValidMKMoi.Visible = true;


                    this.picValidMKMoi2.Visible = false;
                    this.picValidMKMoi.Visible = false;

                }
                else
                {
                    this.picValidMKMoi2.Visible = true;
                    this.picValidMKMoi.Visible = true;

                    this.picNotValidMKMoi2.Visible = false;
                    this.picNotValidMKMoi.Visible = false;
                    string sqlupd = "Update tbl_User set pass='" + txtmkmoi2.Text.Trim() + "' where id='" + frmMain.me.sql.GetUser() + "'";
                    cUser.sc.Open();
                    SqlCommand cmdupd = new SqlCommand(sqlupd, cUser.sc);
                    try
                    {
                        cmdupd.ExecuteNonQuery();
                        RadMessageBox.Show("\nCập nhật thành công !\n", "Thông báo",MessageBoxButtons.OK,RadMessageIcon.Exclamation);
                    }
                    catch (SqlException ex)
                    {
                        RadMessageBox.Show("" + ex.Errors + " " + ex.Number);
                    }
                    cUser.sc.Close();
                }
            }
        }

        private void txtmkmoi_TextChanged(object sender, EventArgs e)
        {
            txtmkmoi2.Text = "";
        }

        private void txtmkmoi2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
