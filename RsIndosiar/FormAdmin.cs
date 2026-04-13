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
    class FormAdmin : Form
    {

        string connStr = "Data Source=DIAN\\NAZARIN;Initial Catalog=RsIndosiar;Integrated Security=True";

        private void InitializeComponent()
        {
            this.txtGejala = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGejala = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGejala)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGejala
            // 
            this.txtGejala.Location = new System.Drawing.Point(258, 114);
            this.txtGejala.Name = "txtGejala";
            this.txtGejala.Size = new System.Drawing.Size(474, 22);
            this.txtGejala.TabIndex = 0;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(258, 208);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 1;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(453, 208);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(657, 208);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGejala
            // 
            this.dataGejala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGejala.Location = new System.Drawing.Point(86, 308);
            this.dataGejala.Name = "dataGejala";
            this.dataGejala.RowHeadersWidth = 51;
            this.dataGejala.RowTemplate.Height = 24;
            this.dataGejala.Size = new System.Drawing.Size(809, 150);
            this.dataGejala.TabIndex = 4;
            this.dataGejala.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGejala_CellContentClick);
            // 
            // FormAdmin
            // 
            this.ClientSize = new System.Drawing.Size(985, 474);
            this.Controls.Add(this.dataGejala);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtGejala);
            this.Name = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGejala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox txtGejala;
        private Button btnTambah;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGejala;


        private void LoadGejala()
        {
            SqlConnection conn = new SqlConnection(connStr);

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Gejala", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGejala.DataSource = dt;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            LoadGejala();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "INSERT INTO Gejala (nama_gejala) VALUES (@g)";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@g", dataGejala.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Data berhasil ditambahkan!");

            conn.Close();
            LoadGejala();
        }
        int id_gejala;

        private void dataGejala_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGejala.Rows[e.RowIndex];

                id_gejala = Convert.ToInt32(row.Cells["id_gejala"].Value);
                txtGejala.Text = row.Cells["nama_gejala"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "UPDATE Gejala SET nama_gejala=@g WHERE id_gejala=@id";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@g", txtGejala.Text);
            cmd.Parameters.AddWithValue("@id", id_gejala);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Data berhasil diupdate!");

            conn.Close();
            LoadGejala();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "DELETE FROM Gejala WHERE id_gejala=@id";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@id", id_gejala);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Data berhasil dihapus!");

            conn.Close();
            LoadGejala();
        }
    }
}
