namespace QuanLyNhanSu
{
    partial class frmrptbcbh
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
            this.rptbcbaohiem = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rptbcbaohiem
            // 
            this.rptbcbaohiem.ActiveViewIndex = -1;
            this.rptbcbaohiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptbcbaohiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptbcbaohiem.Location = new System.Drawing.Point(0, 0);
            this.rptbcbaohiem.Name = "rptbcbaohiem";
            this.rptbcbaohiem.SelectionFormula = "";
            this.rptbcbaohiem.Size = new System.Drawing.Size(603, 359);
            this.rptbcbaohiem.TabIndex = 0;
            this.rptbcbaohiem.ViewTimeSelectionFormula = "";
            // 
            // frmrptbcbh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 359);
            this.Controls.Add(this.rptbcbaohiem);
            this.Name = "frmrptbcbh";
            this.Text = "Báo cáo bảo hiểm xả hội và bảo hiểm y tế";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptbcbaohiem;
    }
}