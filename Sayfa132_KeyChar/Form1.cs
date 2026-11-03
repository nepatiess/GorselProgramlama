using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa132_KeyChar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Rakamların yazıyla karşılıklarını tutan dizi.
            string[] rakamlar = {
        "Sıfır", "Bir", "İki", "Üç", "Dört",
        "Beş", "Altı", "Yedi", "Sekiz", "Dokuz"
    };

            // Basılan tuşun 0 ile 9 arasında olup olmadığını kontrol eder.
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                // Karakteri sayısal dizi indeksine dönüştürür.
                // Örnek: '3' - '0' = 3
                int indeks = e.KeyChar - '0';

                // Rakamın yazıyla karşılığını TextBox'a ekler.
                textBox1.SelectedText = rakamlar[indeks];

                // Basılan rakamın ayrıca yazılmasını engeller.
                e.Handled = true;
            }
        }
    }
}
