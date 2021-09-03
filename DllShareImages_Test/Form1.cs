using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DllShareImages_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = DllShareImages.Properties.Resources._00;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = DllShareImages.Properties.Resources._01;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = DllShareImages.Properties.Resources._02;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = DllShareImages.Properties.Resources._03;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = DllShareImages.Properties.Resources._04;
        }
    }
}
