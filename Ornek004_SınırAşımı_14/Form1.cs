using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek004_SınırAşımı_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte x = 250;
            x += 6;

            // neden 0? 250+6=256 oldu. byte en fazla 255 tutar. Taşma olur ve değer başa sarar.
            // 255 --> 0
            MessageBox.Show("248(byte) + 10 = " + x.ToString(), "x'in değeri"); // x = 2 olur
        }
    }
}
