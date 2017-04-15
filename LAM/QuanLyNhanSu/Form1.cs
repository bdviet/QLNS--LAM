//Downloaded from
//Visual C# Kicks - http://vckicks.110mb.com/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class Form1 : TransDialog
    {

        public Form1()
        {
            InitializeComponent();
            
            
            
            //Needed to make the custom shaped Form
            this.FormBorderStyle = FormBorderStyle.None;
            this.Width = this.BackgroundImage.Width;
            this.Height = this.BackgroundImage.Height;

            //Slow version
            //this.Region = BitmapToRegion.getRegion((Bitmap)this.BackgroundImage, Color.FromArgb(0, 255, 0), 100);
 
            //Fast version
            this.Region = BitmapToRegion.getRegionFast((Bitmap)this.BackgroundImage, Color.FromArgb(0, 255, 0), 100);
        }

        Point lastPoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void exotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //System.Diagnostics.Process.Start("http://vckicks.110mb.com");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 5000;
            timer1.Start();  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
           
        }
    }
}