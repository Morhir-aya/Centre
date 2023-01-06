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

        private void refresh_Click(object sender, EventArgs e)
        {
            Login.connection.Open();
            SqlDataAdapter dt = new SqlDataAdapter("select * from Matiere; ", Login.connection);
            DataTable data = new DataTable();
            dt.Fill(data);
            Login.connection.Close();
            dataGridViewM.DataSource = data;
        }

        private void pictureBoxM_Click(object sender, EventArgs e)
        {
            SqlDataAdapter data = new SqlDataAdapter("select * from Matiere where id_matiere=" + int.Parse(textSearchM.Text) + ";", Login.connection);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridViewM.DataSource = dt;
        }

        private void dataGridViewM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Login.connection.Open();
            SqlDataAdapter data = new SqlDataAdapter();
            if (e.ColumnIndex == 0)
            {
                Login.connection.Close();
                FormGroupe frm = new FormGroupe();
                Groupe.update = true;
                Groupe.up = int.Parse(dataGridViewM.Rows[e.RowIndex].Cells[2].Value.ToString());
                frm.ShowDialog();





            }
            if (e.ColumnIndex == 1)
            {

                string sql = string.Format("delete from Matiere where id_matiere = {0};", dataGridViewM.Rows[e.RowIndex].Cells[2].Value);
                data.DeleteCommand = new SqlCommand(sql, Login.connection);
                data.DeleteCommand.ExecuteNonQuery();
                //MessageBox.Show(""+dataGridViewG.Rows[e.RowIndex].Cells[2].Value);

            }
            Login.connection.Close();
        }
    }
}
