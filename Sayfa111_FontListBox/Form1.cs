using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa111_FontListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // ListBox'ta seçilen fontun adını alır.
                string secilenFont = listBox1.SelectedItem.ToString();

                // Seçilen fontu 16 punto ve normal stil ile uygular.
                richTextBox1.Font = new Font(secilenFont, 16, FontStyle.Regular);
            }
            catch
            {
                // Font uygulanamazsa kullanıcıya uyarı verir.
                MessageBox.Show("Bu font görüntülenemiyor.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Bilgisayarda yüklü font ailelerini alır.
            FontFamily[] fontlar = FontFamily.Families;

            // ListBox'ın önceki içeriğini temizler.
            listBox1.Items.Clear();

            // Bütün fontları tek tek ListBox'a ekler.
            for (int i = 0; i < fontlar.Length; i++)
            {
                listBox1.Items.Add(fontlar[i].Name);
            }
        }
    }
}
