using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeorgiApostolov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Visible)
            {
                pictureBox6.Visible = true;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            
        }
    }
}
