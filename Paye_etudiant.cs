using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apk
{
    public partial class Paye_etudiant : Form
    {
        public Paye_etudiant()
        {
            InitializeComponent();
        }

        private void btnNewpe_Click(object sender, EventArgs e)
        {
            Paya_etd form = new Paya_etd();
            form.ShowDialog();
        }
    }
}
