using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RsIndosiar
{
    
    public partial class Form1: Form
    {

        string connStr = "Data Source=DIAN\\NAZARIN;Initial Catalog=RsIndosiar;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "SELECT role FROM [User] WHERE username=@u AND password=@p";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@u", txtUsername.Text);
            cmd.Parameters.AddWithValue("@p", txtPassword.Text);

            SqlDataReader rd = cmd.ExecuteReader();


            if (rd.Read())
            {
                string role = rd["role"].ToString();

                if (role == "admin")
                {
                    MessageBox.Show("Login Admin");

                    FormAdmin f = new FormAdmin();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Login User");

                    Dashboard f = new Dashboard();
                    f.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Login gagal!");
            }

            conn.Close();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
