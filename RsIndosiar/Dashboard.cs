using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RsIndosiar
{

    public partial class Dashboard : Form
    {
        static string connStr =
        @"Data Source=10.39.198.11,1433;
Initial Catalog=RsIndosiar;
User ID=rsuser;
Password=123;";


        private Button btnDiagnosa; 
        private Button btnRiwayat; 
        private Button btnLogout; 
        private Button btnObat; 
        private Label label1;

        private void InitializeComponent()
        {
            this.btnDiagnosa = new System.Windows.Forms.Button();
            this.btnRiwayat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnObat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDiagnosa
            // 
            this.btnDiagnosa.Location = new System.Drawing.Point(56, 129);
            this.btnDiagnosa.Name = "btnDiagnosa";
            this.btnDiagnosa.Size = new System.Drawing.Size(169, 36);
            this.btnDiagnosa.TabIndex = 0;
            this.btnDiagnosa.Text = "Diagnosa";
            this.btnDiagnosa.UseVisualStyleBackColor = true;
            this.btnDiagnosa.Click += new System.EventHandler(this.btnDiagnosa_Click);
            // 
            // btnRiwayat
            // 
            this.btnRiwayat.Location = new System.Drawing.Point(466, 339);
            this.btnRiwayat.Name = "btnRiwayat";
            this.btnRiwayat.Size = new System.Drawing.Size(170, 36);
            this.btnRiwayat.TabIndex = 1;
            this.btnRiwayat.Text = "Riwayat";
            this.btnRiwayat.UseVisualStyleBackColor = true;
            this.btnRiwayat.Click += new System.EventHandler(this.btnRiwayat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(601, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistem Informasi Keluhan Kesehatan dan Rekomendasi Obat";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(706, 442);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(98, 36);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnObat
            // 
            this.btnObat.Location = new System.Drawing.Point(262, 242);
            this.btnObat.Name = "btnObat";
            this.btnObat.Size = new System.Drawing.Size(170, 36);
            this.btnObat.TabIndex = 4;
            this.btnObat.Text = "Cek Obat";
            this.btnObat.UseVisualStyleBackColor = true;
            this.btnObat.Click += new System.EventHandler(this.btnObat_Click);
            // 
            // Dashboard
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 490);
            this.Controls.Add(this.btnObat);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRiwayat);
            this.Controls.Add(this.btnDiagnosa);
            this.Name = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnDiagnosa_Click(object sender, EventArgs e)
        {
            FormDiagnosa f = new FormDiagnosa();
            f.Show(); 

        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            FormRiwayat f = new FormRiwayat();
            f.Show(); 
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();

            this.Close(); 
        }

        private void btnObat_Click(object sender, EventArgs e)
        {
            FormObat f = new FormObat();
            f.Show();
        }


    }
}
