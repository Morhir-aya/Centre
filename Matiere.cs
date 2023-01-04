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
    public partial class Matiere : Form
    {
        public Matiere()
        {
            InitializeComponent();
        }

        private void btnNewM_Click(object sender, EventArgs e)
        {
            FormMatiere form2 = new FormMatiere();
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
