using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa132_KeyPreview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tuş olaylarının önce Form tarafından algılanmasını sağlar.
            this.KeyPreview = true;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Basılan tuşun F10 olup olmadığını kontrol eder.
            if (e.KeyCode == Keys.F10)
            {
                // Formu kapatır.
                Close();
            }
        }
    }
}
