using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek010_SayılarıBiçimlendirme_E_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // E: tam veya ondalık sayıların 10 üzeri formatına gösterimi için kullanılır.
            double sayi = 2;
            MessageBox.Show(sayi.ToString("E"));
            int sayi2 = 10;
            MessageBox.Show(sayi2.ToString("E"));
        }
    }
}
