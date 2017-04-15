namespace QuanLyNhanSu
{
    partial class frmrptluongtheophong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rptluongnhanvien = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rptluongnhanvien
            // 
            this.rptluongnhanvien.ActiveViewIndex = -1;
            this.rptluongnhanvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptluongnhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptluongnhanvien.Location = new System.Drawing.Point(0, 0);
            this.rptluongnhanvien.Name = "rptluongnhanvien";
            this.rptluongnhanvien.SelectionFormula = "";
            this.rptluongnhanvien.Size = new System.Drawing.Size(680, 459);
            this.rptluongnhanvien.TabIndex = 1;
            this.rptluongnhanvien.ViewTimeSelectionFormula = "";
            // 
            // frmrptluongtheophong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 459);
            this.Controls.Add(this.rptluongnhanvien);
            this.Name = "frmrptluongtheophong";
            this.Text = "Báo cáo lương theo phòng";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptluongnhanvien;
    }
}