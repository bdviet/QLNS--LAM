namespace QuanLyNhanSu
{
    partial class frmchonbcnv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmchonbcnv));
            this.radTabStrip1 = new Telerik.WinControls.UI.RadTabStrip();
            this.tabItem1 = new Telerik.WinControls.UI.TabItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboto = new System.Windows.Forms.ComboBox();
            this.cbophong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radTabStrip1)).BeginInit();
            this.radTabStrip1.SuspendLayout();
            this.tabItem1.ContentPanel.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.tabItem1});
            this.radTabStrip1.Location = new System.Drawing.Point(12, 79);
            this.radTabStrip1.Name = "radTabStrip1";
            this.radTabStrip1.ScrollOffsetStep = 5;
            this.radTabStrip1.Size = new System.Drawing.Size(274, 156);
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
            this.tabItem1.Text = "Báo cáo nhân sự";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.cboto);
            this.panel2.Controls.Add(this.cbophong);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmdin);
            this.panel2.Location = new System.Drawing.Point(15, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 112);
            this.panel2.TabIndex = 6;
            // 
            // cboto
            // 
            this.cboto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboto.FormattingEnabled = true;
            this.cboto.Location = new System.Drawing.Point(67, 46);
            this.cboto.Name = "cboto";
            this.cboto.Size = new System.Drawing.Size(158, 21);
            this.cboto.TabIndex = 36;
            // 
            // cbophong
            // 
            this.cbophong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbophong.FormattingEnabled = true;
            this.cbophong.Location = new System.Drawing.Point(67, 18);
            this.cbophong.Name = "cbophong";
            this.cbophong.Size = new System.Drawing.Size(158, 21);
            this.cbophong.TabIndex = 35;
            this.cbophong.SelectionChangeCommitted += new System.EventHandler(this.cbophong_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Tổ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "Phòng :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::QuanLyNhanSu.Properties.Resources.MSN_Messenger_6;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cmdin
            // 
            this.cmdin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdin.Image = ((System.Drawing.Image)(resources.GetObject("cmdin.Image")));
            this.cmdin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdin.Location = new System.Drawing.Point(73, 73);
            this.cmdin.Name = "cmdin";
            this.cmdin.Size = new System.Drawing.Size(93, 30);
            this.cmdin.TabIndex = 8;
            this.cmdin.Tag = "";
            this.cmdin.Text = "In";
            this.cmdin.UseVisualStyleBackColor = false;
            this.cmdin.Click += new System.EventHandler(this.cmdin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(109, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "BÁO CÁO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(166, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "NHÂN SỰ";
            // 
            // frmchonbcnv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 246);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radTabStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmchonbcnv";
            this.Text = "Chọn báo cáo nhân sự";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmchonbcnv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radTabStrip1)).EndInit();
            this.radTabStrip1.ResumeLayout(false);
            this.tabItem1.ContentPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Button cmdin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}