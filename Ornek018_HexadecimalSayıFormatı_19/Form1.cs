using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek018_HexadecimalSayıFormatı_19
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

        private void button1_Click(object sender, EventArgs e)
        {
            long decimal_sayı;
            decimal_sayı = long.Parse(textBox1.Text);
            textBox2.Text = decimal_sayı.ToString("X8");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            long hexadecimal_sayı;
            hexadecimal_sayı = long.Parse(textBox2.Text, System.Globalization.NumberStyles.HexNumber);
            textBox1.Text = hexadecimal_sayı.ToString();
        }
    }
}
