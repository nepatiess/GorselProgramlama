using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa123_BringToFront
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.BringToFront();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.BringToFront();
        }
    }
}
