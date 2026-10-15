using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek033_StringİfadeleriTariheÇevirme_32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime tarih;

            // Amerikan tarih formatı: Ay/Gün/Yıl
            var kultur = new System.Globalization.CultureInfo("en-US");

            // TryParse, girilen metnin tarihe çevrilip çevrilemeyeceğini kontrol eder.
            if (DateTime.TryParse(textBox1.Text, kultur,
                System.Globalization.DateTimeStyles.None, out tarih))
            {
                // Tarihi Türkçe gün/ay/yıl formatında gösterir.
                MessageBox.Show("Tarih: " + tarih.ToString("dd.MM.yyyy"));
            }

        }
    }
}
