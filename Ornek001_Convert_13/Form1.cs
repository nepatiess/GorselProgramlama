using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek001_Convert_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i1 = Convert.ToInt16(5.1); //i=5 olur
            // round to even / banker's rounding..
            int i2 = Convert.ToInt16(8.5); //i=8 olur. En yakın çift sayi
            int i3 = Convert.ToInt16(4.55); //i=5 olur
            int i4 = Convert.ToInt16(9.9); //i=10 olur
            int i5 = Convert.ToInt16(-2.6); //i=-3 olur

            MessageBox.Show("i1 = 5.1 -->" + i1.ToString());
            MessageBox.Show("i2 = 8.5 -->" + i2.ToString() + 
                "\nçift sayıya gider");
            MessageBox.Show("i3 = 4.55 -->" + i3.ToString());
            MessageBox.Show("i4 = 9.9 -->" + i4.ToString());
            MessageBox.Show("i5 = -2.6 -->" + i5.ToString());
        }
    }
}
