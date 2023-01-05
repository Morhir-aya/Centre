using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Net;

namespace apk
{
   
    public partial class Login : Form
    {
      
        private  string CN = "Data Source=DESKTOP-BAEPGCE;Initial Catalog=NewCentre3;Integrated Security=True";
        public static SqlConnection connection=new SqlConnection();
        public static bool statut;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* string requet = String.Format("select username,password,statut from utilisateur where username='{0}' and password='{1}';", textBox1.Text, textBox2.Text);
            connection.ConnectionString = CN;
            Stopwatch watch = new Stopwatch(); //using system.diagnostics
            watch.Start();
            WebClient web = new WebClient();
            try
            {
                byte[] bytes = web.DownloadData("https://www.google.com");
                watch.Stop();
                double sec = watch.Elapsed.TotalSeconds;
                double speed = bytes.Count() / sec;
                connection.Open();
                SqlDataAdapter Data = new SqlDataAdapter(requet, connection);
                DataTable dataTable = new DataTable();
                Data.Fill(dataTable);
                if (dataTable.Rows.Count == 1 && (textBox1 != null && textBox2 != null))
                {
                    statut = bool.Parse(dataTable.Rows[0][2].ToString());
                    Espace_Admin espace_Admin = new Espace_Admin();
                    espace_Admin.Show();
                    this.Hide();
                }
                else 
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    MessageBox.Show("Connection unsuccessful");
                }
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("check your internet ");
            }*/
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string requet = String.Format("select username,password,statut from utilisateur where username='{0}' and password='{1}';", textBox1.Text, textBox2.Text);
            connection.ConnectionString = CN;
            
            try
            {
                try {Stopwatch watch = new Stopwatch(); //using system.diagnostics
                watch.Start();
                WebClient web = new WebClient();
                byte[] bytes = web.DownloadData("https://www.google.com");
                watch.Stop();
                double sec = watch.Elapsed.TotalSeconds;
                double speed = bytes.Count() / sec;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                connection.Open();
                SqlDataAdapter Data = new SqlDataAdapter(requet, connection);
                DataTable dataTable = new DataTable();
                Data.Fill(dataTable);
                if (dataTable.Rows.Count == 1 && (textBox1 != null && textBox2 != null))
                {
                    statut = dataTable.Rows[0][2].ToString().ToLower()=="true"?true:false;    
                    Espace_Admin espace_Admin = new Espace_Admin();
                    espace_Admin.Show();
                    this.Hide();
                }
                else
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    MessageBox.Show("Connection unsuccessful");
                }
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("check your connection");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
