using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Data.SqlClient;
using System.IO;

namespace QuanLyNhanSu.Class
{
    class readFile
    {
        public string strLine1, strLine2, strLine3, strLine4;
        public void readfile()
        {
            try
            {
                
                FileStream aFile = new FileStream(Application.StartupPath+"/config.txt", FileMode.Open);
                StreamReader sr = new StreamReader(aFile);
                string input;
                int i = 1;
                while ((input = sr.ReadLine()) != null)
                {
                    switch (i)
                    {
                        case 1:
                            strLine1 = input;
                            i++;
                            break;
                        case 2:
                            strLine2 = input;
                            i++;
                            break;
                        case 3:
                            strLine3 = input;
                            i++;
                            break;
                        case 4:
                            strLine4 = input;
                            i++;
                            break;
                    }
                }
                aFile.Close();
                
                sr.Close();
            }
            catch(Exception ex)
            {
                //RadMessageBox.Show("\nServer Name hoặc Database Name không đúng !\n", "Thông báo");
                MessageBox.Show(ex.ToString());
                Application.Exit();
            }
        }
        
        public void writefile(string line1, string line2, string line3, string line4)
        {
            FileStream aFile = new FileStream(Application.StartupPath+"/config.txt", FileMode.Open);
            StreamWriter strwriter = new StreamWriter(aFile, Encoding.UTF8);
            
            strwriter.WriteLine("Server:" + line1.Trim());
            strwriter.WriteLine("Database:" + line2.Trim());
            strwriter.WriteLine("Username:" + line3.Trim());
            strwriter.WriteLine("Password:" + line4.Trim());
            strwriter.Flush();
            strwriter.Close();
            aFile.Close();

            FileStream bFile = new FileStream(Application.StartupPath+"/Hinh/config.txt", FileMode.Open);
            StreamWriter strwriter1 = new StreamWriter(bFile, Encoding.UTF8);

            strwriter1.WriteLine("Server:" + line1.Trim());
            strwriter1.WriteLine("Database:" + line2.Trim());
            strwriter1.WriteLine("Username:" + line3.Trim());
            strwriter1.WriteLine("Password:" + line4.Trim());
            strwriter1.Flush();
            strwriter1.Close();
            bFile.Close();

        }

    }
}
