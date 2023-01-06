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
    public partial class FormMatiere : Form
    {
        public FormMatiere()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddM_Click(object sender, EventArgs e)
        {
            SqlDataAdapter ds = new SqlDataAdapter();
            if (Groupe.update)
            {
                Login.connection.Open();
                string sql = string.Format("update Matiere set nom_matiere='{0}',id_etudiant={1} where id_matiere={2};", textNomM.Text, int.Parse(textPrenomM.Text), Groupe.up);
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
                    string sql = string.Format("insert into Matiere(Nom_matiere,id_etudiant) values('{0}',{1});", textNomM.Text, int.Parse(textPrenomM.Text));
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

        private void lbltextM_Click(object sender, EventArgs e)
        {

        }

        private void panelM3_Click(object sender, EventArgs e)
        {

        }

        private void panelM3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
