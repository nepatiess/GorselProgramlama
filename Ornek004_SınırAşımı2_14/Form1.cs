using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek004_SınırAşımı2_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte x = 248;
            x += 10;

            // neden 2? 248+10=258 oldu. byte en fazla 255 tutar. Taşma olur ve değer başa sarar.
            // 255 --> 0 --> 1 --> 2
            MessageBox.Show("248(byte) + 10 = " + x.ToString(), "x'in değeri"); // x = 2 olur
        }
    }
}
