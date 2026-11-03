using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa130_KeyDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // Ctrl tuşu basılı ise
            if (e.Control)
            {
                // yön tuşları basıldığında hareket ettir
                if (e.KeyCode == Keys.Left)
                {
                    textBox1.Left = textBox1.Left - 5;
                }
                else if (e.KeyCode == Keys.Right)
                {
                    textBox1.Left = textBox1.Left + 5;
                }
                else if (e.KeyCode == Keys.Up)
                {
                    textBox1.Top = textBox1.Left - 5;
                }
                else if (e.KeyCode == Keys.Down)
                {
                    textBox1.Top = textBox1.Left + 5;
                }
            }

            // Alt tuşuna basıldığında
            if (e.Alt)
            {
                // yön tuşları basıldığında hareket ettir
                if (e.KeyCode == Keys.Left)
                {
                    textBox1.Width = textBox1.Width - 5;
                }
                else if (e.KeyCode == Keys.Right)
                {
                    textBox1.Width = textBox1.Width + 5;
                }
                else if (e.KeyCode == Keys.Up)
                {
                    textBox1.Height = textBox1.Height - 5;
                }
                else if (e.KeyCode == Keys.Down)
                {
                    textBox1.Height = textBox1.Height + 5;
                }
            }

            // F5 tuşuna basıldığında
            if (e.KeyCode == Keys.F5)
            {
                // Alt F5 tuşu basıldıysa büyük harf yap
                if (e.Alt)
                {
                    textBox1.Text = textBox1.Text.ToUpper();
                }

                // Ctrl F5 tuşuna basıldıysa küçük harf yap
                if (e.Control)
                {
                    textBox1.Text = textBox1.Text.ToLower();
                }
            }

            // Shift Backspace tuşuna basıldıysa tümünü sil
            if (e.Shift)
            {
                if(e.KeyCode == Keys.Back)
                {
                    textBox1.Text = "";
                }
            }

            // F10 tuşuna basıldıysa programı sonlandır.
            if(e.KeyCode == Keys.F10)
            {
                Close();
            }

            // Formun başlığında basılan tuşların bilgisini göster
            this.Text = "Basılan tuşun sayısal kodu: " + e.KeyValue.ToString() +
                    "Sembolik adı: " + e.KeyCode.ToString();



        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Multiline = true;
        }
    }
}
