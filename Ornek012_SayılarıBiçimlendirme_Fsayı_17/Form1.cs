using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek012_SayılarıBiçimlendirme_Fsayı_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Fsayı: ondalık sayıların virgülden sonraki basamak sayılarına göre gösteriminin yapılmasını sağlar.
            double sayi = 18.486416515;
            MessageBox.Show(sayi.ToString("F2"));
            int sayi2 = 1111111111;
            MessageBox.Show(sayi2.ToString("F3"));
        }
    }
}
