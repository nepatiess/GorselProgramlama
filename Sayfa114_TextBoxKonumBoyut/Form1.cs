using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa114_TextBoxKonumBoyut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TextBox yüksekliğinin değiştirilebilmesi için
            // Multiline özelliğinin true olması gerekir.
            textBox1.Multiline = true;

            // NumericUpDown kontrollerinin maksimum değerleri.
            numericUpDown1.Maximum = 500;
            numericUpDown2.Maximum = 500;
            numericUpDown3.Maximum = 500;
            numericUpDown4.Maximum = 500;

            // TextBox'ın mevcut konum ve boyut değerlerini alır.
            numericUpDown1.Value = textBox1.Left;
            numericUpDown2.Value = textBox1.Top;
            numericUpDown3.Value = textBox1.Width;
            numericUpDown4.Value = textBox1.Height;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Left: TextBox'ı sağa veya sola hareket ettirir.
            textBox1.Left = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            // Top: TextBox'ı yukarı veya aşağı hareket ettirir.
            textBox1.Top = (int)numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            // Width: TextBox'ın genişliğini değiştirir.
            textBox1.Width = (int)numericUpDown3.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            // Height: TextBox'ın yüksekliğini değiştirir.
            textBox1.Height = (int)numericUpDown4.Value;
        }
    }
}