using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek005_SayılarıYuvarlama_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi;
            sayi = 27.684729;

            MessageBox.Show("Tam sayıya yuvarlama: " + Math.Round(sayi, 0).ToString()); // 28
            MessageBox.Show("2 basamaklı yuvarlama: " + Math.Round(sayi, 2).ToString()); // 27.68
            // 27.684729 → 27.685. Yani Math.Round(sayi, 3), virgülden sonra 3 basamak bırakırken 4. basamağa bakıp yuvarladı.
            MessageBox.Show("3 basamaklı yuvarlama: " + Math.Round(sayi, 3).ToString()); // 27.685
        }
    }
}
