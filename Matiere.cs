﻿using System;
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
            FormGroupe form2 = new FormGroupe();
            form2.ShowDialog();
        }
    }
}