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
    public partial class Professeur : Form
    {
        public Professeur()
        {
            InitializeComponent();
        }

        private void panelG4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewp_Click(object sender, EventArgs e)
        {
            FormProfesseur form = new FormProfesseur();
            form.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Paye_prof form = new Paye_prof();
            form.ShowDialog();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Login.connection.Open();
            SqlDataAdapter dt = new SqlDataAdapter("select * from Professeur; ", Login.connection);
            DataTable data = new DataTable();
            dt.Fill(data);
            Login.connection.Close();
            dataGridView1p.DataSource = data;
        }

        private void pictureBox1p_Click(object sender, EventArgs e)
        {
            SqlDataAdapter data = new SqlDataAdapter("select * from Professeur where id_prof=" + int.Parse(textSearchp.Text) + ";", Login.connection);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1p.DataSource = dt;
        }
    }
}
