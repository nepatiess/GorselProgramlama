using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek009_SayılarıBiçimlendirme_Nsayı_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // N0: sayının binlik basamaklarına ayrılmasını sağlar.
            // Yazılan sayı değeri kadar ondalık kısımdaki gösterimi gerçekleştirir.
            double sayi = 555000000000;
            MessageBox.Show(sayi.ToString("N0"));
            int sayi2 = 111111111;
            MessageBox.Show(sayi2.ToString("N0"));
        }
    }
}
