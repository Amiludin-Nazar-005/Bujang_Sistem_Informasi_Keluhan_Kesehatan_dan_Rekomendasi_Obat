using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;

namespace RsIndosiar
{
    public partial class Cetak: Form
    {
        int id;
        static string connStr =
        @"Data Source=10.39.198.11,1433;
Initial Catalog=RsIndosiar;
User ID=rsuser;
Password=123;";
        public Cetak(int idDiagnosa)
        {
            InitializeComponent();

            id = idDiagnosa;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
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

        WHERE id_diagnosa=@id";

            SqlCommand cmd =
        new SqlCommand(query, conn);


            cmd.Parameters.AddWithValue(
            "@id",
            id
            );

            SqlDataAdapter da =
            new SqlDataAdapter(cmd);


            DataSet ds =
            new DataSet();


            da.Fill(ds, "Diagnosa");


            ReportDiagnosa report =
            new ReportDiagnosa();


            report.SetDataSource(ds);


            crystalReportViewer1.ReportSource =
            report;


            crystalReportViewer1.Refresh();
        }
    }
}
