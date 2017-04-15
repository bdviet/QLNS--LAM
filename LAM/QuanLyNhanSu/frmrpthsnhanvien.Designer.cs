namespace QuanLyNhanSu
{
    partial class frmrpthsnhanvien
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
            this.rpthsnhanvien = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rpthsnhanvien
            // 
            this.rpthsnhanvien.ActiveViewIndex = -1;
            this.rpthsnhanvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpthsnhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpthsnhanvien.Location = new System.Drawing.Point(0, 0);
            this.rpthsnhanvien.Name = "rpthsnhanvien";
            this.rpthsnhanvien.SelectionFormula = "";
            this.rpthsnhanvien.Size = new System.Drawing.Size(709, 438);
            this.rpthsnhanvien.TabIndex = 0;
            this.rpthsnhanvien.ViewTimeSelectionFormula = "";
            // 
            // frmrpthsnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 438);
            this.Controls.Add(this.rpthsnhanvien);
            this.Name = "frmrpthsnhanvien";
            this.Text = "Báo cáo trích ngang lý lịch nhân viên";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpthsnhanvien;
    }
}