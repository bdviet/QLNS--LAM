namespace QuanLyNhanSu
{
    partial class frmtracuutrinhdo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtracuutrinhdo));
            this.radTabStrip1 = new Telerik.WinControls.UI.RadTabStrip();
            this.tabItem1 = new Telerik.WinControls.UI.TabItem();
            this.dgv_TCTD1 = new System.Windows.Forms.DataGridView();
            this.cmmanv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmhoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmtencm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmtentd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmngaycap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmtruong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmacm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmmatd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttruongcap = new System.Windows.Forms.TextBox();
            this.cbodmtd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbodmcm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabItem2 = new Telerik.WinControls.UI.TabItem();
            this.dgv_NV_NN = new System.Windows.Forms.DataGridView();
            this.nnmanv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nnhoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NNtenngoaingu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nntrinhdo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nnnoicap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nnngaycap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nnmann = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttrinhdo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnoicap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbodmnn = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdtim = new System.Windows.Forms.Button();
            this.cmdnntim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.radTabStrip1)).BeginInit();
            this.radTabStrip1.SuspendLayout();
            this.tabItem1.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TCTD1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabItem2.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV_NN)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTabStrip1
            // 
            this.radTabStrip1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.radTabStrip1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.radTabStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.radTabStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTabStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.tabItem1,
            this.tabItem2});
            this.radTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.radTabStrip1.Name = "radTabStrip1";
            this.radTabStrip1.ScrollOffsetStep = 5;
            this.radTabStrip1.Size = new System.Drawing.Size(488, 366);
            this.radTabStrip1.TabIndex = 1;
            this.radTabStrip1.TabScrollButtonsPosition = Telerik.WinControls.UI.TabScrollButtonsPosition.RightBottom;
            this.radTabStrip1.Text = "radTabStrip1";
            // 
            // tabItem1
            // 
            this.tabItem1.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.tabItem1.CanFocus = true;
            this.tabItem1.Class = "TabItem";
            // 
            // tabItem1.ContentPanel
            // 
            this.tabItem1.ContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.tabItem1.ContentPanel.CausesValidation = true;
            this.tabItem1.ContentPanel.Controls.Add(this.dgv_TCTD1);
            this.tabItem1.ContentPanel.Controls.Add(this.groupBox1);
            this.tabItem1.ContentPanel.Controls.Add(this.cmdtim);
            this.tabItem1.IsSelected = true;
            this.tabItem1.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.StretchHorizontally = false;
            this.tabItem1.Text = "Trình độ";
            // 
            // dgv_TCTD1
            // 
            this.dgv_TCTD1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_TCTD1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TCTD1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmmanv,
            this.cmhoten,
            this.cmtencm,
            this.cmtentd,
            this.cmngaycap,
            this.cmtruong,
            this.cmacm,
            this.cmmatd});
            this.dgv_TCTD1.Location = new System.Drawing.Point(29, 149);
            this.dgv_TCTD1.Name = "dgv_TCTD1";
            this.dgv_TCTD1.ReadOnly = true;
            this.dgv_TCTD1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TCTD1.Size = new System.Drawing.Size(437, 163);
            this.dgv_TCTD1.TabIndex = 13;
            // 
            // cmmanv
            // 
            this.cmmanv.DataPropertyName = "manv";
            this.cmmanv.HeaderText = "Mã NV";
            this.cmmanv.Name = "cmmanv";
            this.cmmanv.ReadOnly = true;
            this.cmmanv.Width = 65;
            // 
            // cmhoten
            // 
            this.cmhoten.DataPropertyName = "hoten";
            this.cmhoten.HeaderText = "Họ Tên";
            this.cmhoten.Name = "cmhoten";
            this.cmhoten.ReadOnly = true;
            // 
            // cmtencm
            // 
            this.cmtencm.DataPropertyName = "tenchuyenmon";
            this.cmtencm.HeaderText = "Tên CM";
            this.cmtencm.Name = "cmtencm";
            this.cmtencm.ReadOnly = true;
            // 
            // cmtentd
            // 
            this.cmtentd.DataPropertyName = "tentrinhdo";
            this.cmtentd.HeaderText = "Trình Độ";
            this.cmtentd.Name = "cmtentd";
            this.cmtentd.ReadOnly = true;
            // 
            // cmngaycap
            // 
            this.cmngaycap.DataPropertyName = "ngaycap";
            this.cmngaycap.HeaderText = "Ngày cấp";
            this.cmngaycap.Name = "cmngaycap";
            this.cmngaycap.ReadOnly = true;
            // 
            // cmtruong
            // 
            this.cmtruong.DataPropertyName = "truong";
            this.cmtruong.HeaderText = "Trường cấp";
            this.cmtruong.Name = "cmtruong";
            this.cmtruong.ReadOnly = true;
            // 
            // cmacm
            // 
            this.cmacm.DataPropertyName = "machuyenmon";
            this.cmacm.HeaderText = "Mã CM";
            this.cmacm.Name = "cmacm";
            this.cmacm.ReadOnly = true;
            this.cmacm.Visible = false;
            // 
            // cmmatd
            // 
            this.cmmatd.DataPropertyName = "matrinhdo";
            this.cmmatd.HeaderText = "Mã TD";
            this.cmmatd.Name = "cmmatd";
            this.cmmatd.ReadOnly = true;
            this.cmmatd.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txttruongcap);
            this.groupBox1.Controls.Add(this.cbodmtd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbodmcm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 98);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Trường Cấp :";
            // 
            // txttruongcap
            // 
            this.txttruongcap.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txttruongcap.Location = new System.Drawing.Point(184, 60);
            this.txttruongcap.MaxLength = 50;
            this.txttruongcap.Name = "txttruongcap";
            this.txttruongcap.Size = new System.Drawing.Size(144, 20);
            this.txttruongcap.TabIndex = 4;
            // 
            // cbodmtd
            // 
            this.cbodmtd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbodmtd.FormattingEnabled = true;
            this.cbodmtd.Location = new System.Drawing.Point(290, 23);
            this.cbodmtd.Name = "cbodmtd";
            this.cbodmtd.Size = new System.Drawing.Size(140, 21);
            this.cbodmtd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trình độ :";
            // 
            // cbodmcm
            // 
            this.cbodmcm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbodmcm.FormattingEnabled = true;
            this.cbodmcm.Location = new System.Drawing.Point(85, 23);
            this.cbodmcm.Name = "cbodmcm";
            this.cbodmcm.Size = new System.Drawing.Size(140, 21);
            this.cbodmcm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuyên Môn :";
            // 
            // tabItem2
            // 
            this.tabItem2.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.tabItem2.CanFocus = true;
            this.tabItem2.Class = "TabItem";
            // 
            // tabItem2.ContentPanel
            // 
            this.tabItem2.ContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.tabItem2.ContentPanel.CausesValidation = true;
            this.tabItem2.ContentPanel.Controls.Add(this.cmdnntim);
            this.tabItem2.ContentPanel.Controls.Add(this.dgv_NV_NN);
            this.tabItem2.ContentPanel.Controls.Add(this.groupBox2);
            this.tabItem2.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.StretchHorizontally = false;
            this.tabItem2.Text = "Ngoại ngữ";
            // 
            // dgv_NV_NN
            // 
            this.dgv_NV_NN.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_NV_NN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NV_NN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nnmanv,
            this.nnhoten,
            this.NNtenngoaingu,
            this.nntrinhdo,
            this.nnnoicap,
            this.nnngaycap,
            this.nnmann});
            this.dgv_NV_NN.Location = new System.Drawing.Point(29, 149);
            this.dgv_NV_NN.Name = "dgv_NV_NN";
            this.dgv_NV_NN.ReadOnly = true;
            this.dgv_NV_NN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_NV_NN.Size = new System.Drawing.Size(437, 163);
            this.dgv_NV_NN.TabIndex = 15;
            // 
            // nnmanv
            // 
            this.nnmanv.DataPropertyName = "manv";
            this.nnmanv.HeaderText = "Mã NV";
            this.nnmanv.Name = "nnmanv";
            this.nnmanv.ReadOnly = true;
            this.nnmanv.Width = 65;
            // 
            // nnhoten
            // 
            this.nnhoten.DataPropertyName = "hoten";
            this.nnhoten.HeaderText = "Họ Tên";
            this.nnhoten.Name = "nnhoten";
            this.nnhoten.ReadOnly = true;
            // 
            // NNtenngoaingu
            // 
            this.NNtenngoaingu.DataPropertyName = "tenngoaingu";
            this.NNtenngoaingu.HeaderText = "Ngoại Ngữ";
            this.NNtenngoaingu.Name = "NNtenngoaingu";
            this.NNtenngoaingu.ReadOnly = true;
            // 
            // nntrinhdo
            // 
            this.nntrinhdo.DataPropertyName = "trinhdo";
            this.nntrinhdo.HeaderText = "Trình Độ";
            this.nntrinhdo.Name = "nntrinhdo";
            this.nntrinhdo.ReadOnly = true;
            // 
            // nnnoicap
            // 
            this.nnnoicap.DataPropertyName = "noicap";
            this.nnnoicap.HeaderText = "Nơi cấp";
            this.nnnoicap.Name = "nnnoicap";
            this.nnnoicap.ReadOnly = true;
            // 
            // nnngaycap
            // 
            this.nnngaycap.DataPropertyName = "ngaycap";
            this.nnngaycap.HeaderText = "Ngày Cấp";
            this.nnngaycap.Name = "nnngaycap";
            this.nnngaycap.ReadOnly = true;
            // 
            // nnmann
            // 
            this.nnmann.DataPropertyName = "mangoaingu";
            this.nnmann.HeaderText = "Mann";
            this.nnmann.Name = "nnmann";
            this.nnmann.ReadOnly = true;
            this.nnmann.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttrinhdo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtnoicap);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbodmnn);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(29, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 98);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tìm kiếm";
            // 
            // txttrinhdo
            // 
            this.txttrinhdo.Location = new System.Drawing.Point(282, 23);
            this.txttrinhdo.Name = "txttrinhdo";
            this.txttrinhdo.Size = new System.Drawing.Size(144, 20);
            this.txttrinhdo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Trường Cấp :";
            // 
            // txtnoicap
            // 
            this.txtnoicap.Location = new System.Drawing.Point(184, 60);
            this.txtnoicap.Name = "txtnoicap";
            this.txtnoicap.Size = new System.Drawing.Size(144, 20);
            this.txtnoicap.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Trình độ :";
            // 
            // cbodmnn
            // 
            this.cbodmnn.FormattingEnabled = true;
            this.cbodmnn.Location = new System.Drawing.Point(78, 22);
            this.cbodmnn.Name = "cbodmnn";
            this.cbodmnn.Size = new System.Drawing.Size(140, 21);
            this.cbodmnn.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngoại Ngữ :";
            // 
            // cmdtim
            // 
            this.cmdtim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdtim.Image = global::QuanLyNhanSu.Properties.Resources.Search2;
            this.cmdtim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdtim.Location = new System.Drawing.Point(202, 116);
            this.cmdtim.Name = "cmdtim";
            this.cmdtim.Size = new System.Drawing.Size(95, 30);
            this.cmdtim.TabIndex = 12;
            this.cmdtim.Text = "Tìm kiếm";
            this.cmdtim.UseVisualStyleBackColor = true;
            this.cmdtim.Click += new System.EventHandler(this.cmdtim_Click);
            // 
            // cmdnntim
            // 
            this.cmdnntim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdnntim.Image = global::QuanLyNhanSu.Properties.Resources.Search1;
            this.cmdnntim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdnntim.Location = new System.Drawing.Point(202, 116);
            this.cmdnntim.Name = "cmdnntim";
            this.cmdnntim.Size = new System.Drawing.Size(94, 30);
            this.cmdnntim.TabIndex = 16;
            this.cmdnntim.Text = "Tìm kiếm";
            this.cmdnntim.UseVisualStyleBackColor = true;
            this.cmdnntim.Click += new System.EventHandler(this.cmdnntim_Click);
            // 
            // frmtracuutrinhdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(488, 366);
            this.Controls.Add(this.radTabStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmtracuutrinhdo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Tìm kiếm TTNV theo trình độ";
            this.ThemeName = "Office2007Blue";
            this.Load += new System.EventHandler(this.frmtracuutrinhdo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radTabStrip1)).EndInit();
            this.radTabStrip1.ResumeLayout(false);
            this.tabItem1.ContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TCTD1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabItem2.ContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV_NN)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTabStrip radTabStrip1;
        private Telerik.WinControls.UI.TabItem tabItem1;
        private System.Windows.Forms.DataGridView dgv_TCTD1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmmanv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmhoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmtencm;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmtentd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmngaycap;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmtruong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmacm;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmmatd;
        private System.Windows.Forms.Button cmdtim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttruongcap;
        private System.Windows.Forms.ComboBox cbodmtd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbodmcm;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.TabItem tabItem2;
        private System.Windows.Forms.Button cmdnntim;
        private System.Windows.Forms.DataGridView dgv_NV_NN;
        private System.Windows.Forms.DataGridViewTextBoxColumn nnmanv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nnhoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn NNtenngoaingu;
        private System.Windows.Forms.DataGridViewTextBoxColumn nntrinhdo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nnnoicap;
        private System.Windows.Forms.DataGridViewTextBoxColumn nnngaycap;
        private System.Windows.Forms.DataGridViewTextBoxColumn nnmann;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txttrinhdo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnoicap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbodmnn;
        private System.Windows.Forms.Label label6;



    }
}