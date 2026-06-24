namespace RsIndosiar
{
    partial class FormObat
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
            this.dataObat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataObat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataObat
            // 
            this.dataObat.BackgroundColor = System.Drawing.Color.White;
            this.dataObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataObat.Location = new System.Drawing.Point(28, 87);
            this.dataObat.Name = "dataObat";
            this.dataObat.RowHeadersWidth = 51;
            this.dataObat.RowTemplate.Height = 24;
            this.dataObat.Size = new System.Drawing.Size(849, 412);
            this.dataObat.TabIndex = 0;
            this.dataObat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Obat-obat yang tersedia";
            // 
            // FormObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataObat);
            this.Name = "FormObat";
            this.Text = "FormObat";
            this.Load += new System.EventHandler(this.FormObat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataObat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataObat;
        private System.Windows.Forms.Label label1;
    }
}