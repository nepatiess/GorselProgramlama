using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa99_MessageBoxSimgeler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * MessageBoxIcon.Error
             * MessageBoxIcon.Question
             * MessageBoxIcon.Exclamation
             * MessageBoxIcon.Information
             * MessageBoxIcon.Asterisk
             * MessageBoxIcon.Stop
             * MessageBoxIcon.Warning
             * MessageBoxIcon.Hand
             * MessageBoxIcon.None
             */

            MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Onay", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.None);

        }
    }
}
