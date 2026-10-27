using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa110_FontFamily
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Bilgisayarda kullanılabilen font ailelerini alır.
            FontFamily[] fontlar = FontFamily.GetFamilies(e.Graphics);

            Font fnt = null;

            // x ve y, yazıların form üzerindeki konumunu belirler.
            float x = 0, y = 0;
            string ifade;

            for (int i = 0; i < fontlar.Length; i++)
            {
                try
                {
                    // Fontu 10 punto ve normal stil ile oluşturur.
                    fnt = new Font(fontlar[i].Name, 10, FontStyle.Regular);

                    // Fontun adını alır.
                    ifade = fontlar[i].Name;
                }
                catch
                {
                    // Font oluşturulamazsa hata mesajı hazırlanır.
                    ifade = fontlar[i].Name + " bu font görüntülenemedi";

                    fnt = this.Font;
                }

                // Yazıyı seçilen font ile formun üzerine çizer.
                e.Graphics.DrawString(ifade, fnt, Brushes.Black, x, y);

                // Bir sonraki yazının alt satıra geçmesini sağlar.
                y += fnt.Height;

                // Her 20 fonttan sonra yeni sütuna geçer.
                if (((i + 1) % 35) == 0)
                {
                    x = x + 200;
                    y = 0;
                }
            }
        }
    }
}
