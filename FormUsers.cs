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
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlDataAdapter ds = new SqlDataAdapter();
            if (Groupe.update)
            {
                Login.connection.Open();
                string sql = string.Format("update utilisateur set username='{0}',password='{1}'where id_user={2};", textNom.Text, textPrenom.Text, Groupe.up);
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
                    string sql = string.Format("insert into utilisateur(username,password, statut) values('{0}','{1}',0);", textNom.Text, textPrenom.Text);
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
