namespace QuanLyNhanSu
{
    partial class frmDMPhongBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDMPhongBan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_DMPB = new Telerik.WinControls.UI.RadGridView();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttenPB = new System.Windows.Forms.TextBox();
            this.txtmaPB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpbox = new System.Windows.Forms.GroupBox();
            this.cmdxoa = new System.Windows.Forms.Button();
            this.cmdluu = new System.Windows.Forms.Button();
            this.cmdthoat = new System.Windows.Forms.Button();
            this.cmdthem = new System.Windows.Forms.Button();
            this.cmdcapnhat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DMPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DMPB.MasterGridViewTemplate)).BeginInit();
            this.grpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.dgv_DMPB);
            this.panel1.Controls.Add(this.txtdienthoai);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txttenPB);
            this.panel1.Controls.Add(this.txtmaPB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 261);
            this.panel1.TabIndex = 0;
            // 
            // dgv_DMPB
            // 
            this.dgv_DMPB.Location = new System.Drawing.Point(11, 89);
            // 
            // 
            // 
            this.dgv_DMPB.MasterGridViewTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.dgv_DMPB.MasterGridViewTemplate.EnableGrouping = false;
            this.dgv_DMPB.Name = "dgv_DMPB";
            this.dgv_DMPB.ReadOnly = true;
            this.dgv_DMPB.Size = new System.Drawing.Size(392, 163);
            this.dgv_DMPB.TabIndex = 26;
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtdienthoai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdienthoai.Location = new System.Drawing.Point(147, 61);
            this.txtdienthoai.MaxLength = 12;
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.ReadOnly = true;
            this.txtdienthoai.Size = new System.Drawing.Size(209, 22);
            this.txtdienthoai.TabIndex = 3;
            this.txtdienthoai.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Điện thoại liên lạc :";
            // 
            // txttenPB
            // 
            this.txttenPB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txttenPB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenPB.Location = new System.Drawing.Point(147, 34);
            this.txttenPB.MaxLength = 50;
            this.txttenPB.Name = "txttenPB";
            this.txttenPB.ReadOnly = true;
            this.txttenPB.Size = new System.Drawing.Size(209, 22);
            this.txttenPB.TabIndex = 2;
            this.txttenPB.Tag = "";
            // 
            // txtmaPB
            // 
            this.txtmaPB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtmaPB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaPB.Location = new System.Drawing.Point(147, 6);
            this.txtmaPB.MaxLength = 5;
            this.txtmaPB.Name = "txtmaPB";
            this.txtmaPB.ReadOnly = true;
            this.txtmaPB.Size = new System.Drawing.Size(209, 22);
            this.txtmaPB.TabIndex = 1;
            this.txtmaPB.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tên phòng ban :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mã phòng ban :";
            // 
            // grpbox
            // 
            this.grpbox.BackColor = System.Drawing.Color.Transparent;
            this.grpbox.Controls.Add(this.cmdxoa);
            this.grpbox.Controls.Add(this.cmdluu);
            this.grpbox.Controls.Add(this.cmdthoat);
            this.grpbox.Controls.Add(this.cmdthem);
            this.grpbox.Controls.Add(this.cmdcapnhat);
            this.grpbox.Location = new System.Drawing.Point(424, 3);
            this.grpbox.Name = "grpbox";
            this.grpbox.Size = new System.Drawing.Size(88, 267);
            this.grpbox.TabIndex = 17;
            this.grpbox.TabStop = false;
            // 
            // cmdxoa
            // 
            this.cmdxoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdxoa.Image = ((System.Drawing.Image)(resources.GetObject("cmdxoa.Image")));
            this.cmdxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdxoa.Location = new System.Drawing.Point(8, 118);
            this.cmdxoa.Name = "cmdxoa";
            this.cmdxoa.Size = new System.Drawing.Size(73, 30);
            this.cmdxoa.TabIndex = 6;
            this.cmdxoa.Text = "Xóa";
            this.cmdxoa.UseVisualStyleBackColor = true;
            this.cmdxoa.Click += new System.EventHandler(this.cmdxoa_Click);
            // 
            // cmdluu
            // 
            this.cmdluu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdluu.Image = ((System.Drawing.Image)(resources.GetObject("cmdluu.Image")));
            this.cmdluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdluu.Location = new System.Drawing.Point(8, 162);
            this.cmdluu.Name = "cmdluu";
            this.cmdluu.Size = new System.Drawing.Size(73, 30);
            this.cmdluu.TabIndex = 7;
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
            this.cmdthoat.Location = new System.Drawing.Point(8, 206);
            this.cmdthoat.Name = "cmdthoat";
            this.cmdthoat.Size = new System.Drawing.Size(73, 30);
            this.cmdthoat.TabIndex = 8;
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
            this.cmdthem.Location = new System.Drawing.Point(8, 30);
            this.cmdthem.Name = "cmdthem";
            this.cmdthem.Size = new System.Drawing.Size(73, 30);
            this.cmdthem.TabIndex = 4;
            this.cmdthem.Text = "Thêm";
            this.cmdthem.UseVisualStyleBackColor = true;
            this.cmdthem.Click += new System.EventHandler(this.cmdthem_Click);
            // 
            // cmdcapnhat
            // 
            this.cmdcapnhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdcapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcapnhat.Image = ((System.Drawing.Image)(resources.GetObject("cmdcapnhat.Image")));
            this.cmdcapnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdcapnhat.Location = new System.Drawing.Point(8, 74);
            this.cmdcapnhat.Name = "cmdcapnhat";
            this.cmdcapnhat.Size = new System.Drawing.Size(73, 30);
            this.cmdcapnhat.TabIndex = 5;
            this.cmdcapnhat.Text = "Sửa";
            this.cmdcapnhat.UseVisualStyleBackColor = true;
            this.cmdcapnhat.Click += new System.EventHandler(this.cmdcapnhat_Click);
            // 
            // frmDMPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(524, 273);
            this.Controls.Add(this.grpbox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDMPhongBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Danh Mục Phòng Ban";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmDMPhongBan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DMPB.MasterGridViewTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DMPB)).EndInit();
            this.grpbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpbox;
        private System.Windows.Forms.Button cmdxoa;
        private System.Windows.Forms.Button cmdluu;
        private System.Windows.Forms.Button cmdthoat;
        private System.Windows.Forms.Button cmdthem;
        private System.Windows.Forms.Button cmdcapnhat;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttenPB;
        private System.Windows.Forms.TextBox txtmaPB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadGridView dgv_DMPB;

    }
}