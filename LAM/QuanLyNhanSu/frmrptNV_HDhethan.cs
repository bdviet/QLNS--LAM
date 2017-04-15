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
using CrystalDecisions.Shared;
namespace QuanLyNhanSu
{
    public partial class frmrptNV_HDhethan : RadForm
    {
        clschitiethopdong chopdong = new clschitiethopdong();
        public frmrptNV_HDhethan()
        {
            
            InitializeComponent();
            rptHopDongHetHan r = new rptHopDongHetHan();
            r.SetDataSource(chopdong.layNV_HDhethan(frmKiemTraHDHetHan.dk));
            


            this.rvNV_HDhethan.ReportSource = r;
        }

        private void rvNV_HDhethan_Load(object sender, EventArgs e)
        {

        }
    }
}
