using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek008_SayılarıBiçimlendirme_N_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // N: sayının binlik basamaklarına ayrılmasını sağlar.
            // C formatından farkı: sayının sonuna para birimi eklemez.
            double sayi = 555000000000;
            MessageBox.Show(sayi.ToString("N"));
            int sayi2 = 111111111;
            MessageBox.Show(sayi2.ToString("N"));
        }
    }
}
