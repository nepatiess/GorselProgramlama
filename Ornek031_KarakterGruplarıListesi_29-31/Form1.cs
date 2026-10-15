using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek031_KarakterGruplarıListesi_29_31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //comboBox1 kontrolünde her değişk sıradaki karakter grubu seçildiğinde listbox kontrolünün içi silinir.

            string s;
            //listbox'ta yazılanları alt alta düzgün bir sırayla gelmeleri işlemi için
            // tüm karakterlerin aynı boşlukta ifade edildiği Courier New font tipi kullanılıyor.

            listBox1.Font = new Font("Courier new", 9, FontStyle.Regular);
            listBox1.Items.Add("Karakter Kodu      Karakter ");

            for (int i = 0; i < 255; i++)
            {
                //karakter kodu soldan 4 boşluk bırakılacak şekilde ayarlanıp s string
                //değişkenine atanıyor.
                s = i.ToString().PadLeft(4, ' ');

                //i olarak verilen sayıya karşılık gele karakter bulunup tek satır
                //halinde karakter kodu ve karakterin yazılması sağlanıyor.
                s = s + "                        " + (char)i;

                switch (comboBox1.Text)
                {
                    case "Control":
                        if (Char.IsControl((char)i))
                                listBox1.Items.Add(s);
                        break;

                    case "Digit":
                        if (Char.IsDigit((char)i))
                            listBox1.Items.Add(s);
                        break;

                    case "Letter":
                        if (Char.IsLetter((char)i))
                            listBox1.Items.Add(s);
                        break;

                    case "LetterOrDigit":
                        if (Char.IsLetterOrDigit((char)i))
                            listBox1.Items.Add(s);
                        break;

                    case "Lower":
                        if (Char.IsLower((char)i))
                            listBox1.Items.Add(s);
                        break;

                    case "Number":
                        if (Char.IsNumber((char)i))
                            listBox1.Items.Add(s);
                        break;

                    case "Punctuation":
                        if (Char.IsPunctuation((char)i))
                            listBox1.Items.Add(s);
                        break;

                    case "Seperator":
                        if (Char.IsSeparator((char)i))
                            listBox1.Items.Add(s);
                        break;

                    case "Surrogate":
                        if (Char.IsSurrogate((char)i))
                            listBox1.Items.Add(s);
                        break;

                    case "Symbol":
                        if (Char.IsSymbol((char)i))
                            listBox1.Items.Add(s);
                        break;

                    case "Upper":
                        if (Char.IsUpper((char)i))
                            listBox1.Items.Add(s);
                        break;

                    case "WhiteSpace":
                        if (Char.IsWhiteSpace((char)i))
                            listBox1.Items.Add(s);
                        break;
                }
            }
        }
    }
}
