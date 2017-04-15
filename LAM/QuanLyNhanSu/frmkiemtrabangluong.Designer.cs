namespace QuanLyNhanSu
{
    partial class frmkiemtrabangluong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmkiemtrabangluong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbonamkt = new System.Windows.Forms.ComboBox();
            this.cbothangkt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdthoat = new System.Windows.Forms.Button();
            this.cmdkiemtra = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.cbonamkt);
            this.panel1.Controls.Add(this.cbothangkt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmdthoat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmdkiemtra);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 79);
            this.panel1.TabIndex = 2;
            // 
            // cbonamkt
            // 
            this.cbonamkt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbonamkt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbonamkt.FormattingEnabled = true;
            this.cbonamkt.Location = new System.Drawing.Point(151, 8);
            this.cbonamkt.Name = "cbonamkt";
            this.cbonamkt.Size = new System.Drawing.Size(57, 21);
            this.cbonamkt.TabIndex = 32;
            // 
            // cbothangkt
            // 
            this.cbothangkt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbothangkt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbothangkt.FormattingEnabled = true;
            this.cbothangkt.Location = new System.Drawing.Point(62, 8);
            this.cbothangkt.Name = "cbothangkt";
            this.cbothangkt.Size = new System.Drawing.Size(46, 21);
            this.cbothangkt.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Năm :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tháng :";
            // 
            // cmdthoat
            // 
            this.cmdthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdthoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdthoat.Image = ((System.Drawing.Image)(resources.GetObject("cmdthoat.Image")));
            this.cmdthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdthoat.Location = new System.Drawing.Point(115, 40);
            this.cmdthoat.Name = "cmdthoat";
            this.cmdthoat.Size = new System.Drawing.Size(93, 30);
            this.cmdthoat.TabIndex = 9;
            this.cmdthoat.Tag = "";
            this.cmdthoat.Text = "Thoát";
            this.cmdthoat.UseVisualStyleBackColor = true;
            this.cmdthoat.Click += new System.EventHandler(this.cmdthoat_Click);
            // 
            // cmdkiemtra
            // 
            this.cmdkiemtra.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdkiemtra.Image = ((System.Drawing.Image)(resources.GetObject("cmdkiemtra.Image")));
            this.cmdkiemtra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdkiemtra.Location = new System.Drawing.Point(15, 40);
            this.cmdkiemtra.Name = "cmdkiemtra";
            this.cmdkiemtra.Size = new System.Drawing.Size(93, 30);
            this.cmdkiemtra.TabIndex = 8;
            this.cmdkiemtra.Tag = "";
            this.cmdkiemtra.Text = "Kiểm Tra";
            this.cmdkiemtra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdkiemtra.UseVisualStyleBackColor = true;
            this.cmdkiemtra.Click += new System.EventHandler(this.cmdkiemtra_Click);
            // 
            // frmkiemtrabangluong
            // 
            this.AcceptButton = this.cmdkiemtra;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdthoat;
            this.ClientSize = new System.Drawing.Size(251, 107);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmkiemtrabangluong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiểm tra bảng lương";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbonamkt;
        private System.Windows.Forms.ComboBox cbothangkt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdthoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdkiemtra;
    }
}