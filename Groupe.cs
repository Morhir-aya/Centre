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
    public partial class Groupe : Form
    {
        public Groupe()
        {
            InitializeComponent();
        }
        public static bool update;
        public static int up;
        private void labelG_Click(object sender, EventArgs e)
        {

        }

        private void btnNewG_Click(object sender, EventArgs e)
        {
            FormGroupe form1 = new FormGroupe();
            form1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Login.connection.Open();
            SqlDataAdapter dt = new SqlDataAdapter("select * from Groupe; ", Login.connection);
            DataTable data= new DataTable();
            dt.Fill(data);
            Login.connection.Close();   
            dataGridViewG.DataSource=data;
        }

        private void dataGridViewG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Login.connection.Open();
            SqlDataAdapter data = new SqlDataAdapter();
            if(e.ColumnIndex == 0)
            {
                Login.connection.Close();
                FormGroupe frm = new FormGroupe();
                update = true;
                up = int.Parse(dataGridViewG.Rows[e.RowIndex].Cells[2].Value.ToString());
                frm.ShowDialog();
           
              

                
                
                
            }
            if(e.ColumnIndex == 1)
            {

                 string sql = string.Format("delete from groupe where id_groupe = {0};",dataGridViewG.Rows[e.RowIndex].Cells[2].Value );
                data.DeleteCommand = new SqlCommand(sql, Login.connection);
                data.DeleteCommand.ExecuteNonQuery();
                //MessageBox.Show(""+dataGridViewG.Rows[e.RowIndex].Cells[2].Value);

            }
            Login.connection.Close();
        }

        private void pictureBoxG_Click(object sender, EventArgs e)
        {
            SqlDataAdapter data=new SqlDataAdapter("select * from groupe where id_groupe="+ int.Parse(textSearchG.Text)+";",Login.connection);
             DataTable dt = new DataTable();    
            data.Fill(dt);
            dataGridViewG.DataSource=dt;
        }
    }
}
