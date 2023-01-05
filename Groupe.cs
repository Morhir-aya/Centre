using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Login.connection.Open();
            SqlDataAdapter dt = new SqlDataAdapter("select * from Groupe; ", Login.connection);
            DataTable data= new DataTable();
            dt.Fill(data);
            Login.connection.Close();   
            dataGridViewG.DataSource=data;
        }
    }
}
