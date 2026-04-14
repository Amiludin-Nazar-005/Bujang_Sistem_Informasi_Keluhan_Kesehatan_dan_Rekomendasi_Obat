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
        string connStr = "Data Source=DIAN\\NAZARIN;Initial Catalog=RsIndosiar;Integrated Security=True";


        private Button btnDiagnosa;
        private Button btnRiwayat;
        private Label label1;

        private void InitializeComponent()
        {
            this.btnDiagnosa = new System.Windows.Forms.Button();
            this.btnRiwayat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDiagnosa
            // 
            this.btnDiagnosa.Location = new System.Drawing.Point(157, 199);
            this.btnDiagnosa.Name = "btnDiagnosa";
            this.btnDiagnosa.Size = new System.Drawing.Size(169, 36);
            this.btnDiagnosa.TabIndex = 0;
            this.btnDiagnosa.Text = "Diagnosa";
            this.btnDiagnosa.UseVisualStyleBackColor = true;
            this.btnDiagnosa.Click += new System.EventHandler(this.btnDiagnosa_Click);
            // 
            // btnRiwayat
            // 
            this.btnRiwayat.Location = new System.Drawing.Point(491, 199);
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
            this.label1.Location = new System.Drawing.Point(214, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistem Informasi Keluhan Kesehatan dan Rekomendasi Obat";
            // 
            // Dashboard
            // 
            this.ClientSize = new System.Drawing.Size(825, 490);
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
           
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
