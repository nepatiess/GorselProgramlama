using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa100_MessageBoxVardayilanDugme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mesaj pencerelerinde ilk düpme aktiftir. Pencere açıldığında direkt olarak enter tuşuna basıldığında ilk düğme seçilmiş olur.
            MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Onay",
                MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);

            // Bunun için:
            MessageBox.Show("Dosya silinsin mi?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            // MessageBox.Show metodundan kullanıcın hangi düğmeyi seçtiğini belirten bir değer geri gönderilir
            /* DialogResult.OK
             * DialogResult.Cancel
             * DialogResult.Abort
             * DialogResult.Retry
             * DialogResult.Ignore
             * DialogResult.Yes
             * DialogResult.No
             * DialogResult.None
             */
        }
    }
}
