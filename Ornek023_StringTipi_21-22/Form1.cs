using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek023_StringTipi_21_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ifade = textBox1.Text;

            // ToLower() metindeki harfleri küçük harfe çevirir.
            textBox2.Text = ifade.ToLower();

            // Length, string ifadenin toplam karakter sayısını verir.
            label4.Text = "Karakter sayısı: " + ifade.Length;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ifade = textBox1.Text;

            // ToUpper() metindeki harfleri büyük harfe çevirir.
            textBox2.Text = ifade.ToUpper();

            // String aynı zamanda karakter dizisi gibi kullanılabilir.
            // [0] ifadenin ilk karakterini verir.
            if (ifade.Length > 0)
            {
                char ilkKarakter = ifade[0];

                label4.Text = "İlk karakter: " + ilkKarakter +
                              " | Karakter sayısı: " + ifade.Length;
            }
        }
    }
}
