using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek002_Bolme2_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            float sonuc1, sonuc2;
            sayi1 = 17;
            sayi2 = 4;
            sonuc1 = sayi1 / sayi2;
            sonuc2 = (float)sayi1 / sayi2;

            MessageBox.Show(
                "17/4 =" +
                "\nNormal bölme: " + sonuc1 +
                "\nFloat bölme: " + sonuc2
               );
        }
    }
}
