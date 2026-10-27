using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa101_ModalPencere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult cevap;

            cevap=MessageBox.Show("İşlemin çalışması çok uzun sürecektir. Devam edilsin mi?",
                "Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if(cevap == DialogResult.Yes)
            {
                decimal sayi = 0;
                for(int i = 0; i < 10000000; i++)
                {
                    sayi += 1;
                }

                MessageBox.Show("Sonuç= " + sayi.ToString(), "İşlem Sonucu",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
