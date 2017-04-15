namespace QuanLyNhanSu
{
    partial class frmrptNV_HDhethan
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
            this.rvNV_HDhethan = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rvNV_HDhethan
            // 
            this.rvNV_HDhethan.ActiveViewIndex = -1;
            this.rvNV_HDhethan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rvNV_HDhethan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvNV_HDhethan.Location = new System.Drawing.Point(0, 0);
            this.rvNV_HDhethan.Name = "rvNV_HDhethan";
            this.rvNV_HDhethan.SelectionFormula = "";
            this.rvNV_HDhethan.Size = new System.Drawing.Size(770, 411);
            this.rvNV_HDhethan.TabIndex = 0;
            this.rvNV_HDhethan.ViewTimeSelectionFormula = "";
            this.rvNV_HDhethan.Load += new System.EventHandler(this.rvNV_HDhethan_Load);
            // 
            // frmrptNV_HDhethan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 411);
            this.Controls.Add(this.rvNV_HDhethan);
            this.Name = "frmrptNV_HDhethan";
            this.Text = "Báo cáo danh sách hợp đồng hết hạn";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rvNV_HDhethan;
    }
}