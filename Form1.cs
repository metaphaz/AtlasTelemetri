using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtlasTelemetri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled  = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string strCmdLine =
            "/C zerotier-cli join 1d71939404c2b5bc";            
            System.Diagnostics.Process.Start("CMD.exe",strCmdLine);*/
            if (netconn()==true)
            {

                label3.Text = "İnternet bağlı.";
                label3.BackColor = Color.FromArgb(124, 252, 0);

            }
            else
            {

                label3.Text = "İnternet bağlantısı yok!";
                label3.BackColor = Color.FromArgb(255, 69, 0); 
                MessageBox.Show("İnternet Bağlantınız Yok!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            string id = networkliste.Text;
            startInfo.Arguments = $"/C zerotier-cli join {id}";
            if (networkliste.SelectedItem == null) {
                MessageBox.Show("Bir bağlantı adresi seçmelisiniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            process.StartInfo = startInfo;
            process.Start();
            label1.Text="Bağlanılıyor...";
            Cursor.Current = Cursors.WaitCursor;
            wait(5000);
            Cursor.Current = Cursors.Default;
            label1.Text="Telemetri Bağlantısı Sağlandı.";
            if (plannerCheck.Checked == true)
            {
                string strCmdLine =
                    "/C \"C:\\missionplanner\\MissionPlanner.exe\" ";            
                System.Diagnostics.Process.Start("CMD.exe",strCmdLine);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            string id = networkliste.Text;       
            startInfo.Arguments = $"/C zerotier-cli leave {id}"; 
            process.StartInfo = startInfo;
            label1.Text="Bağlantı Kesiliyor...";
            Cursor.Current = Cursors.WaitCursor;
            wait(7000);
            Cursor.Current = Cursors.Default;
            process.Start();
            label1.Text="Bağlantı Keslidi";
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Text="Bekleniyor...";
            textBox1.Text= Properties.Settings.Default.pathmp;
            networkliste.Items.Add(Properties.Settings.Default.token1);
            networkliste.Items.Add(Properties.Settings.Default.token2);
            networkliste.Items.Add(Properties.Settings.Default.token3);
            networkliste.Items.Add(Properties.Settings.Default.token4);
            networkliste.Items.Add(Properties.Settings.Default.token5);
            if (netconn()==true)
            {

                label3.Text = "İnternet bağlı.";
                label3.BackColor = Color.FromArgb(124, 252, 0);

            }
            else
            {

                label3.Text = "İnternet bağlantısı yok!";
                label3.BackColor = Color.FromArgb(255, 69, 0);
            }

            if (checkInstalled("ZeroTier One")== true)
            {
                label4.Text = "ZeroTier yüklü.";
            }
            else
            {
                MessageBox.Show("Uygulamayı kullanabilmek için ZeroTier One Yüklemeniz" +
                    "Gerekmektedir!", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = $"/C start www.zerotier.com/download/";
                process.StartInfo = startInfo;
                process.Start();
                Application.Exit();


            }
        }


        private void agekle_Click_1(object sender, EventArgs e)
        {
            agekle form2 = new agekle();

            form2.StartPosition = FormStartPosition.Manual;
            form2.Left = this.Location.X;
            form2.Top  = this.Location.Y;
            form2.ShowDialog();         
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Text="Bekleniyor...";
            textBox1.Text= Properties.Settings.Default.pathmp;
            networkliste.Items.Clear();
            networkliste.Items.Add(Properties.Settings.Default.token1);
            networkliste.Items.Add(Properties.Settings.Default.token2);
            networkliste.Items.Add(Properties.Settings.Default.token3);
            networkliste.Items.Add(Properties.Settings.Default.token4);
            networkliste.Items.Add(Properties.Settings.Default.token5);
            if (netconn()==true)
            {

                label3.Text = "İnternet bağlı.";
                label3.BackColor = Color.FromArgb(124, 252, 0);

            }
            else
            {

                label3.Text = "İnternet bağlantısı yok!";
                label3.BackColor = Color.FromArgb(255, 69, 0);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "exe",
                Filter = "exe files (*.exe)|*.exe",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                Properties.Settings.Default.pathmp = openFileDialog1.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public static bool netconn()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public static bool checkInstalled(string c_name)
        {
            string displayName;

            string registryKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            RegistryKey key = Registry.LocalMachine.OpenSubKey(registryKey);
            if (key != null)
            {
                foreach (RegistryKey subkey in key.GetSubKeyNames().Select(keyName => key.OpenSubKey(keyName)))
                {
                    displayName = subkey.GetValue("DisplayName") as string;
                    if (displayName != null && displayName.Contains(c_name))
                    {
                        return true;
                    }
                }
                key.Close();
            }

            registryKey = @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall";
            key = Registry.LocalMachine.OpenSubKey(registryKey);
            if (key != null)
            {
                foreach (RegistryKey subkey in key.GetSubKeyNames().Select(keyName => key.OpenSubKey(keyName)))
                {
                    displayName = subkey.GetValue("DisplayName") as string;
                    if (displayName != null && displayName.Contains(c_name))
                    {
                        return true;
                    }
                }
                key.Close();
            }
            return false;
        }
    }
}
