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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }
        int id_obat;
        private TextBox txtDeskripsi; 
        string connStr = "Data Source=DIAN\\NAZARIN;Initial Catalog=RsIndosiar;Integrated Security=True";

        private void InitializeComponent() 
        {
            this.txtGejala = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGejala = new System.Windows.Forms.DataGridView();
            this.txtObat = new System.Windows.Forms.TextBox();
            this.btnTambahObat = new System.Windows.Forms.Button();
            this.btnUpdateObat = new System.Windows.Forms.Button();
            this.btnDeleteObat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataObat = new System.Windows.Forms.DataGridView();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGejala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataObat)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGejala
            // 
            this.txtGejala.Location = new System.Drawing.Point(126, 74);
            this.txtGejala.Name = "txtGejala";
            this.txtGejala.Size = new System.Drawing.Size(202, 20);
            this.txtGejala.TabIndex = 0;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(185, 164);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 1;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(185, 196);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(185, 225);
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
            this.dataGejala.Location = new System.Drawing.Point(38, 269);
            this.dataGejala.Name = "dataGejala";
            this.dataGejala.RowHeadersWidth = 51;
            this.dataGejala.RowTemplate.Height = 24;
            this.dataGejala.Size = new System.Drawing.Size(378, 183);
            this.dataGejala.TabIndex = 4;
            this.dataGejala.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGejala_CellContentClick);
            // 
            // txtObat
            // 
            this.txtObat.Location = new System.Drawing.Point(615, 74);
            this.txtObat.Name = "txtObat";
            this.txtObat.Size = new System.Drawing.Size(230, 20);
            this.txtObat.TabIndex = 5;
            // 
            // btnTambahObat
            // 
            this.btnTambahObat.Location = new System.Drawing.Point(694, 164);
            this.btnTambahObat.Name = "btnTambahObat";
            this.btnTambahObat.Size = new System.Drawing.Size(75, 23);
            this.btnTambahObat.TabIndex = 6;
            this.btnTambahObat.Text = "Tambah";
            this.btnTambahObat.UseVisualStyleBackColor = true;
            this.btnTambahObat.Click += new System.EventHandler(this.btnTambahObat_Click);
            // 
            // btnUpdateObat
            // 
            this.btnUpdateObat.Location = new System.Drawing.Point(694, 196);
            this.btnUpdateObat.Name = "btnUpdateObat";
            this.btnUpdateObat.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateObat.TabIndex = 7;
            this.btnUpdateObat.Text = "Update";
            this.btnUpdateObat.UseVisualStyleBackColor = true;
            this.btnUpdateObat.Click += new System.EventHandler(this.btnUpdateObat_Click);
            // 
            // btnDeleteObat
            // 
            this.btnDeleteObat.Location = new System.Drawing.Point(694, 225);
            this.btnDeleteObat.Name = "btnDeleteObat";
            this.btnDeleteObat.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteObat.TabIndex = 8;
            this.btnDeleteObat.Text = "Delete";
            this.btnDeleteObat.UseVisualStyleBackColor = true;
            this.btnDeleteObat.Click += new System.EventHandler(this.btnDeleteObat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gejala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(714, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13); 
            this.label2.TabIndex = 10;
            this.label2.Text = "Obat";
            // 
            // dataObat
            // 
            this.dataObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataObat.Location = new System.Drawing.Point(544, 269);
            this.dataObat.Name = "dataObat";
            this.dataObat.RowHeadersWidth = 51; 
            this.dataObat.RowTemplate.Height = 24;
            this.dataObat.Size = new System.Drawing.Size(385, 183);
            this.dataObat.TabIndex = 11; 
            this.dataObat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataObat_CellContentClick);
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Location = new System.Drawing.Point(650, 121);
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(174, 20);
            this.txtDeskripsi.TabIndex = 12;
            // 
            // FormAdmin
            // 
            this.ClientSize = new System.Drawing.Size(941, 528);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.dataObat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteObat);
            this.Controls.Add(this.btnUpdateObat);
            this.Controls.Add(this.btnTambahObat);
            this.Controls.Add(this.txtObat);
            this.Controls.Add(this.dataGejala);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtGejala);
            this.Name = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGejala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataObat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox txtGejala;
        private Button btnTambah;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataObat;
        private TextBox txtObat;
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
            LoadObat();
            MessageBox.Show("Masuk Admin");
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

        private Button btnTambahObat;
        private Button btnUpdateObat;
        private Button btnDeleteObat;
        private Label label1;
        private Label label2;
        private void LoadObat()
        {
            SqlConnection conn = new SqlConnection(connStr);

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Obat", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataObat.DataSource = dt;
        }

        private void btnTambahObat_Click(object sender, EventArgs e)
        {
            if (txtObat.Text == "")
            {
                MessageBox.Show("Nama obat tidak boleh kosong!");
                return;
            }

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "INSERT INTO Obat (nama_obat, deskripsi) VALUES (@n, @d)";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@n", txtObat.Text);
            cmd.Parameters.AddWithValue("@d", txtDeskripsi.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Obat berhasil ditambahkan!");

            conn.Close();
            LoadObat();
        }

        private void dataObat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataObat.Rows[e.RowIndex];

                id_obat = Convert.ToInt32(row.Cells["id_obat"].Value);
                txtObat.Text = row.Cells["nama_obat"].Value.ToString();
                txtDeskripsi.Text = row.Cells["deskripsi"].Value.ToString();
            }
        }

        private void btnUpdateObat_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "UPDATE Obat SET nama_obat=@n, deskripsi=@d WHERE id_obat=@id";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@n", txtObat.Text);
            cmd.Parameters.AddWithValue("@d", txtDeskripsi.Text);
            cmd.Parameters.AddWithValue("@id", id_obat);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Obat berhasil diupdate!");

            conn.Close();
            LoadObat();
        }

        private void btnDeleteObat_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "DELETE FROM Obat WHERE id_obat=@id";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@id", id_obat);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Obat berhasil dihapus!");

            conn.Close();
            LoadObat();
        }
    }
}
