using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa105_Enabled
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            MessageBox.Show("Programla olan bağlantı sağlandı", "Bağlantı durumu", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Enabled = true : Buton kullanılabilir.
            button1.Enabled = true;

            // Enabled = false : Buton pasif olur.
            button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            MessageBox.Show("Programla olan bağlantı sonlandı", "Bağlantı durumu",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
