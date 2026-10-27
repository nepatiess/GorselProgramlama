using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa102_InputBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad;

            ad = Microsoft.VisualBasic.Interaction.InputBox(
                "Adınızı giriniz:",
                "Kullanıcı Bilgileri",
                ""
            );

            MessageBox.Show("Merhaba " + ad);
        }
    }
}
