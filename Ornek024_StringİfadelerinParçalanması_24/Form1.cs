using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek024_StringİfadelerinParçalanması_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 200; //yazının kayma hızı ayarlanıyor. 200 ms
            timer1.Enabled = true; // timer kontrolü çalıştırılıyor.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //textbox kontrolünden bulunan yazının ilk karakteri alınıp en sona eklenme işlemi yapılıyor.
            textBox1.Text = textBox1.Text.Substring(1) + textBox1.Text.Substring(0, 1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
