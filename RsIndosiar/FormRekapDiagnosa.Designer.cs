namespace RsIndosiar
{
    partial class FormRekapDiagnosa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtAwal = new System.Windows.Forms.DateTimePicker();
            this.dtAkhir = new System.Windows.Forms.DateTimePicker();
            this.btnCari = new System.Windows.Forms.Button();
            this.dataDiagnosa = new System.Windows.Forms.DataGridView();
            this.btnCetak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDiagnosa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tanggal Awal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(684, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tanggal Akhir\n";
            // 
            // dtAwal
            // 
            this.dtAwal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAwal.Location = new System.Drawing.Point(140, 105);
            this.dtAwal.Name = "dtAwal";
            this.dtAwal.Size = new System.Drawing.Size(200, 22);
            this.dtAwal.TabIndex = 2;
            this.dtAwal.Value = new System.DateTime(2026, 1, 1, 23, 10, 0, 0);
            // 
            // dtAkhir
            // 
            this.dtAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAkhir.Location = new System.Drawing.Point(645, 105);
            this.dtAkhir.Name = "dtAkhir";
            this.dtAkhir.Size = new System.Drawing.Size(200, 22);
            this.dtAkhir.TabIndex = 3;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(453, 171);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 32);
            this.btnCari.TabIndex = 4;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // dataDiagnosa
            // 
            this.dataDiagnosa.BackgroundColor = System.Drawing.Color.White;
            this.dataDiagnosa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDiagnosa.Location = new System.Drawing.Point(129, 246);
            this.dataDiagnosa.Name = "dataDiagnosa";
            this.dataDiagnosa.RowHeadersWidth = 51;
            this.dataDiagnosa.RowTemplate.Height = 24;
            this.dataDiagnosa.Size = new System.Drawing.Size(724, 150);
            this.dataDiagnosa.TabIndex = 5;
            this.dataDiagnosa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDiagnosa_CellClick);
            this.dataDiagnosa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDiagnosa_CellContentClick);
            // 
            // btnCetak
            // 
            this.btnCetak.Location = new System.Drawing.Point(778, 414);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(75, 31);
            this.btnCetak.TabIndex = 6;
            this.btnCetak.Text = "Cetak";
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // FormRekapDiagnosa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 497);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.dataDiagnosa);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.dtAkhir);
            this.Controls.Add(this.dtAwal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRekapDiagnosa";
            this.Text = "FormRekapDiagnosa";
            this.Load += new System.EventHandler(this.FormRekapDiagnosa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDiagnosa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtAwal;
        private System.Windows.Forms.DateTimePicker dtAkhir;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.DataGridView dataDiagnosa;
        private System.Windows.Forms.Button btnCetak;
    }
}