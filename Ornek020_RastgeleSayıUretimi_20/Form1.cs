using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek020_RastgeleSayıUretimi_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Oyunlarda (sayısal loto gibi tahmin etme oyunları vb.) veya özel amaçlı programlarda rastgele sayı üretimi kullanılır.
            // RANDOM sııfı kullanılarak belirli şartlarda rastgele sayı üretilebilir.

            Random rastgele = new Random();
            int uretilen_sayı;
            // Next() içine herhangi bir sınır verilmediğinden dolayı 0 - 2.147.483.647 sayıları arasında sayı üretebilir.

            uretilen_sayı = rastgele.Next();

            label1.Text = uretilen_sayı.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int uretilen_sayı2;
            // Next() içine 0 - 101 değeri verildi.

            uretilen_sayı2 = rastgele.Next(0,101);

            label4.Text = uretilen_sayı2.ToString();
        }
    }
}
