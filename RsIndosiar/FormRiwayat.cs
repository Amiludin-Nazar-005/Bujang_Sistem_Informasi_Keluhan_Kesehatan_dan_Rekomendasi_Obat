using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RsIndosiar
{
    class FormRiwayat : Form
    {
        string connStr = "Data Source=DIAN\\NAZARIN;Initial Catalog=RsIndosiar;Integrated Security=True";

        private void InitializeComponent()
        {
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataRiwayat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataRiwayat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(400, 267);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(116, 42);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataRiwayat
            // 
            this.dataRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRiwayat.Location = new System.Drawing.Point(77, 42);
            this.dataRiwayat.Name = "dataRiwayat";
            this.dataRiwayat.RowHeadersWidth = 51;
            this.dataRiwayat.RowTemplate.Height = 24;
            this.dataRiwayat.Size = new System.Drawing.Size(762, 150);
            this.dataRiwayat.TabIndex = 1;
            // 
            // FormRiwayat
            // 
            this.ClientSize = new System.Drawing.Size(920, 460);
            this.Controls.Add(this.dataRiwayat);
            this.Controls.Add(this.btnRefresh);
            this.Name = "FormRiwayat";
            this.Load += new System.EventHandler(this.FormRiwayat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataRiwayat)).EndInit();
            this.ResumeLayout(false);

        }

        private Button btnRefresh;
        private DataGridView dataRiwayat;

        private void FormRiwayat_Load(object sender, EventArgs e)
        {
            LoadRiwayat();
        }

        private void LoadRiwayat()
        {
            SqlConnection conn = new SqlConnection(connStr);

            string query = @"
            SELECT r.id_riwayat, u.username, r.tanggal, r.keluhan, r.hasil_rekomendasi
            FROM Riwayat r
            JOIN [User] u ON r.id_user = u.id_user
            ORDER BY r.tanggal DESC
            ";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataRiwayat.DataSource = dt;
        }

        public FormRiwayat()
        {
            InitializeComponent();
            this.Load += FormRiwayat_Load;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRiwayat();
        }
    }
}
