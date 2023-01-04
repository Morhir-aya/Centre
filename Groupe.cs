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
    public partial class Groupe : Form
    {
        public Groupe()
        {
            InitializeComponent();
        }

        private void labelG_Click(object sender, EventArgs e)
        {

        }

        private void btnNewG_Click(object sender, EventArgs e)
        {
            FormGroupe form1 = new FormGroupe();
            form1.ShowDialog();
        }
    }
}
