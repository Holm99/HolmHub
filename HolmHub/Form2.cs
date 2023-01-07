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
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace HolmHub
{
    
    public partial class Form2 : Form
    {

        static string FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\HolmHub";
        static string LicenseName = "ClientLicense.dat";
        static string LicensePath = FolderPath + "\\" + LicenseName;

        private delegate void EventHandler(object sender, EventArgs e);

        //Checks if HolmHub folder in LocalAppData exists, if not it creates it.
        private void Event1(object? sender, EventArgs e)
        {
            Debug.WriteLine("Test");

            string FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\HolmHub";
            if (Directory.Exists(FolderPath))
            {
                Debug.WriteLine("Folder exists");
            }
            else
            {
                Directory.CreateDirectory(FolderPath);
                Debug.WriteLine("Folder created");
            }

        }

        //Checks if ClientLicense exists, if not prompt user to insert it.
        private void Event2(object? sender, EventArgs e)
        {
            if (File.Exists(LicensePath))
            {
                Debug.WriteLine("File exists");
            }
            else
            {
                Debug.WriteLine("File does not exist");
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Select ClientLicense.dat";
                ofd.Filter = "ClientLicense.dat|ClientLicense.dat";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
                MessageBox.Show("Select ClientLicense.dat which can be downloaded from our website");
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    File.Move(ofd.FileName, FolderPath + "\\" + LicenseName);
                    Debug.WriteLine("File moved");
                }
                else
                {
                    Debug.WriteLine("File could not be moved");
                }
            }
        }

        public Form2()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(Event1);
            this.Load += new System.EventHandler(Event2);
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

            //Validates license from ClientLicense.dat
            string base64String = File.ReadAllText(LicensePath);
            string SteppingStone = Encoding.UTF8.GetString(Convert.FromBase64String(base64String));
            string decodedString = Encoding.UTF8.GetString(Convert.FromBase64String(SteppingStone));
            Debug.WriteLine(decodedString);

            string[] values = decodedString.Split(";");

            //string PublicServer = values[0];
            string Host = values[0];
            string Username = values[1];
            string Password = values[2];
            string Database = values[3];

            Debug.WriteLine(Host);
            Debug.WriteLine(Username);
            Debug.WriteLine(Password);
            Debug.WriteLine(Database);

            //Checks hosts connectivity and loads form accordingly
            Ping ping = new Ping();
            PingReply pingReply = ping.Send(Host);
            if (pingReply.Status == IPStatus.Success)
            {
                Debug.WriteLine("Public server is online");
                this.FormBorderStyle = FormBorderStyle.None;
                this.Text = "HolmHub - Connect";
                this.BackColor = Color.FromArgb(50, 71, 87);
                this.Size = new Size(250, 300);
            }
            else
            {
                MessageBox.Show("Host is unreachable");
                this.Close();
                return;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }
    }
}