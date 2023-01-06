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
    public partial class Etudiant : Form
    {
        
       

        public Etudiant()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormEtudiant form = new FormEtudiant();
            form.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Paye_etudiant form = new Paye_etudiant();
            form.ShowDialog();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Login.connection.Open();
            SqlDataAdapter dt = new SqlDataAdapter("select * from Etudiant; ", Login.connection);
            DataTable data = new DataTable();
            dt.Fill(data);
            Login.connection.Close();
            dataGridView1.DataSource = data;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter data = new SqlDataAdapter("select * from Etudiant where id_etudiant=" + int.Parse(textSearch.Text) + ";", Login.connection);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Login.connection.Open();
            SqlDataAdapter data = new SqlDataAdapter();
            if (e.ColumnIndex == 0)
            {
                Login.connection.Close();
                FormEtudiant frm = new FormEtudiant();
                Groupe.update = true;
                Groupe.up = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                frm.ShowDialog();





            }
            if (e.ColumnIndex == 1)
            {
                
                string sql = string.Format("delete from Etudiant where id_etudiant = {0};", dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                data.DeleteCommand = new SqlCommand(sql, Login.connection);
                data.DeleteCommand.ExecuteNonQuery();
                //MessageBox.Show(""+dataGridViewG.Rows[e.RowIndex].Cells[2].Value);

            }
            Login.connection.Close();
        }

        private void panelG3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
