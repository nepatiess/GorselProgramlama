using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek026_StringİfadeyiFormatlama_26_27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Courier New eşit genişlikli karakterler kullanılır.
            // Böylece ListBox içerisindeki sütunlar düzgün hizalanır.
            listBox1.Font = new Font("Courier New", 10, FontStyle.Regular);

            //Sütun başlıkları
            listBox1.Items.Add(
                "Kitap Adı".PadRight(10) +
                "Yazar".PadRight(8) +
                "Tür".PadRight(18) +
                "Sayfa"
                );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // PadRight belirtilen uzunluğa kadar sağa boşluk ekler.
            listBox1.Items.Add(
                textBox1.Text.PadRight(10, ' ') +
                textBox2.Text.PadRight(8, ' ') +
                textBox3.Text.PadRight(18, ' ') +
                textBox4.Text
                );
        }
    }
}
