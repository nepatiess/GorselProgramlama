using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek029_SayıFormatlarıİfadeleri_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * C: para birimini gösterir.
             * E: 10 üzeri biçiminde gösterir.
             * P: yüzde(%) olarak gösterir.
             * X: hexadecimal formatta gösterir.
             * N: binlik basamaklara ayırarak gösterir.
             * F: ondalık sayı olarak gösterir.
             * 0: sayıların önüne istenilen sayıda sıfır (0) göstermek için kullanılır.
             */

            MessageBox.Show(String.Format("Sayı = {0:C}", 458200));
            MessageBox.Show(String.Format("Sayı = {0:E}", 100000000));
            MessageBox.Show(String.Format("Sayı = {0:P}", 85));
            MessageBox.Show(String.Format("Sayı = {0:0}", 4500));

        }
    }
}
