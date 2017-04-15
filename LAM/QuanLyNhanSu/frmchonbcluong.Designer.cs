namespace QuanLyNhanSu
{
    partial class frmchonbcluong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmchonbcluong));
            this.radTabStrip1 = new Telerik.WinControls.UI.RadTabStrip();
            this.tabItem1 = new Telerik.WinControls.UI.TabItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbophong = new System.Windows.Forms.ComboBox();
            this.cboto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbonambc = new System.Windows.Forms.ComboBox();
            this.cbothangbc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdin = new System.Windows.Forms.Button();
            this.tabItem2 = new Telerik.WinControls.UI.TabItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbonambh = new System.Windows.Forms.ComboBox();
            this.cbothangbh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdinbh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.radTabStrip1)).BeginInit();
            this.radTabStrip1.SuspendLayout();
            this.tabItem1.ContentPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabItem2.ContentPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTabStrip1
            // 
            this.radTabStrip1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.radTabStrip1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.radTabStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.radTabStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.tabItem1,
            this.tabItem2});
            this.radTabStrip1.Location = new System.Drawing.Point(9, 67);
            this.radTabStrip1.Name = "radTabStrip1";
            this.radTabStrip1.ScrollOffsetStep = 5;
            this.radTabStrip1.Size = new System.Drawing.Size(264, 177);
            this.radTabStrip1.TabIndex = 0;
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
            this.tabItem1.ContentPanel.Controls.Add(this.panel2);
            this.tabItem1.IsSelected = true;
            this.tabItem1.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.StretchHorizontally = false;
            this.tabItem1.Text = "Bảng lương";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.cbophong);
            this.panel2.Controls.Add(this.cboto);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbonambc);
            this.panel2.Controls.Add(this.cbothangbc);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cmdin);
            this.panel2.Location = new System.Drawing.Point(11, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 130);
            this.panel2.TabIndex = 6;
            // 
            // cbophong
            // 
            this.cbophong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbophong.FormattingEnabled = true;
            this.cbophong.Location = new System.Drawing.Point(67, 36);
            this.cbophong.Name = "cbophong";
            this.cbophong.Size = new System.Drawing.Size(158, 21);
            this.cbophong.TabIndex = 35;
            this.cbophong.SelectionChangeCommitted += new System.EventHandler(this.cbophong_SelectedIndexChanged);
            // 
            // cboto
            // 
            this.cboto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboto.FormattingEnabled = true;
            this.cboto.Location = new System.Drawing.Point(67, 64);
            this.cboto.Name = "cboto";
            this.cboto.Size = new System.Drawing.Size(158, 21);
            this.cboto.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Tổ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "Phòng :";
            // 
            // cbonambc
            // 
            this.cbonambc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbonambc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbonambc.FormattingEnabled = true;
            this.cbonambc.Location = new System.Drawing.Point(168, 8);
            this.cbonambc.Name = "cbonambc";
            this.cbonambc.Size = new System.Drawing.Size(57, 21);
            this.cbonambc.TabIndex = 32;
            // 
            // cbothangbc
            // 
            this.cbothangbc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbothangbc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbothangbc.FormattingEnabled = true;
            this.cbothangbc.Location = new System.Drawing.Point(67, 8);
            this.cbothangbc.Name = "cbothangbc";
            this.cbothangbc.Size = new System.Drawing.Size(44, 21);
            this.cbothangbc.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(123, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Năm :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tháng :";
            // 
            // cmdin
            // 
            this.cmdin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdin.Image = ((System.Drawing.Image)(resources.GetObject("cmdin.Image")));
            this.cmdin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdin.Location = new System.Drawing.Point(73, 92);
            this.cmdin.Name = "cmdin";
            this.cmdin.Size = new System.Drawing.Size(93, 30);
            this.cmdin.TabIndex = 8;
            this.cmdin.Tag = "";
            this.cmdin.Text = "In";
            this.cmdin.UseVisualStyleBackColor = false;
            this.cmdin.Click += new System.EventHandler(this.cmdin_Click);
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
            this.tabItem2.ContentPanel.Controls.Add(this.panel1);
            this.tabItem2.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.StretchHorizontally = false;
            this.tabItem2.Text = "Bảo hiểm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.cbonambh);
            this.panel1.Controls.Add(this.cbothangbh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmdinbh);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 130);
            this.panel1.TabIndex = 4;
            // 
            // cbonambh
            // 
            this.cbonambh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbonambh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbonambh.FormattingEnabled = true;
            this.cbonambh.Location = new System.Drawing.Point(167, 26);
            this.cbonambh.Name = "cbonambh";
            this.cbonambh.Size = new System.Drawing.Size(57, 21);
            this.cbonambh.TabIndex = 32;
            // 
            // cbothangbh
            // 
            this.cbothangbh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbothangbh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbothangbh.FormattingEnabled = true;
            this.cbothangbh.Location = new System.Drawing.Point(65, 26);
            this.cbothangbh.Name = "cbothangbh";
            this.cbothangbh.Size = new System.Drawing.Size(46, 21);
            this.cbothangbh.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Năm :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tháng :";
            // 
            // cmdinbh
            // 
            this.cmdinbh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdinbh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdinbh.Image = ((System.Drawing.Image)(resources.GetObject("cmdinbh.Image")));
            this.cmdinbh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdinbh.Location = new System.Drawing.Point(79, 75);
            this.cmdinbh.Name = "cmdinbh";
            this.cmdinbh.Size = new System.Drawing.Size(93, 30);
            this.cmdinbh.TabIndex = 8;
            this.cmdinbh.Tag = "";
            this.cmdinbh.Text = "In";
            this.cmdinbh.UseVisualStyleBackColor = false;
            this.cmdinbh.Click += new System.EventHandler(this.cmdinbh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Location = new System.Drawing.Point(92, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "BÁO CÁO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Location = new System.Drawing.Point(93, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "LƯƠNG - BẢO HIỂM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::QuanLyNhanSu.Properties.Resources.avedesk;
            this.pictureBox1.Location = new System.Drawing.Point(9, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmchonbcluong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 249);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radTabStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmchonbcluong";
            this.Text = "Chọn báo cáo lương";
            this.Load += new System.EventHandler(this.frmchonbcluong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radTabStrip1)).EndInit();
            this.radTabStrip1.ResumeLayout(false);
            this.tabItem1.ContentPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabItem2.ContentPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTabStrip radTabStrip1;
        private Telerik.WinControls.UI.TabItem tabItem1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboto;
        private System.Windows.Forms.ComboBox cbophong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbonambc;
        private System.Windows.Forms.ComboBox cbothangbc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cmdin;
        private Telerik.WinControls.UI.TabItem tabItem2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbonambh;
        private System.Windows.Forms.ComboBox cbothangbh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdinbh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

    }
}