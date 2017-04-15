using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace QuanLyNhanSu
{
    public partial class frmtracuutt : RadForm
    {
        public frmtracuutt()
        {
            InitializeComponent();
        }

        private void frmQTBienDong_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private Form KiemTraTonTai(Type formType)
        {
            foreach (Form f in this.MdiParent.MdiChildren )
            {
                if (f.GetType() == formType)
                    return f;
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (opthd.Checked == true)
            {
                Form frm = KiemTraTonTai(typeof(frmtracuutthopdong));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmtracuutthopdong f = new frmtracuutthopdong();
                    f.MdiParent = this.MdiParent;
                    f.Show();
                }
            }
            else if (opttd.Checked == true)
            {
                Form frm = KiemTraTonTai(typeof(frmtracuutrinhdo));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmtracuutrinhdo f = new frmtracuutrinhdo();
                    f.MdiParent = this.MdiParent;
                    f.Show();
                }
            }
        }  
    }
}