using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
        }

        private void textBox3_MouseLeave_1(object sender, EventArgs e)
        {
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("game over");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You Win");
        }
    }
}
