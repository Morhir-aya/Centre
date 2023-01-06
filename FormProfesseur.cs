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
    public partial class FormProfesseur : Form
    {
        public FormProfesseur()
        {
            InitializeComponent();
        }

        private void button1pp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddpp_Click(object sender, EventArgs e)
        {
            SqlDataAdapter ds = new SqlDataAdapter();
            if (Groupe.update)
            {
                Login.connection.Open();
                string sql = string.Format("update Professeur set nom='{0}',prenom='{1}' ,Email= '{2}' ,tel= {3},salaire={4}, id_matiere= {5} where id_prof={6};", textNompp.Text, textPrenompp.Text, textBox1pp.Text, int.Parse(textTel.Text), int.Parse(textEmailpp.Text), int.Parse(textBox2pp.Text), Groupe.up);
                ds.UpdateCommand = new SqlCommand(sql, Login.connection);
                ds.UpdateCommand.ExecuteNonQuery();
                Login.connection.Close();
                this.Close();

            }
            else
            {
                Login.connection.Open();

                try
                {
                    string sql = string.Format("insert into Professeur(Nom,prenom,email, tel, salaire, id_matiere) values('{0}','{1}','{2}',{3},{4},{5});", textNompp.Text, textPrenompp.Text, textBox1pp.Text, int.Parse(textTel.Text), int.Parse(textEmailpp.Text), int.Parse(textBox2pp.Text));
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
