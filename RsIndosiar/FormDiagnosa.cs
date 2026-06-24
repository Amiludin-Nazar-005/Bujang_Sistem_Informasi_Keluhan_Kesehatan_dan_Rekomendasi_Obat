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
        static string connStr =
        @"Data Source=10.39.198.11,1433;
Initial Catalog=RsIndosiar;
User ID=rsuser;
Password=123;";
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
            this.rtHasil = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(601, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistem Informasi Keluhan Kesehatan dan Rekomendasi Obat";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Keluhan";
            // 
            // txtKeluhan
            // 
            this.txtKeluhan.Location = new System.Drawing.Point(290, 96);
            this.txtKeluhan.Name = "txtKeluhan";
            this.txtKeluhan.Size = new System.Drawing.Size(514, 99);
            this.txtKeluhan.TabIndex = 2;
            this.txtKeluhan.Text = "";
            this.txtKeluhan.TextChanged += new System.EventHandler(this.txtKeluhan_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(848, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Proses";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hasil";
            // 
            // rtHasil
            // 
            this.rtHasil.Location = new System.Drawing.Point(290, 278);
            this.rtHasil.Name = "rtHasil";
            this.rtHasil.Size = new System.Drawing.Size(514, 160);
            this.rtHasil.TabIndex = 5;
            this.rtHasil.Text = "";
            // 
            // FormDiagnosa
            // 
            this.ClientSize = new System.Drawing.Size(964, 470);
            this.Controls.Add(this.rtHasil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtKeluhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDiagnosa";
            this.Load += new System.EventHandler(this.FormDiagnosa_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        private Label label1;
        private Label label2;
        private RichTextBox txtKeluhan;
        private Button button1;
        private RichTextBox rtHasil;
        private Label label3;

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = @"INSERT INTO Diagnosa
                (username, keluhan, status)

                VALUES
                (@u, @k, 'Menunggu')";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@u", Form1.usernameLogin);
            cmd.Parameters.AddWithValue("@k", txtKeluhan.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Keluhan berhasil dikirim!");

            conn.Close();
        } 

        private void txtKeluhan_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadObat()
        {

        }

        private void FormDiagnosa_Load_1(object sender, EventArgs e)
        {
            LoadObat();
            LoadHasil();
            MessageBox.Show(Form1.usernameLogin);
        }

        private void LoadHasil()
        {
            SqlConnection conn =
            new SqlConnection(connStr);

            conn.Open();

            string query = @"
            SELECT TOP 1
            keluhan,
            hasil_diagnosa,
            obat,
            status,
            tanggal
            FROM Diagnosa
            WHERE username=@u
            ORDER BY id_diagnosa DESC";

            SqlCommand cmd =
            new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue(
            "@u",
            Form1.usernameLogin);

            SqlDataReader rd =
            cmd.ExecuteReader();

            if (rd.Read())
            {
                rtHasil.Text =
                "Keluhan : " +
                rd["keluhan"].ToString()

                + Environment.NewLine +
                Environment.NewLine +

                "Hasil Diagnosa : " +
                rd["hasil_diagnosa"].ToString()

                + Environment.NewLine +
                Environment.NewLine +

                "Obat : " +
                rd["obat"].ToString()

                + Environment.NewLine +
                Environment.NewLine +

                "Status : " +
                rd["status"].ToString()

                + Environment.NewLine +
                Environment.NewLine +

                "Tanggal : " +
                rd["tanggal"].ToString();
            }

            conn.Close(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
