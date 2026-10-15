using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek017_BiçimlendirilmişStringIfadeleriSayıyaÇevirme_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            decimal fiyat;

            if (decimal.TryParse(textBox1.Text, out fiyat))
            {
                textBox1.Text = fiyat.ToString("N0");
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal fiyat = decimal.Parse(textBox1.Text);
            int adet = int.Parse(textBox2.Text);

            decimal toplam = fiyat * adet;

            label3.Text = toplam.ToString("C0");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
