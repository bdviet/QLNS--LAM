namespace QuanLyNhanSu
{
    partial class frmKiemTraHDHetHan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKiemTraHDHetHan));
            this.cbonamkt = new System.Windows.Forms.ComboBox();
            this.cbothangkt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.cmdxem = new System.Windows.Forms.Button();
            this.dgv_NV_HopDong = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV_HopDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV_HopDong.MasterGridViewTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // cbonamkt
            // 
            this.cbonamkt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbonamkt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbonamkt.FormattingEnabled = true;
            this.cbonamkt.Location = new System.Drawing.Point(402, 7);
            this.cbonamkt.Name = "cbonamkt";
            this.cbonamkt.Size = new System.Drawing.Size(57, 21);
            this.cbonamkt.TabIndex = 43;
            this.cbonamkt.SelectionChangeCommitted += new System.EventHandler(this.cbonamkt_SelectedIndexChanged);
            // 
            // cbothangkt
            // 
            this.cbothangkt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbothangkt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbothangkt.FormattingEnabled = true;
            this.cbothangkt.Location = new System.Drawing.Point(295, 7);
            this.cbothangkt.Name = "cbothangkt";
            this.cbothangkt.Size = new System.Drawing.Size(46, 21);
            this.cbothangkt.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "Năm :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tháng :";
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(358, 199);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(73, 30);
            this.btnIn.TabIndex = 46;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // cmdxem
            // 
            this.cmdxem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdxem.Image = ((System.Drawing.Image)(resources.GetObject("cmdxem.Image")));
            this.cmdxem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdxem.Location = new System.Drawing.Point(279, 199);
            this.cmdxem.Name = "cmdxem";
            this.cmdxem.Size = new System.Drawing.Size(73, 30);
            this.cmdxem.TabIndex = 45;
            this.cmdxem.Text = "Xem";
            this.cmdxem.UseVisualStyleBackColor = true;
            this.cmdxem.Click += new System.EventHandler(this.cmdxem_Click);
            // 
            // dgv_NV_HopDong
            // 
            this.dgv_NV_HopDong.Location = new System.Drawing.Point(12, 38);
            // 
            // 
            // 
            this.dgv_NV_HopDong.MasterGridViewTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.dgv_NV_HopDong.MasterGridViewTemplate.EnableGrouping = false;
            this.dgv_NV_HopDong.Name = "dgv_NV_HopDong";
            this.dgv_NV_HopDong.ReadOnly = true;
            this.dgv_NV_HopDong.Size = new System.Drawing.Size(640, 150);
            this.dgv_NV_HopDong.TabIndex = 47;
            // 
            // frmKiemTraHDHetHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 244);
            this.Controls.Add(this.dgv_NV_HopDong);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.cmdxem);
            this.Controls.Add(this.cbonamkt);
            this.Controls.Add(this.cbothangkt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKiemTraHDHetHan";
            this.Text = "Kiểm tra danh sách hợp đồng hết hạn";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmKiemTraHDHetHan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV_HopDong.MasterGridViewTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV_HopDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button cmdxem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadGridView dgv_NV_HopDong;
        public System.Windows.Forms.ComboBox cbonamkt;
        public System.Windows.Forms.ComboBox cbothangkt;
    }
}