using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGS_DEPLOYMENTPROJECT
{
    public partial class Form1 : Form
    {
        Thread BackGroundThread; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           BackGroundThread = new Thread(() => Navigation());
            BackGroundThread.IsBackground = true;
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            BackGroundThread.Abort();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
          


            //new Thread(() => Navigation()) { IsBackground = true }.Start();
        }
        private void Navigation() {
            TextBox.CheckForIllegalCrossThreadCalls = false;
            int i =0;
            while (true) {

                Thread.Sleep(500);
                i++;
                textBox1.Text = Convert.ToString(i);

            }
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            BackGroundThread.Start();
            

        }
    }
}
