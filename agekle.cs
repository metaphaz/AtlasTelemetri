using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtlasTelemetri
{
    public partial class agekle : Form
    {
        public agekle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.token1 = textBox1.Text;
            Properties.Settings.Default.token2 = textBox2.Text;
            Properties.Settings.Default.token3 = textBox3.Text;
            Properties.Settings.Default.token4 = textBox4.Text;
            Properties.Settings.Default.token5 = textBox5.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void agekle_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.token1;
            textBox2.Text = Properties.Settings.Default.token2;
            textBox3.Text = Properties.Settings.Default.token3;
            textBox4.Text = Properties.Settings.Default.token4;
            textBox5.Text = Properties.Settings.Default.token5;
        }

        private void agekle_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void agekle_Activated(object sender, EventArgs e)
        {
        }
    }
}
