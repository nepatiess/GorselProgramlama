using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek007_SayılarıBiçimlendirme_Csayi_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // C0: virgülden sonraki basamaklar atılarak ekranda gösterilir.
            double sayi = 555000000000;
            MessageBox.Show(sayi.ToString("C0"));
            int sayi2 = 111111111;
            MessageBox.Show(sayi2.ToString("C0"));
        }
    }
}
