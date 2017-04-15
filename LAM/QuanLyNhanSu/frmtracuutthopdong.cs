using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using QuanLyNhanSu.Class;

namespace QuanLyNhanSu
{
    public partial class frmtracuutthopdong : RadForm
    {
        //khai báo biến toàn cục
        clsdmhd chd = new clsdmhd();
        clstkhopdong c = new clstkhopdong();
        string dk = "";
        public frmtracuutthopdong()
        {
            InitializeComponent();
            cboloaihd.DataSource = chd.taocombohd();
            cboloaihd.DisplayMember = "TenLoaiHD";
            cboloaihd.ValueMember = "MaLoaiHD";
            dgv_NV_HopDong.DataSource = c.laydl();
            dgv_NV_HopDong.DataMember = "TC_HD";
            cbodau.Items.AddRange(new string[] { "<", "<=", "=", ">", ">=" });
            cbodauthangky.Items.AddRange(new string[] { "<", "<=", "=", ">", ">=" });
            cbodauthangkt.Items.AddRange(new string[] { "<", "<=", "=", ">", ">=" });
        }      
        private void cmdtim_Click(object sender, EventArgs e)
        {
            dk = "";
            if (txtho.Text != "")
            {
                dk = dk + " ho like N'" + txtho.Text.Trim() + "%'";
            }
            if (txtten.Text != "")
            {
                dk = dk + " and ten like N'" + txtten.Text.Trim() + "%'";
            }
            if (txtluongcb.Text != "")
            {
                dk = dk + " and luongcoban  " + cbodau.Text.Trim() + int.Parse(txtluongcb.Text.Trim());
            }
            if (txtthangky.Text != "" || txtnamky.Text != "")
            {

                if (cbodauthangky.Text.Trim() == ">")
                    if (txtthangky.Text.Trim() == "12")
                    {
                        dk = dk + " and ngayky >= '" +"1/1/"+(int.Parse(txtnamky.Text.Trim())+1) + "'";
                    }
                    else
                    {
                        dk = dk + " and ngayky >= '"+(int.Parse(txtthangky.Text.Trim()) + 1) + "/1/" +
                                          int.Parse(txtnamky.Text.Trim()) + "'";
                    }
                if(cbodauthangky.Text.Trim() == "<=")
                    dk = dk + " and ngayky < '" +
                                           (int.Parse(txtthangky.Text.Trim())+1)+ "/1/" +
                                           int.Parse(txtnamky.Text.Trim()) + "'";
                if(cbodauthangky.Text.Trim() == ">=")
                    dk = dk + " and ngayky" + cbodauthangky.Text.Trim() + "'" +
                                           int.Parse(txtthangky.Text.Trim()) + "/1/" +
                                           int.Parse(txtnamky.Text.Trim()) + "'";
                if(cbodauthangky.Text.Trim() == "<")
                    if (txtthangky.Text.Trim() == "1")
                    {
                        dk = dk + " and ngayky <= '" + "12/31/" +(int.Parse(txtnamky.Text.Trim())- 1) + "'";
                    }
                    else
                    {
                        dk = dk + " and ngayky < '" + int.Parse(txtthangky.Text.Trim()) + "/1/" +
                                          int.Parse(txtnamky.Text.Trim()) + "'";
                    }
                if (cbodauthangky.Text.Trim() == "=")
                    dk = dk + " and thangky =" + txtthangky.Text.Trim() + "and namky =" + txtnamky.Text.Trim();
            }
            if (txtthangkt.Text != "" || txtnamkt.Text!= "")            
            {
                if (cbodauthangkt.Text.Trim() == ">")
                    if (txtthangkt.Text.Trim() == "12")
                    {
                        dk = dk + " and ngayketthuc >= '" + "1/1/" + (int.Parse(txtnamkt.Text.Trim()) + 1) + "'";
                    }
                    else
                    {
                        dk = dk + " and ngayketthuc >= '" + (int.Parse(txtthangkt.Text.Trim()) + 1) + "/1/" +
                                          int.Parse(txtnamkt.Text.Trim()) + "'";
                    }
                if (cbodauthangkt.Text.Trim() == "<=")
                    dk = dk + " and ngayketthuc < '" +
                                           (int.Parse(txtthangkt.Text.Trim()) + 1) + "/1/" +
                                           int.Parse(txtnamkt.Text.Trim()) + "'";
                if (cbodauthangkt.Text.Trim() == ">=")
                    dk = dk + " and ngayketthuc" + cbodauthangkt.Text.Trim() + "'" +
                                           int.Parse(txtthangkt.Text.Trim()) + "/1/" +
                                           int.Parse(txtnamkt.Text.Trim()) + "'";
                if (cbodauthangkt.Text.Trim() == "<")
                    if (txtthangkt.Text.Trim() == "1")
                    {
                        dk = dk + " and ngayketthuc <= '" + "12/31/" + (int.Parse(txtnamkt.Text.Trim()) - 1) + "'";
                    }
                    else
                    {
                        dk = dk + " and ngayketthuc < '" + int.Parse(txtthangkt.Text.Trim()) + "/1/" +
                                          int.Parse(txtnamkt.Text.Trim()) + "'";
                    }
                if (cbodauthangkt.Text.Trim() == "=")
                    dk = dk + " and thangkt =" + txtthangkt.Text.Trim() + "and namkt =" + txtnamkt.Text.Trim();

            }
            if (cboloaihd.SelectedItem != null)
            {
                dk = dk + " and maloaihd = " + int.Parse(cboloaihd.SelectedValue.ToString());
            }
            if (dk == "")
            {
                dgv_NV_HopDong.DataSource = c.laydl();
                dgv_NV_HopDong.DataMember = "TC_HD";
            }
            else
            {
                if (dk.Substring(0, 4) == " and")
                    dk = dk.Substring(5);
                dgv_NV_HopDong.DataSource = c.laydl(dk);
                dgv_NV_HopDong.DataMember = "TC_HD";
            }
        }
        //
        //kiểm tra nhập số vào các textbox
        //
        private void txtthangky_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("bạn phải nhập số", "Thông báo");
            }       
        }

        private void txtnamky_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("bạn phải nhập số", "Thông báo");
            }       
        }

        private void txtthangkt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("bạn phải nhập số", "Thông báo");
            }       
        }
        private void txtnamkt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("bạn phải nhập số", "Thông báo");
            }       
        }

        private void txtluongcb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("bạn phải nhập số", "Thông báo");
            }       
        }

        private void frmtracuutthopdong_Load(object sender, EventArgs e)
        {
            dk = "";
        }    
    }
}