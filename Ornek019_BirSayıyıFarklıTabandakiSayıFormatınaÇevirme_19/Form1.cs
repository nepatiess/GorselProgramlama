using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek019_BirSayıyıFarklıTabandakiSayıFormatınaÇevirme_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            long sayı;
            int taban_degeri;
            string sayı_olusumu = "";

            sayı = int.Parse(textBox1.Text);
            taban_degeri = Convert.ToInt16(textBox2.Text);

            label3.Text = taban_degeri.ToString() + " tabanındaki " +
                          sayı.ToString() + "'in değeri = ";

            long kalan_deger;

            while (sayı >= taban_degeri)
            {
                kalan_deger = sayı % taban_degeri;
                sayı = sayı / taban_degeri;

                if (kalan_deger > 9)
                    sayı_olusumu = (char)(55 + kalan_deger) + sayı_olusumu;
                else
                    sayı_olusumu = kalan_deger + sayı_olusumu;
            }

            // Bölme işlemi bittikten sonra kalan son basamağı ekliyoruz.
            if (sayı > 9)
                sayı_olusumu = (char)(55 + sayı) + sayı_olusumu;
            else
                sayı_olusumu = sayı + sayı_olusumu;

            label4.Text = sayı_olusumu;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
