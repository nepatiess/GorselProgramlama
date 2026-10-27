using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa105_Visible
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Program ilk açıldığında staj bilgileri gizlenir.
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Evet seçildiğinde staj bilgileri görünür.
            if (radioButton1.Checked == true)
            {
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;

                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Hayır seçildiğinde staj bilgileri gizlenir.
            if (radioButton2.Checked == true)
            {
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;

                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
            }
        }
    }
}
