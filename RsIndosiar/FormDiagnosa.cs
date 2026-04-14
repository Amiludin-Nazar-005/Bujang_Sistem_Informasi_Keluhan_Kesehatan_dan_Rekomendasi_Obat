using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RsIndosiar
{
    public partial class FormDiagnosa : Form
    {
        string connStr = "Data Source=DIAN\\NAZARIN;Initial Catalog=RsIndosiar;Integrated Security=True";

        public FormDiagnosa()
        {
            InitializeComponent(); 
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKeluhan = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Keluhan";
            // 
            // txtKeluhan
            // 
            this.txtKeluhan.Location = new System.Drawing.Point(338, 111);
            this.txtKeluhan.Name = "txtKeluhan";
            this.txtKeluhan.Size = new System.Drawing.Size(292, 96);
            this.txtKeluhan.TabIndex = 2;
            this.txtKeluhan.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Proses";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hasil";
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(338, 305);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.ReadOnly = true;
            this.txtHasil.Size = new System.Drawing.Size(292, 22);
            this.txtHasil.TabIndex = 5;
            // 
            // FormDiagnosa
            // 
            this.ClientSize = new System.Drawing.Size(964, 470);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtKeluhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDiagnosa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
        private Label label2;
        private RichTextBox txtKeluhan;
        private Button button1;
        private Label label3;
        private TextBox txtHasil;

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                conn.Open();

                string keluhan = txtKeluhan.Text.ToLower();
                string hasil = "Tidak ditemukan rekomendasi"; 

                // ambil data gejala + obat
                string query = @"
        SELECT g.nama_gejala, o.nama_obat
        FROM Aturan_Diagnosa a
        JOIN Gejala g ON a.id_gejala = g.id_gejala
        JOIN Obat o ON a.id_obat_rekomendasi = o.id_obat
        ";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    string gejala = rd["nama_gejala"].ToString().ToLower();
                    string obat = rd["nama_obat"].ToString();

                    // cek apakah keluhan mengandung gejala
                    if (keluhan.Contains(gejala))
                    {
                        hasil = "Disarankan: " + obat; 
                        break;
                    }
                }

                rd.Close();

                txtHasil.Text = hasil;

                // simpan ke riwayat
                string insert = @"
        INSERT INTO Riwayat (id_user, keluhan, hasil_rekomendasi)
        VALUES (@id_user, @keluhan, @hasil)
        ";

                SqlCommand cmdInsert = new SqlCommand(insert, conn);
                cmdInsert.Parameters.AddWithValue("@id_user", 1); // sementara pakai user id 1
                cmdInsert.Parameters.AddWithValue("@keluhan", keluhan);
                cmdInsert.Parameters.AddWithValue("@hasil", hasil);

                cmdInsert.ExecuteNonQuery();

                MessageBox.Show("Diagnosa selesai!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
