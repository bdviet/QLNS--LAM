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
    public partial class frmkiemtrabangluong : RadForm
    {
       //khai báo biến toàn cục
        public SqlConnection sc = frmMain.me.sql.connectSQL();
        public SqlDataAdapter sda = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        clsbangluong cbangluong = new clsbangluong();
        public static string thangkt, namkt;
        public frmkiemtrabangluong()
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
        }

        private bool kiemtra(string thang, string nam)
        {
            ds.Clear();
            string sel = "select * from tbl_BangLuong where thang ='" + thang
                          + "' and nam ='" + nam + "'";
            sc.Open();
            SqlCommand scmd = new SqlCommand(sel, sc);
            object o = scmd.ExecuteScalar();
            sc.Close();
            if (o != null)
                return true ;
            else
                return false ;  
        }

        private DataTable danhsachNVchamcong(string thang, string nam)
        {
            string kthd = "select distinct manv from tbl_chitiethopdong"+
                          " where ngayketthuc >='"+thang+"/01/"+nam+"'";
            sc.Open();
            SqlCommand scmd = new SqlCommand(kthd, sc);
            sda.SelectCommand = scmd;
            sda.Fill(ds,"NV_hopdong");
            sc.Close();
            return ds.Tables["NV_hopdong"];
        }

        private void cmdkiemtra_Click(object sender, EventArgs e)
        {
            thangkt = cbothangkt.Text.Trim();
            namkt = cbonamkt.Text.Trim();
            if(kiemtra(cbothangkt.Text.Trim(),cbonamkt.Text.Trim())== true)
            {
                frmbangluong f = new frmbangluong();
                f.MdiParent = this.MdiParent;
                f.Show();
                Close();
            }
            else
            {
                DialogResult rs = MessageBox.Show("Không có dữ liệu bảng lương này!!! \n Bạn có muốn tạo bảng lương này", "Thông báo", MessageBoxButtons.YesNo);
                if(rs == DialogResult.Yes )
                {
                    DataTable dt = danhsachNVchamcong(cbothangkt.Text.Trim(),cbonamkt.Text.Trim());
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        cbangluong.them(dt.Rows[i]["manv"].ToString(), cbothangkt.Text.Trim(), cbonamkt.Text.Trim());
                    }
                    Close();
                    frmbangluong f = new frmbangluong();
                    f.MdiParent = this.MdiParent;
                    f.Show();
                }
                
            }
        }

        private void cmdthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
