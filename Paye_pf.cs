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
    public partial class Paye_pf : Form
    {
        public Paye_pf()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddpp_Click(object sender, EventArgs e)
        {
            SqlDataAdapter ds = new SqlDataAdapter();
            if (Groupe.update)
            {
                Login.connection.Open();
                string sql = string.Format("update Paye_professeur set id_prof={0},mois='{1}' where id_paye_pf={2};", int.Parse(textNompp.Text), textPrenompp.Text,  Groupe.up);
                ds.UpdateCommand = new SqlCommand(sql, Login.connection);
                ds.UpdateCommand.ExecuteNonQuery();
                Login.connection.Close();
                this.Close();
                Groupe.update = false;

            }
            else
            {
                Login.connection.Open();

                try
                {
                    string sql = string.Format("insert into Paye_professeur(id_prof,mois) values({0},'{1}');", int.Parse(textNompp.Text), textPrenompp.Text);
                    ds.InsertCommand = new SqlCommand(sql, Login.connection);
                    ds.InsertCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Login.connection.Close();
                this.Close();
            }

        }
    }
}
