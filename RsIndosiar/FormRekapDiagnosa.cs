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
    public partial class FormRekapDiagnosa: Form
    {

        static string connStr =
        @"Data Source=10.39.198.11,1433;
Initial Catalog=RsIndosiar;
User ID=rsuser;
Password=123;";



        int idDiagnosa = 0;
        public FormRekapDiagnosa()
        {
            InitializeComponent();
        }

        private List<ClassDiagnosa> listDiagnosa =
new List<ClassDiagnosa>();




        private void FormRekapDiagnosa_Load(object sender, EventArgs e)
        {
            LoadDiagnosa();
        }

        private void LoadDiagnosa()
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "SELECT * FROM vwDiagnosa";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataDiagnosa.DataSource = dt;

            conn.Close();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            SqlConnection conn =
    new SqlConnection(connStr);


            string query = @"
            SELECT 
            username,
            keluhan,
            hasil_diagnosa,
            obat,
            status,
            tanggal

            FROM Diagnosa

            WHERE tanggal BETWEEN @awal AND @akhir";


            SqlCommand cmd =
            new SqlCommand(query, conn);


            cmd.Parameters.AddWithValue(
            "@awal",
            dtAwal.Value.Date);


            cmd.Parameters.AddWithValue(
            "@akhir",
            dtAkhir.Value.Date);


            SqlDataAdapter da =
            new SqlDataAdapter(cmd);


            DataTable dt =
            new DataTable();


            da.Fill(dt);


            dataDiagnosa.DataSource = dt;
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
             "ID sebelum cetak = " + idDiagnosa
  );


            Cetak f = new Cetak(idDiagnosa);

            f.Show();
        }

        private void dataDiagnosa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                idDiagnosa = Convert.ToInt32(
                    dataDiagnosa.Rows[e.RowIndex]
                    .Cells["id_diagnosa"].Value
                );


                MessageBox.Show(
                    "ID dipilih = " + idDiagnosa
                );

            }

        }

        private void dataDiagnosa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
