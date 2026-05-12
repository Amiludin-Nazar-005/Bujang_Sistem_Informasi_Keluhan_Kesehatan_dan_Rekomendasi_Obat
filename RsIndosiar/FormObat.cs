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
    public partial class FormObat: Form
    {

        string connStr =
        "Data Source=DIAN\\NAZARIN;Initial Catalog=RsIndosiar;Integrated Security=True";

        private void LoadObat()
        {
            SqlConnection conn = new SqlConnection(connStr);

            SqlDataAdapter da =
            new SqlDataAdapter("SELECT nama_obat, deskripsi FROM Obat", conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataObat.DataSource = dt;
        }
        public FormObat()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormObat_Load(object sender, EventArgs e)
        {
            LoadObat();
        }
    }
}
