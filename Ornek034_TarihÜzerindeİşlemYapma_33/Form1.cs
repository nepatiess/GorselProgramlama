using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek034_TarihÜzerindeİşlemYapma_33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DateTime baslangicTarihi;
            int egitimSuresi;

            // TryParse: Metni tarihe dönüştürmeyi dener.
            // Hatalı girişte exception oluşturmaz.
            if (DateTime.TryParse(textBox1.Text, out baslangicTarihi) &&
                int.TryParse(textBox2.Text, out egitimSuresi))
            {

            // AddDays: Belirtilen gün sayısını tarihe ekler.
                DateTime bitisTarihi = baslangicTarihi.AddDays(egitimSuresi);


            // ToLongDateString: Tarihi uzun biçimde gösterir.
                label4.Text = bitisTarihi.ToLongDateString();
            }
          
        }
    }
}
