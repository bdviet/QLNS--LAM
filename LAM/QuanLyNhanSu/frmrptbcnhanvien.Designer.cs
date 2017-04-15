namespace QuanLyNhanSu
{
    partial class frmrptbcnhanvien
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
            this.rptbcnhanvien = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rptbcnhanvien
            // 
            this.rptbcnhanvien.ActiveViewIndex = -1;
            this.rptbcnhanvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptbcnhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptbcnhanvien.Location = new System.Drawing.Point(0, 0);
            this.rptbcnhanvien.Name = "rptbcnhanvien";
            this.rptbcnhanvien.SelectionFormula = "";
            this.rptbcnhanvien.Size = new System.Drawing.Size(780, 442);
            this.rptbcnhanvien.TabIndex = 0;
            this.rptbcnhanvien.ViewTimeSelectionFormula = "";
            // 
            // frmrptbcnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 442);
            this.Controls.Add(this.rptbcnhanvien);
            this.Name = "frmrptbcnhanvien";
            this.Text = "Báo cáo nhân sự";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptbcnhanvien;
    }
}