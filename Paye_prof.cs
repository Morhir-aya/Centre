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
    public partial class Paye_prof : Form
    {
        public Paye_prof()
        {
            InitializeComponent();
        }

        private void btnNewpp_Click(object sender, EventArgs e)
        {
            Paye_pf form = new Paye_pf();
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
            SqlDataAdapter dt = new SqlDataAdapter("select * from Paye_professeur; ", Login.connection);
            DataTable data = new DataTable();
            dt.Fill(data);
            Login.connection.Close();
            dataGridViewpp1.DataSource = data;
        }

        private void pictureBoxpp1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter data = new SqlDataAdapter("select * from Paye_professeur where id_paye_pf=" + int.Parse(textSearchpp.Text) + ";", Login.connection);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridViewpp1.DataSource = dt;
        }

        private void dataGridViewpp1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Login.connection.Open();
            SqlDataAdapter data = new SqlDataAdapter();
            if (e.ColumnIndex == 0)
            {
                Login.connection.Close();
                Paye_pf frm = new Paye_pf();
                Groupe.update = true;
                Groupe.up = int.Parse(dataGridViewpp1.Rows[e.RowIndex].Cells[2].Value.ToString());
                frm.ShowDialog();





            }
            if (e.ColumnIndex == 1)
            {

                string sql = string.Format("delete from paye_professeur where id_paye_pf = {0};", dataGridViewpp1.Rows[e.RowIndex].Cells[2].Value);
                data.DeleteCommand = new SqlCommand(sql, Login.connection);
                data.DeleteCommand.ExecuteNonQuery();
                //MessageBox.Show(""+dataGridViewG.Rows[e.RowIndex].Cells[2].Value);

            }
            Login.connection.Close();
        }
    }
}
