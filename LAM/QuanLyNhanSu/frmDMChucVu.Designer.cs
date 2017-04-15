namespace QuanLyNhanSu
{
    partial class frmDMChucVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDMChucVu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdthoat = new System.Windows.Forms.Button();
            this.cmdluu = new System.Windows.Forms.Button();
            this.cmdxoa = new System.Windows.Forms.Button();
            this.cmdcapnhat = new System.Windows.Forms.Button();
            this.cmdthem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_DMChucVu = new Telerik.WinControls.UI.RadGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtphucap = new System.Windows.Forms.TextBox();
            this.txttenchucvu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmachucvu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DMChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DMChucVu.MasterGridViewTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmdthoat);
            this.groupBox1.Controls.Add(this.cmdluu);
            this.groupBox1.Controls.Add(this.cmdxoa);
            this.groupBox1.Controls.Add(this.cmdcapnhat);
            this.groupBox1.Controls.Add(this.cmdthem);
            this.groupBox1.Location = new System.Drawing.Point(416, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(82, 283);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // cmdthoat
            // 
            this.cmdthoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdthoat.Image = ((System.Drawing.Image)(resources.GetObject("cmdthoat.Image")));
            this.cmdthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdthoat.Location = new System.Drawing.Point(5, 214);
            this.cmdthoat.Name = "cmdthoat";
            this.cmdthoat.Size = new System.Drawing.Size(73, 30);
            this.cmdthoat.TabIndex = 9;
            this.cmdthoat.Text = "Thoát";
            this.cmdthoat.UseVisualStyleBackColor = true;
            this.cmdthoat.Click += new System.EventHandler(this.cmdthoat_Click);
            // 
            // cmdluu
            // 
            this.cmdluu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdluu.Image = ((System.Drawing.Image)(resources.GetObject("cmdluu.Image")));
            this.cmdluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdluu.Location = new System.Drawing.Point(5, 170);
            this.cmdluu.Name = "cmdluu";
            this.cmdluu.Size = new System.Drawing.Size(73, 30);
            this.cmdluu.TabIndex = 8;
            this.cmdluu.Text = "Lưu";
            this.cmdluu.UseVisualStyleBackColor = true;
            this.cmdluu.Click += new System.EventHandler(this.cmdluu_Click);
            // 
            // cmdxoa
            // 
            this.cmdxoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdxoa.Image = ((System.Drawing.Image)(resources.GetObject("cmdxoa.Image")));
            this.cmdxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdxoa.Location = new System.Drawing.Point(5, 126);
            this.cmdxoa.Name = "cmdxoa";
            this.cmdxoa.Size = new System.Drawing.Size(73, 30);
            this.cmdxoa.TabIndex = 7;
            this.cmdxoa.Text = "Xóa";
            this.cmdxoa.UseVisualStyleBackColor = true;
            this.cmdxoa.Click += new System.EventHandler(this.cmdxoa_Click);
            // 
            // cmdcapnhat
            // 
            this.cmdcapnhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdcapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcapnhat.Image = ((System.Drawing.Image)(resources.GetObject("cmdcapnhat.Image")));
            this.cmdcapnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdcapnhat.Location = new System.Drawing.Point(5, 82);
            this.cmdcapnhat.Name = "cmdcapnhat";
            this.cmdcapnhat.Size = new System.Drawing.Size(73, 30);
            this.cmdcapnhat.TabIndex = 6;
            this.cmdcapnhat.Text = "Sửa";
            this.cmdcapnhat.UseVisualStyleBackColor = true;
            this.cmdcapnhat.Click += new System.EventHandler(this.cmdcapnhat_Click);
            // 
            // cmdthem
            // 
            this.cmdthem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdthem.Image = ((System.Drawing.Image)(resources.GetObject("cmdthem.Image")));
            this.cmdthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdthem.Location = new System.Drawing.Point(5, 38);
            this.cmdthem.Name = "cmdthem";
            this.cmdthem.Size = new System.Drawing.Size(73, 30);
            this.cmdthem.TabIndex = 5;
            this.cmdthem.Text = "Thêm";
            this.cmdthem.UseVisualStyleBackColor = true;
            this.cmdthem.Click += new System.EventHandler(this.cmdthem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.dgv_DMChucVu);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtphucap);
            this.panel1.Controls.Add(this.txttenchucvu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtmachucvu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 277);
            this.panel1.TabIndex = 15;
            // 
            // dgv_DMChucVu
            // 
            this.dgv_DMChucVu.Location = new System.Drawing.Point(3, 102);
            // 
            // 
            // 
            this.dgv_DMChucVu.MasterGridViewTemplate.AllowDragToGroup = false;
            this.dgv_DMChucVu.MasterGridViewTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.dgv_DMChucVu.Name = "dgv_DMChucVu";
            this.dgv_DMChucVu.ReadOnly = true;
            this.dgv_DMChucVu.Size = new System.Drawing.Size(392, 172);
            this.dgv_DMChucVu.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Phụ Cấp";
            // 
            // txtphucap
            // 
            this.txtphucap.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtphucap.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphucap.Location = new System.Drawing.Point(151, 74);
            this.txtphucap.MaxLength = 8;
            this.txtphucap.Name = "txtphucap";
            this.txtphucap.ReadOnly = true;
            this.txtphucap.Size = new System.Drawing.Size(176, 22);
            this.txtphucap.TabIndex = 3;
            this.txtphucap.Tag = "";
            // 
            // txttenchucvu
            // 
            this.txttenchucvu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txttenchucvu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenchucvu.Location = new System.Drawing.Point(151, 42);
            this.txttenchucvu.MaxLength = 50;
            this.txttenchucvu.Name = "txttenchucvu";
            this.txttenchucvu.ReadOnly = true;
            this.txttenchucvu.Size = new System.Drawing.Size(176, 22);
            this.txttenchucvu.TabIndex = 2;
            this.txttenchucvu.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên Chức Vụ";
            // 
            // txtmachucvu
            // 
            this.txtmachucvu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtmachucvu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmachucvu.Location = new System.Drawing.Point(151, 11);
            this.txtmachucvu.MaxLength = 5;
            this.txtmachucvu.Name = "txtmachucvu";
            this.txtmachucvu.ReadOnly = true;
            this.txtmachucvu.Size = new System.Drawing.Size(176, 22);
            this.txtmachucvu.TabIndex = 1;
            this.txtmachucvu.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mã Chức Vụ";
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.ImageScalingSize = new System.Drawing.Size(1, 1);
            this.radLabel1.Location = new System.Drawing.Point(110, 30);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(236, 36);
            this.radLabel1.TabIndex = 17;
            this.radLabel1.Text = "Danh mục chức vụ";
            this.radLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::QuanLyNhanSu.Properties.Resources.Asterisque1;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(15, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmDMChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 376);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmDMChucVu";
            this.Text = "Danh Mục Chức Vụ";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmDMChucVu_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DMChucVu.MasterGridViewTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DMChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdthoat;
        private System.Windows.Forms.Button cmdluu;
        private System.Windows.Forms.Button cmdxoa;
        private System.Windows.Forms.Button cmdcapnhat;
        private System.Windows.Forms.Button cmdthem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtphucap;
        private System.Windows.Forms.TextBox txttenchucvu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmachucvu;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadGridView dgv_DMChucVu;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
    }
}