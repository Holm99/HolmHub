using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolmHub
{
    public partial class Form2 : Form
    {

        //public delegate void LicenseHandler(Form sender, LicenseEventArgs e);

        ////Checks if HolmHub folder in LocalAppData exists, if not it creates it.
        //private void EventHandler1(Form sender, LicenseEventArgs e)
        //{
        //    // Do something
        //}

        ////Checks if ClientLicense exists, if not pormpt user to insert it.
        //private void Event2(Form sender, EventArgs e)
        //{
        //    // Do something
        //}

        ////Extracts License from ClientLicense.
        //private void Event3(Form sender, EventArgs e)
        //{
        //    string directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "HolmHub");
        //    if (!Directory.Exists(directory))
        //    {
        //        Directory.CreateDirectory(directory);
        //    }

        //    string filepath = Path.Combine(directory, "ClientLicense.dat");
        //    string base64String = File.ReadAllText(filepath);

        //    string SteppingStone = Encoding.UTF8.GetString(Convert.FromBase64String(base64String));
        //    string decodedString = Encoding.UTF8.GetString(Convert.FromBase64String(SteppingStone));
        //    Debug.WriteLine(decodedString);
        //}


        public Form2()
        {
            InitializeComponent();
            //this.Load += new LicenseHandler(EventHandler1);
            //this.Load += new LicenseHandler(Event1);
            //this.Load += new LicenseHandler(Event2);
            //this.Load += new LicenseHandler(Event3);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            //this.TransparencyKey = Color.Gray;
            this.Text = "HolmHub - Connect";
            this.BackColor = Color.FromArgb(50, 71, 87);
            this.Size = new Size(250, 300);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }
    }
}
