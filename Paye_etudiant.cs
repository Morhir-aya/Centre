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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Login.connection.Open();
            SqlDataAdapter dt = new SqlDataAdapter("select * from Paye_etudiant; ", Login.connection);
            DataTable data = new DataTable();
            dt.Fill(data);
            Login.connection.Close();
            dataGridViewpe1.DataSource = data;
        }

        private void pictureBoxpe1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter data = new SqlDataAdapter("select * from Paye_etudiant where id_paye_et=" + int.Parse(textSearchpe.Text) + ";", Login.connection);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridViewpe1.DataSource = dt;
        }

        private void dataGridViewpe1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Login.connection.Open();
            SqlDataAdapter data = new SqlDataAdapter();
            if (e.ColumnIndex == 0)
            {
                Login.connection.Close();
                Paya_etd frm = new Paya_etd();
                Groupe.update = true;
                Groupe.up = int.Parse(dataGridViewpe1.Rows[e.RowIndex].Cells[2].Value.ToString());
                frm.ShowDialog();





            }
            if (e.ColumnIndex == 1)
            {

                string sql = string.Format("delete from Paye_etudiant where id_paye_et = {0};", dataGridViewpe1.Rows[e.RowIndex].Cells[2].Value);
                data.DeleteCommand = new SqlCommand(sql, Login.connection);
                data.DeleteCommand.ExecuteNonQuery();
                //MessageBox.Show(""+dataGridViewG.Rows[e.RowIndex].Cells[2].Value);

            }
            Login.connection.Close();
        }

        private void panelpe3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewpe1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
