using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa102_CokSatirliMesajPencereleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox içine birden fazla satıra sahip mesaj yazdırılabilir.
            // Bir alt satıra geçmek için \n satırın başından itibaren olması için de \r ifadeleri kullanılır.

            MessageBox.Show("İşlemin çalışması çok uzun sürecektir.\r\n" +
                "Bunun sonucunda aşağıdaki sorunlarla karşılaşabilirsiniz.\r\n" +
                "1 - Bilgisayarınız kilitlenebilir.\r\n" +
                "2 - İşlem bitene kadar beklemek zorunda kalabilirsiniz.\r\n" +
                "3 - Program kendini kapatabilir.", "Onay",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
        }
    }
}
