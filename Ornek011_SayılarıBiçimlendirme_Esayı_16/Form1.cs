using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek011_SayılarıBiçimlendirme_Esayı_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Esayı: basamak sayısını ayarlamak için kullanılır.
            double sayi = 45.8641151352;
            MessageBox.Show(sayi.ToString("E4"));
            int sayi2 = 123456789;
            MessageBox.Show(sayi2.ToString("E2"));
        }
    }
}
