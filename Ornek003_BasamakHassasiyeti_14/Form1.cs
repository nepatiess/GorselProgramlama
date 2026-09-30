using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek003_BasamakHassasiyeti_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {      
            float sayi1 = 9876543210123456789;
            double sayi2 = 9876543210123456789;
            decimal sayi3 = 9876543210123456789;

            MessageBox.Show(sayi1.ToString(), "Float değeri");
            MessageBox.Show(sayi2.ToString(), "Double değeri");
            MessageBox.Show(sayi3.ToString(), "Decimal değeri");
        }
    }
}
