using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyNhanSu.Class;
using Telerik.WinControls;


namespace QuanLyNhanSu
{
    public partial class frmtracuutrinhdo : RadForm
    {
        //khai báo biến toàn cục
        clsdmchuyenmon cdmcm = new clsdmchuyenmon();
        clsdmtrinhdo cdmtd = new clsdmtrinhdo();
        clsdmngoaingu cdmnn = new clsdmngoaingu();
        clstimtttrinhdo c = new clstimtttrinhdo();
        clstimngoaingu cnn = new clstimngoaingu();
        static public string dk = "";
        public frmtracuutrinhdo()
        {
            InitializeComponent();
            cbodmcm.DataSource = cdmcm.taocombocm();
            cbodmcm.DisplayMember = "TenChuyenMon";
            cbodmcm.ValueMember = "MaChuyenMon";
            cbodmnn.DataSource = cdmnn.taocombonn();
            cbodmnn.DisplayMember = "TenNgoaiNgu";
            cbodmnn.ValueMember = "MaNgoaiNgu";
            cbodmtd.DataSource = cdmtd.taocombotd();
            cbodmtd.DisplayMember = "TenTrinhDo";
            cbodmtd.ValueMember = "MaTrinhDo";
            dgv_TCTD1.DataSource = c.laydl();
            dgv_TCTD1.DataMember = "TC_TrinhDo";
            dgv_NV_NN.DataSource = cnn.laydl();
            dgv_NV_NN.DataMember = "TC_NN";
            

        }

        private void frmtracuutrinhdo_Load(object sender, EventArgs e)
        {
            dk = "";
        }

        private void cmdtim_Click(object sender, EventArgs e)
        {
            dk ="";
            if (cbodmcm.SelectedItem != null)
                dk = dk + " machuyenmon like " + int.Parse(cbodmcm.SelectedValue.ToString());
            if(cbodmtd.SelectedItem != null)
                dk = dk +" and matrinhdo like "+ int.Parse(cbodmtd.SelectedValue.ToString());
            if (txttruongcap.Text != "")
                dk = dk + " and truong like N'" + txttruongcap.Text.Trim() + "%'";
            if (dk == "")
            {
                dgv_TCTD1.DataSource = c.laydl();
                dgv_TCTD1.DataMember = "TC_TrinhDo";
            }
            else
            {
                if (dk.Substring(0, 4) == " and")
                    dk = dk.Substring(5);
                dgv_TCTD1.DataSource = c.laydl(dk);
                dgv_TCTD1.DataMember = "TC_TrinhDo";
            }
        }

        private void cmdnntim_Click(object sender, EventArgs e)
        {
            string dk = "";
            if (cbodmnn.SelectedItem!= null)
                dk = dk + " mangoaingu like " + int.Parse(cbodmnn.SelectedValue.ToString()) ;
            if (txttrinhdo .Text != "")
                dk = dk + " and trinhdo like N'" + txttrinhdo.Text.Trim()+"%'";
            if (txtnoicap.Text != "")
                dk = dk + " and noicap like N'" + txtnoicap.Text.Trim() + "%'";
            if (dk == "")
            {
                dgv_NV_NN.DataSource = cnn.laydl();
                dgv_NV_NN.DataMember = "TC_NN";
            }
            else
            {
                if (dk.Substring(0, 4) == " and")
                    dk = dk.Substring(5);
                dgv_NV_NN.DataSource = cnn.laydl(dk);
                dgv_NV_NN.DataMember = "TC_NN";
            }
        }


        
    }
}