using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek015_SayılarıBiçimlendirme_Xsayı_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Xsayı: hexadecimal gösteriminin belirlenen sayı hanesinde gösterimini sağlar.
            int sayi2 = 26520;
            MessageBox.Show(sayi2.ToString("X4"));
        }
    }
}
