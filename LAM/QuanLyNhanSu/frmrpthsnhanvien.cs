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
    public partial class frmrpthsnhanvien : RadForm
    {
        clsnhanvien cnhanvien = new clsnhanvien();
        public frmrpthsnhanvien()
        {           
            InitializeComponent();
            //rptHsNhanVien r = new rptHsNhanVien();
            rpthsnhanvien1 r = new rpthsnhanvien1();
            r.SetDataSource(cnhanvien.laydl1(frmNhanvien.bienmanv));
            this.rpthsnhanvien.ReportSource= r;           
        }
    }
}
