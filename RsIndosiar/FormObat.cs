using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RsIndosiar
{
    public partial class FormObat: Form
    {

        static string connStr =
        @"Data Source=10.39.198.11,1433;
Initial Catalog=RsIndosiar;
User ID=rsuser;
Password=123;";
        ObatDAL obatDAL = new ObatDAL();

        public FormObat()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormObat_Load(object sender, EventArgs e)
        {
            LoadObat();
        }

        private void LoadObat()
        {
            DataTable dt = obatDAL.GetAll();

            dataObat.DataSource = dt;


            // sembunyikan path gambar
            if (dataObat.Columns.Contains("gambar_obat"))
            {
                dataObat.Columns["gambar_obat"].Visible = false;
            }


            // hapus kolom gambar lama kalau ada
            if (dataObat.Columns.Contains("Foto"))
            {
                dataObat.Columns.Remove("Foto");
            }



            DataGridViewImageColumn img =
            new DataGridViewImageColumn();


            img.Name = "Foto";
            img.HeaderText = "Gambar Obat";


            dataObat.Columns.Add(img);



            foreach (DataGridViewRow row in dataObat.Rows)
            {

                if (row.Cells["gambar_obat"].Value != null)
                {

                    string path =
                    row.Cells["gambar_obat"].Value.ToString();



                    if (File.Exists(path))
                    {

                        using (FileStream fs =
                        new FileStream(
                        path,
                        FileMode.Open,
                        FileAccess.Read))
                        {

                            row.Cells["Foto"].Value =
                            new Bitmap(Image.FromStream(fs));

                        }

                    }

                }

            }


            // ukuran gambar
            dataObat.RowTemplate.Height = 80;

        }




    }
}
