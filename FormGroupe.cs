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
    public partial class FormGroupe : Form
    {
        public FormGroupe()
        {
            InitializeComponent();
            
        }

        private void lbltext_Click(object sender, EventArgs e)
        {

        }

        private void btnAddG_Click(object sender, EventArgs e)
        {
            SqlDataAdapter ds = new SqlDataAdapter();
            if (Groupe.update)
            {
                Login.connection.Open();
                string sql = string.Format("update groupe set nom_groupe='{0}',nbr_etudiant={1}where id_groupe={2};", textNomG.Text, int.Parse(textPrenomG.Text), Groupe.up);
                ds.UpdateCommand = new SqlCommand(sql, Login.connection);
                ds.UpdateCommand.ExecuteNonQuery();
                Login.connection.Close();
                this.Close();
                Groupe.update= false;

            }
            else
            {
                Login.connection.Open();

                try
                {
                    string sql = string.Format("insert into Groupe(Nom_groupe,Nbr_etudiant) values('{0}',{1});", textNomG.Text, int.Parse(textPrenomG.Text));
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

        private void labelG1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textNomG_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelG3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
