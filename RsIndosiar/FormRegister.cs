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

namespace RsIndosiar
{
    public partial class FormRegister: Form
    {
        static string connStr =
        @"Data Source=10.39.198.11,1433;
Initial Catalog=RsIndosiar;
User ID=rsuser;
Password=123;";
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            if (
           txtNama.Text.Trim() == "" ||
           txtUsername.Text.Trim() == "" ||
           txtEmail.Text.Trim() == "" ||
           txtPassword.Text.Trim() == ""
                )
            {
                MessageBox.Show("Semua data wajib diisi!");
                return;
            }

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("daftarUser", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nama", txtNama.Text);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Akun berhasil dibuat!");

            conn.Close();

            Form1 login = new Form1();
            login.Show();

            this.Hide();
        } 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
