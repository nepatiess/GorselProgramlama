using System;
using System.Windows.Forms;

namespace Sayfa129_TextChanged
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal sayi1 = 0, sayi2 = 0, sonuc = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // İki TextBox'a da geçerli sayı girilmiş mi kontrol eder.
            if (decimal.TryParse(textBox1.Text, out sayi1) &&
                decimal.TryParse(textBox2.Text, out sayi2))
            {
                // Sayıları çarpar.
                sonuc = sayi1 * sayi2;

                // Sonucu ekrana yazar.
                textBox3.Text = sonuc.ToString();
            }
            else
            {
                // Geçersiz giriş varsa sonucu temizler.
                textBox3.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // İki TextBox'a da geçerli sayı girilmiş mi kontrol eder.
            if (decimal.TryParse(textBox1.Text, out sayi1) &&
                decimal.TryParse(textBox2.Text, out sayi2))
            {
                // Sayıları çarpar.
                sonuc = sayi1 * sayi2;

                // Sonucu ekrana yazar.
                textBox3.Text = sonuc.ToString();
            }
            else
            {
                // Geçersiz giriş varsa sonucu temizler.
                textBox3.Clear();
            }
        }
    }
}