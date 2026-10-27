using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek037_Ticks1_35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bekleme işlmei olarak kullanılmaz.
            double bekle = 0.0;
            bekle = DateTime.Now.Ticks + 5 * 10000000; // 5 * 10000000 --> 5 saniye ifadesini verir. 
            while (DateTime.Now.Ticks < bekle)
            {
                //hiçbir işlem yapılmıyor.
            }
            double bekleme_saniye = bekle / 100000000000000000;
            MessageBox.Show("Bu yazı butona basıldıktan yaklaşık olarak " + bekleme_saniye.ToString("N0") + " saniye sonra ekrana gelmiştir.");
        }
    }
}
