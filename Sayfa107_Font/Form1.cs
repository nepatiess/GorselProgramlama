using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa107_Font
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Font boyutu en az 8, en fazla 72 olabilir.
            numericUpDown1.Minimum = 8;
            numericUpDown1.Maximum = 72;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Bold: Yazıyı kalın yapar veya kalınlığı kaldırır.
            // XOR (^) mevcut stilin durumunu tersine çevirir.
            richTextBox1.Font = new Font(richTextBox1.Font,
                richTextBox1.Font.Style ^ FontStyle.Bold);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Italic: Yazıyı eğik yapar veya eğikliği kaldırır.
            richTextBox1.Font = new Font(richTextBox1.Font,
                richTextBox1.Font.Style ^ FontStyle.Italic);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Underline: Yazının altını çizer veya çizgiyi kaldırır.
            richTextBox1.Font = new Font(richTextBox1.Font,
                richTextBox1.Font.Style ^ FontStyle.Underline);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Strikeout: Yazının üstünü çizer veya çizgiyi kaldırır.
            richTextBox1.Font = new Font(richTextBox1.Font,
                richTextBox1.Font.Style ^ FontStyle.Strikeout);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Seçilen değere göre font boyutunu değiştirir.
            // Mevcut kalın, eğik ve altı çizili özellikleri korunur.
            richTextBox1.Font = new Font(
                richTextBox1.Font.Name,
                (float)numericUpDown1.Value,
                richTextBox1.Font.Style);
        }
    }
}