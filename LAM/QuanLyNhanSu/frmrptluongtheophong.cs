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
using Telerik.Data;


namespace QuanLyNhanSu
{
    public partial class frmrptluongtheophong : RadForm
    {
        clsbangluong cluong = new clsbangluong();
        public frmrptluongtheophong()
        {
            InitializeComponent();
            if (frmchonbcluong.mato == "")
            {
                rptluongtheophong r = new rptluongtheophong();
                r.SetDataSource(cluong.laydlgird(frmchonbcluong.thangbc, frmchonbcluong.nambc, frmchonbcluong.maphong));
                this.rptluongnhanvien.ReportSource = r;
            }
            else
            {
                rptluongtheoto r = new rptluongtheoto();
                r.SetDataSource(cluong.laydlgird(frmchonbcluong.thangbc, frmchonbcluong.nambc, frmchonbcluong.maphong, frmchonbcluong.mato));
                this.rptluongnhanvien.ReportSource = r;
            }
        }
    }
}
