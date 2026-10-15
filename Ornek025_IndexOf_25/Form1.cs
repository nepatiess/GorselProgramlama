using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek025_IndexOf_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ifade;
            ifade = "Visual C# ile nesneye yönelik programlama";
            MessageBox.Show(ifade.IndexOf("nesn", 0).ToString());
        }
    }
}
