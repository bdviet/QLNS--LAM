using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Telerik.Data;
using Telerik.WinControls.UI;
using QuanLyNhanSu.Class;
using Telerik.WinControls;


namespace QuanLyNhanSu
{
    public partial class frmbangtileluong : RadForm
    {
       //khai báo biến toàn cục
        clsTiLeLuong ctileluong = new clsTiLeLuong();
        clsdmpb cPhong = new clsdmpb();
        clsDMTo cTo = new clsDMTo();
        int k = 0;
        public frmbangtileluong()
        {
            InitializeComponent();
            ctileluong.laydl();
            for (int i = 1; i <= 12; i++)
            {
                cbothang.Items.Add(i);
            }
            for (int i = 2008; i <= 2100; i++)
            {
                cbonam.Items.Add(i);
            }
            cboPhong.DataSource = cPhong.taocombo();
            cboPhong.DisplayMember = "tbl_PhongBan.TenPhong";
            cboPhong.ValueMember = "tbl_PhongBan.MaPhong";

            dgv_TiLeLuong.DataSource = ctileluong.ds;
            dgv_TiLeLuong.DataMember = "TiLeLuong";
            dgv_TiLeLuong.Columns[0].IsVisible = false;
            dgv_TiLeLuong.Columns[1].IsVisible = false;
            dgv_TiLeLuong.Columns[2].HeaderText = "Tháng";
            dgv_TiLeLuong.Columns[3].HeaderText = "Năm";
            dgv_TiLeLuong.Columns[4].HeaderText = "Phòng";
            dgv_TiLeLuong.Columns[5].HeaderText = "Tổ";
            dgv_TiLeLuong.Columns[6].HeaderText = "Tỷ lệ lương";
            dgv_TiLeLuong.Columns[7].HeaderText = "Số ngày công";


        }
        

        private void frmbangtileluong_Load(object sender, EventArgs e)
        {
            setcmd(true);
            setcontrol(false);
            HienThiDL();
        }
        //set bộ nút 
        private void setcmd(bool b)
        {
            cmdCapnhat.Enabled = b;
            cmdluu.Enabled = !b;
            cmdthoat.Enabled = b;
            cmdthem.Enabled = b;
            cmdxoa.Enabled = b;
        }
        // set control
        private void setcontrol(bool b)
        {
            foreach (Control c in pnlthongtin.Controls)
            {
                if (c.Name.Contains("txt")==true  ||c.Name.Contains("cbo")==true )
                c.Enabled = b;
            }
        }
        //
        private void HienThiDL()
        {

            if (dgv_TiLeLuong.CurrentRow!=null)
            {


                cbothang.Text = dgv_TiLeLuong.CurrentRow.Cells["thang"].Value.ToString();
                cbonam.Text = dgv_TiLeLuong.CurrentRow.Cells["nam"].Value.ToString();
                cboPhong.Text = dgv_TiLeLuong.CurrentRow.Cells["tenphong"].Value.ToString();
                cboto.Text = dgv_TiLeLuong.CurrentRow.Cells["tento"].Value.ToString();
                txttll.Text = dgv_TiLeLuong.CurrentRow.Cells["tileluong"].Value.ToString();
                txtsongaycong.Text = dgv_TiLeLuong.CurrentRow.Cells["songaycongthang"].Value.ToString();
            }
        }

        private void cmdthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboto.DataSource = cTo.taocombo(cboPhong.SelectedValue.ToString());
            cboto.DisplayMember = "DanhMucTo.TenTo";
            cboto.ValueMember = "DanhMucTo.MaTo";
            cboto.Text = "";
        }

        private void cmdthem_Click(object sender, EventArgs e)
        {
            setcmd(false);
            setcontrol(true);
            txttll.Text = "";
            txtsongaycong.Text = "";
            k = 1;
        }

        private void cmdCapnhat_Click(object sender, EventArgs e)
        {
            if (dgv_TiLeLuong.SelectedRows.Count == 0)
            {
                RadMessageBox.Show("\nBạn phải chọn dòng để cập nhật !\n", "Thông Báo", MessageBoxButtons.OK, RadMessageIcon.Question);
                return;
            }
            else
            {

                setcmd(false);
                txttll.Enabled = true;
                txtsongaycong.Enabled = true;
                txttll.Focus();
                k = 2;
            }
        }

        private void dgv_TiLeLuong_Click(object sender, EventArgs e)
        {
            //HienThiDL(dgv_TiLeLuong.CurrentRow);
        }

        private void cmdxoa_Click(object sender, EventArgs e)
        {
            if (dgv_TiLeLuong.SelectedRows.Count == 0)
            {
                RadMessageBox.Show("\nBạn phải chọn dòng để xóa !\n", "Thông Báo",MessageBoxButtons.OK, RadMessageIcon.Question);
                return;
            }
            else
            {
                DialogResult rs = RadMessageBox.Show("\nBạn muốn xóa ? \n", "Thông Báo", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    ctileluong.xoa(dgv_TiLeLuong.CurrentRow.Cells["id"].Value.ToString());
                    ctileluong.laydl();
                }
            }
        }

        private void cmdluu_Click(object sender, EventArgs e)
        {
            DialogResult rs = RadMessageBox.Show("Bạn muốn lưu lai không?","Thông báo",MessageBoxButtons.YesNo,RadMessageIcon.Question );
            if (rs == DialogResult.Yes)
            {
                if (k == 1)
                    if (cboto.SelectedItem != null)
                    {
                        ctileluong.them(int.Parse(cbothang.Text.Trim()),
                                        int.Parse(cbonam.Text.Trim()),
                                        cboPhong.SelectedValue.ToString().Trim(),
                                        cboto.SelectedValue.ToString().Trim(),
                                        txttll.Text != "" ? double.Parse(txttll.Text.Trim()) : 1,
                                        txtsongaycong.Text != "" ? int.Parse(txtsongaycong.Text.Trim()) : 26);
                    }
                    else
                    {
                        ctileluong.them(int.Parse(cbothang.Text.Trim()),
                                        int.Parse(cbonam.Text.Trim()),
                                        cboPhong.SelectedValue.ToString().Trim(),
                                        txttll.Text != "" ? double.Parse(txttll.Text.Trim()) : 1,
                                        txtsongaycong.Text != "" ? int.Parse(txtsongaycong.Text.Trim()) : 26);
                    }
                else
                    if (k == 2)
                    {
                        ctileluong.sua(dgv_TiLeLuong.CurrentRow.Cells["id"].Value.ToString(),
                            txttll.Text != "" ? double.Parse(txttll.Text.Trim()) : 1,
                            txtsongaycong.Text != "" ? int.Parse(txtsongaycong.Text.Trim()) : 26);
                    }
            }
            k = 0;
            setcontrol(false);
            setcmd(true);
            ctileluong.laydl();   
        }



 

        
    
    }
}
