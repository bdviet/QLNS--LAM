namespace QuanLyNhanSu
{
    partial class frmbangtileluong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbangtileluong));
            this.grpbox = new System.Windows.Forms.GroupBox();
            this.cmdluu = new System.Windows.Forms.Button();
            this.cmdthoat = new System.Windows.Forms.Button();
            this.cmdthem = new System.Windows.Forms.Button();
            this.cmdCapnhat = new System.Windows.Forms.Button();
            this.cmdxoa = new System.Windows.Forms.Button();
            this.pnlthongtin = new System.Windows.Forms.Panel();
            this.dgv_TiLeLuong = new Telerik.WinControls.UI.RadGridView();
            this.cboto = new System.Windows.Forms.ComboBox();
            this.cbonam = new System.Windows.Forms.ComboBox();
            this.cbothang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsongaycong = new System.Windows.Forms.TextBox();
            this.txttll = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.grpbox.SuspendLayout();
            this.pnlthongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TiLeLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TiLeLuong.MasterGridViewTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbox
            // 
            this.grpbox.Controls.Add(this.cmdluu);
            this.grpbox.Controls.Add(this.cmdthoat);
            this.grpbox.Controls.Add(this.cmdthem);
            this.grpbox.Controls.Add(this.cmdCapnhat);
            this.grpbox.Controls.Add(this.cmdxoa);
            this.grpbox.Location = new System.Drawing.Point(59, 267);
            this.grpbox.Name = "grpbox";
            this.grpbox.Size = new System.Drawing.Size(374, 42);
            this.grpbox.TabIndex = 16;
            this.grpbox.TabStop = false;
            // 
            // cmdluu
            // 
            this.cmdluu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdluu.Image = ((System.Drawing.Image)(resources.GetObject("cmdluu.Image")));
            this.cmdluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdluu.Location = new System.Drawing.Point(222, 9);
            this.cmdluu.Name = "cmdluu";
            this.cmdluu.Size = new System.Drawing.Size(72, 30);
            this.cmdluu.TabIndex = 4;
            this.cmdluu.Text = "Lưu";
            this.cmdluu.UseVisualStyleBackColor = true;
            this.cmdluu.Click += new System.EventHandler(this.cmdluu_Click);
            // 
            // cmdthoat
            // 
            this.cmdthoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdthoat.Image = ((System.Drawing.Image)(resources.GetObject("cmdthoat.Image")));
            this.cmdthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdthoat.Location = new System.Drawing.Point(295, 9);
            this.cmdthoat.Name = "cmdthoat";
            this.cmdthoat.Size = new System.Drawing.Size(72, 30);
            this.cmdthoat.TabIndex = 5;
            this.cmdthoat.Text = "Thoát";
            this.cmdthoat.UseVisualStyleBackColor = true;
            this.cmdthoat.Click += new System.EventHandler(this.cmdthoat_Click);
            // 
            // cmdthem
            // 
            this.cmdthem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdthem.Image = ((System.Drawing.Image)(resources.GetObject("cmdthem.Image")));
            this.cmdthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdthem.Location = new System.Drawing.Point(5, 9);
            this.cmdthem.Name = "cmdthem";
            this.cmdthem.Size = new System.Drawing.Size(72, 30);
            this.cmdthem.TabIndex = 1;
            this.cmdthem.Text = "Thêm";
            this.cmdthem.UseVisualStyleBackColor = true;
            this.cmdthem.Click += new System.EventHandler(this.cmdthem_Click);
            // 
            // cmdCapnhat
            // 
            this.cmdCapnhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdCapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCapnhat.Image = ((System.Drawing.Image)(resources.GetObject("cmdCapnhat.Image")));
            this.cmdCapnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCapnhat.Location = new System.Drawing.Point(78, 9);
            this.cmdCapnhat.Name = "cmdCapnhat";
            this.cmdCapnhat.Size = new System.Drawing.Size(72, 30);
            this.cmdCapnhat.TabIndex = 2;
            this.cmdCapnhat.Text = "Sửa";
            this.cmdCapnhat.UseVisualStyleBackColor = true;
            this.cmdCapnhat.Click += new System.EventHandler(this.cmdCapnhat_Click);
            // 
            // cmdxoa
            // 
            this.cmdxoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdxoa.Image = ((System.Drawing.Image)(resources.GetObject("cmdxoa.Image")));
            this.cmdxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdxoa.Location = new System.Drawing.Point(149, 9);
            this.cmdxoa.Name = "cmdxoa";
            this.cmdxoa.Size = new System.Drawing.Size(72, 30);
            this.cmdxoa.TabIndex = 3;
            this.cmdxoa.Text = "Xóa";
            this.cmdxoa.UseVisualStyleBackColor = true;
            this.cmdxoa.Click += new System.EventHandler(this.cmdxoa_Click);
            // 
            // pnlthongtin
            // 
            this.pnlthongtin.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlthongtin.Controls.Add(this.dgv_TiLeLuong);
            this.pnlthongtin.Controls.Add(this.cboto);
            this.pnlthongtin.Controls.Add(this.cbonam);
            this.pnlthongtin.Controls.Add(this.cbothang);
            this.pnlthongtin.Controls.Add(this.label7);
            this.pnlthongtin.Controls.Add(this.label3);
            this.pnlthongtin.Controls.Add(this.txtsongaycong);
            this.pnlthongtin.Controls.Add(this.txttll);
            this.pnlthongtin.Controls.Add(this.label6);
            this.pnlthongtin.Controls.Add(this.label4);
            this.pnlthongtin.Controls.Add(this.label1);
            this.pnlthongtin.Controls.Add(this.label2);
            this.pnlthongtin.Controls.Add(this.cboPhong);
            this.pnlthongtin.Location = new System.Drawing.Point(12, 12);
            this.pnlthongtin.Name = "pnlthongtin";
            this.pnlthongtin.Size = new System.Drawing.Size(468, 255);
            this.pnlthongtin.TabIndex = 15;
            // 
            // dgv_TiLeLuong
            // 
            this.dgv_TiLeLuong.Location = new System.Drawing.Point(3, 88);
            // 
            // 
            // 
            this.dgv_TiLeLuong.MasterGridViewTemplate.AllowDragToGroup = false;
            this.dgv_TiLeLuong.MasterGridViewTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.dgv_TiLeLuong.MasterGridViewTemplate.EnableGrouping = false;
            this.dgv_TiLeLuong.Name = "dgv_TiLeLuong";
            this.dgv_TiLeLuong.ReadOnly = true;
            this.dgv_TiLeLuong.Size = new System.Drawing.Size(462, 161);
            this.dgv_TiLeLuong.TabIndex = 29;
            // 
            // cboto
            // 
            this.cboto.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cboto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboto.Enabled = false;
            this.cboto.ForeColor = System.Drawing.Color.Black;
            this.cboto.FormattingEnabled = true;
            this.cboto.Location = new System.Drawing.Point(300, 35);
            this.cboto.Name = "cboto";
            this.cboto.Size = new System.Drawing.Size(147, 21);
            this.cboto.TabIndex = 4;
            // 
            // cbonam
            // 
            this.cbonam.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbonam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbonam.Enabled = false;
            this.cbonam.ForeColor = System.Drawing.Color.Black;
            this.cbonam.FormattingEnabled = true;
            this.cbonam.Location = new System.Drawing.Point(300, 6);
            this.cbonam.Name = "cbonam";
            this.cbonam.Size = new System.Drawing.Size(65, 21);
            this.cbonam.TabIndex = 2;
            // 
            // cbothang
            // 
            this.cbothang.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbothang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbothang.Enabled = false;
            this.cbothang.ForeColor = System.Drawing.Color.Black;
            this.cbothang.FormattingEnabled = true;
            this.cbothang.Location = new System.Drawing.Point(183, 6);
            this.cbothang.Name = "cbothang";
            this.cbothang.Size = new System.Drawing.Size(46, 21);
            this.cbothang.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(263, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Năm :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tháng :";
            // 
            // txtsongaycong
            // 
            this.txtsongaycong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtsongaycong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsongaycong.Location = new System.Drawing.Point(352, 60);
            this.txtsongaycong.MaxLength = 2;
            this.txtsongaycong.Name = "txtsongaycong";
            this.txtsongaycong.Size = new System.Drawing.Size(30, 22);
            this.txtsongaycong.TabIndex = 6;
            this.txtsongaycong.Tag = "";
            this.txtsongaycong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txttll
            // 
            this.txttll.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txttll.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttll.Location = new System.Drawing.Point(175, 60);
            this.txttll.MaxLength = 6;
            this.txttll.Name = "txttll";
            this.txttll.Size = new System.Drawing.Size(54, 22);
            this.txttll.TabIndex = 5;
            this.txttll.Tag = "";
            this.txttll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(263, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Số ngày công :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tỉ lệ lương :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Phòng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tổ :";
            // 
            // cboPhong
            // 
            this.cboPhong.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.Enabled = false;
            this.cboPhong.ForeColor = System.Drawing.Color.Black;
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(61, 34);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(168, 21);
            this.cboPhong.TabIndex = 3;
            this.cboPhong.Click += new System.EventHandler(this.cboPhong_SelectedIndexChanged);
            // 
            // frmbangtileluong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 319);
            this.Controls.Add(this.grpbox);
            this.Controls.Add(this.pnlthongtin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmbangtileluong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng Tỷ Lệ Lương";
            this.Load += new System.EventHandler(this.frmbangtileluong_Load);
            this.grpbox.ResumeLayout(false);
            this.pnlthongtin.ResumeLayout(false);
            this.pnlthongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TiLeLuong.MasterGridViewTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TiLeLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbox;
        private System.Windows.Forms.Button cmdluu;
        private System.Windows.Forms.Button cmdthoat;
        private System.Windows.Forms.Button cmdthem;
        private System.Windows.Forms.Button cmdCapnhat;
        private System.Windows.Forms.Button cmdxoa;
        private System.Windows.Forms.Panel pnlthongtin;
        private System.Windows.Forms.ComboBox cboto;
        private System.Windows.Forms.ComboBox cbonam;
        private System.Windows.Forms.ComboBox cbothang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsongaycong;
        private System.Windows.Forms.TextBox txttll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPhong;
        private Telerik.WinControls.UI.RadGridView dgv_TiLeLuong;
    }
}