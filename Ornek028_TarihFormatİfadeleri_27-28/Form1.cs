using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek028_TarihFormatİfadeleri_27_28
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
             * d: Tarihin kısa formatta yazılmasını sağlar.
             * D: Tarihin uzun formatta yazılmasını sağlar.
             * f: Tarih ve saati birlikte yazar.
             * dd: Sadece günü gösterir
             * ddd: Günün kısa adını gösterir.
             * dddd: Günün uzun adını gösterir.
             * M: Ayı gösterir. ay-gün
             * %M: Tek başına ay için kullanılır.
             * MM: Ayın kaçıncı ay olduğunu gösterir.
             * MMM: Ayın kısa adını gösterir.
             * MMMM: Ayın uzun adını gösterir.
             * yy: Yılı iki haneli olark gösterir.
             * yyyy: Yılı dört haneli olarak gösterir.
             * t: Saati gösterir.
             * %m: Dakikayı gösterir.
             * mm: Dakikayı tek haneliyse 01 formatında gösterir.
             * h: Zamanın saat kısmını gösterir.
             * s: Saniyeyi gösterir.
             * ss: Saniye tek haneliyse 01 formatında gösterir.
             *  %h: Saati 12 saatlik formatta gösterir.
             * hh: Saati 12 saatlik, iki haneli gösterir.
             * %H: Saati 24 saatlik formatta gösterir.
             * HH: Saati 24 saatlik, iki haneli gösterir. 
             */

            MessageBox.Show(String.Format("Tarih = {0:d}", DateTime.Now));
            MessageBox.Show(String.Format("Tarih = {0:M}", DateTime.Now));
            MessageBox.Show(String.Format("Tarih = {0:t}", DateTime.Now));
            MessageBox.Show(String.Format("Tarih = {0:%m}", DateTime.Now));
        }
    }
}
