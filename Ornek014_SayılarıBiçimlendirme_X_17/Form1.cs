using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek014_SayılarıBiçimlendirme_X_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // X: sayının hexadecimal formatta (16) gösterilmesini sağlar.
            int sayi2 = 452;
            MessageBox.Show(sayi2.ToString("X"));
        }
    }
}
