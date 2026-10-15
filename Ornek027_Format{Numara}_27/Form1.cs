using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek027_Format_Numara__27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad, yer;
            DateTime tarih;
            ad = "Zeynep";
            soyad = "Koz";
            yer = "İstanbul";
            tarih = DateTime.Now;

            MessageBox.Show(String.Format("Sayın {0} {1}, {2} tarihinde {3} ilinde yapılacak" +
                "olan il dernek yönetim kuruluna davetlisiniz.",
                ad, soyad, tarih.ToShortDateString(), yer));


            // Aynı işlem + operatörü kullanılarak yapıldı.
            MessageBox.Show("Sayın " + ad + " " + soyad + ", " + tarih.ToShortDateString() + " tarihinde " +
                yer + " ilinde yapılacak olan il dernek yönetim kuruluna davetlesiniz.");
        }
    }
}
