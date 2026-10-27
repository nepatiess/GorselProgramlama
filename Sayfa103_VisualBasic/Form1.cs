using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic.Interaction;

namespace Sayfa103_VisualBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;

            // Kullanıcıdan dizinin eleman sayısını alır.
            int elemanSayisi = Convert.ToInt32(
                VB.InputBox("Kaç sayı gireceksiniz?", "Dizi Oluştur", "5")
            );

            // Girilen eleman sayısı kadar dizi oluşturulur.
            int[] sayilar = new int[elemanSayisi];

            listBox1.Items.Clear();

            // Dizinin her elemanı için InputBox açılır.
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = Convert.ToInt32(
                    VB.InputBox((i + 1) + ". sayıyı giriniz:",
                                "Sayı Girişi", "0")
                );

                // Girilen sayı ListBox'a eklenir.
                listBox1.Items.Add(sayilar[i]);

                // Sayılar toplanır.
                toplam += sayilar[i];
            }

            // Dizinin toplamını da ListBox'ta gösterir.
            listBox1.Items.Add("Toplam = " + toplam);
        }
    }
}
