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
using QuanLyNhanSu;
using Telerik.Data;

namespace QuanLyNhanSu
{
    public partial class frmrptbcbh : RadForm
    {
        public frmrptbcbh()
        {
            InitializeComponent();
            InitializeComponent();
            rptbcbaohiem r = new rptbcbaohiem();
            r.SetDataSource(frmchonbcluong.bcbaohiem(frmchonbcluong.thangbh, frmchonbcluong.nambh));
            
            this.rptbcbaohiem.ReportSource = r;
        }
    }
}
