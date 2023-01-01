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
      
        private  string CN = "Data Source=DESKTOP-BAEPGCE;Initial Catalog=Center;Integrated Security=True";
        public static SqlConnection connection=new SqlConnection();
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
            string requet = String.Format("select * from login where username='{0}' and passwod='{1}';", textBox1.Text, textBox2.Text);
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
            }
            
        }
    }
}
