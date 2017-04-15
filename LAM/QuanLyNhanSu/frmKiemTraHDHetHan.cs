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
    public partial class frmKiemTraHDHetHan : RadForm
    {
        clschitiethopdong chopdong = new clschitiethopdong();
        static public string dk = "";
        public static frmKiemTraHDHetHan me;

        public frmKiemTraHDHetHan()
        {
            InitializeComponent();
            for (int i = 1; i <= 12; i++)
            {
                cbothangkt.Items.Add(i);
            }
            for (int i = 2008; i <= 2100; i++)
            {
                cbonamkt.Items.Add(i);
            }
            me = this;
        }

        private void cbonamkt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdxem_Click(object sender, EventArgs e)
        {

            if (cbothangkt.Text == "" || cbonamkt.Text == "")
                RadMessageBox.Show("\nBạn phải chọn tháng và năm !\n", "Thông báo",MessageBoxButtons.OK,RadMessageIcon.Error);
            else
            {
                if (cbothangkt.Text.Trim() == "12")
                {
                    dk = " ngaykt <='12/31/" + int.Parse(cbonamkt.Text.Trim()) + "'";
                    dgv_NV_HopDong.DataSource = chopdong.layNV_HDhethan(dk);
                    dgv_NV_HopDong.Columns[0].HeaderText = "Mã NV";
                    dgv_NV_HopDong.Columns[1].HeaderText = "Số HĐ";
                    dgv_NV_HopDong.Columns[2].HeaderText = "Ngày KT";
                    dgv_NV_HopDong.Columns[3].HeaderText = "Họ";
                    dgv_NV_HopDong.Columns[4].HeaderText = "Tên";
                    dgv_NV_HopDong.Columns[5].HeaderText = "Phòng";
                    dgv_NV_HopDong.Columns[6].HeaderText = "Tổ";
                    dgv_NV_HopDong.Columns[1].IsVisible = false;
                    
                }
                else
                {
                    dk = " ngaykt <='" + (int.Parse(cbothangkt.Text.Trim()) + 1) + "/1/" + int.Parse(cbonamkt.Text.Trim()) + "'";
                    dgv_NV_HopDong.DataSource = chopdong.layNV_HDhethan(dk);
                    dgv_NV_HopDong.Columns[0].HeaderText = "Mã NV";
                    dgv_NV_HopDong.Columns[1].HeaderText = "Số HĐ";
                    dgv_NV_HopDong.Columns[2].HeaderText = "Ngày KT";
                    dgv_NV_HopDong.Columns[3].HeaderText = "Họ";
                    dgv_NV_HopDong.Columns[4].HeaderText = "Tên";
                    dgv_NV_HopDong.Columns[5].HeaderText = "Phòng";
                    dgv_NV_HopDong.Columns[6].HeaderText = "Tổ";
                    dgv_NV_HopDong.Columns[1].IsVisible = false;

                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (dk != "")
            {
                frmrptNV_HDhethan f = new frmrptNV_HDhethan();
                f.MdiParent = this.ParentForm;
                f.Show();
            }
            else
                RadMessageBox.Show("\nKhông có dữ liệu !\n", "Thông báo",MessageBoxButtons.OK,RadMessageIcon.Error);

        }

        private void frmKiemTraHDHetHan_Load(object sender, EventArgs e)
        {

        }
    }
}
