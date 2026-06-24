using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RsIndosiar
{
    public class ObatDAL
    {

        Koneksi koneksi = new Koneksi();



        // TAMPIL DATA OBAT
        public DataTable GetAll()
        {

            DataTable dt = new DataTable();


            using (SqlConnection conn = koneksi.GetConn())
            {

                string query =
                @"SELECT 
                id_obat,
                nama_obat,
                deskripsi,
                gambar_obat
                FROM Obat";


                SqlDataAdapter da =
                new SqlDataAdapter(query, conn);


                da.Fill(dt);

            }


            return dt;

        }





        // TAMBAH OBAT
        public bool Insert(ClassObat obat)
        {

            using (SqlConnection conn = koneksi.GetConn())
            {

                conn.Open();


                string query =
                @"INSERT INTO Obat
                (nama_obat,deskripsi,gambar_obat)

                VALUES
                (@nama,@desk,@gambar)";



                SqlCommand cmd =
                new SqlCommand(query, conn);



                cmd.Parameters.AddWithValue(
                "@nama",
                obat.nama_obat);


                cmd.Parameters.AddWithValue(
                "@desk",
                obat.deskripsi);


                cmd.Parameters.AddWithValue(
                "@gambar",
                obat.gambar_obat ?? "");



                return cmd.ExecuteNonQuery() > 0;


            }

        }




        // UPDATE OBAT
        public bool Update(ClassObat obat)
        {
            using (SqlConnection conn = koneksi.GetConn())
            {
                conn.Open();

                string query;


                if (string.IsNullOrEmpty(obat.gambar_obat))
                {
                    query =
                    @"UPDATE Obat SET
                nama_obat=@nama,
                deskripsi=@desk
              WHERE id_obat=@id";
                }
                else
                {
                    query =
                    @"UPDATE Obat SET
                nama_obat=@nama,
                deskripsi=@desk,
                gambar_obat=@gambar
              WHERE id_obat=@id";
                }


                SqlCommand cmd =
                new SqlCommand(query, conn);


                cmd.Parameters.AddWithValue(
                    "@nama",
                    obat.nama_obat);


                cmd.Parameters.AddWithValue(
                    "@desk",
                    obat.deskripsi);


                cmd.Parameters.AddWithValue(
                    "@id",
                    obat.id_obat);



                if (!string.IsNullOrEmpty(obat.gambar_obat))
                {
                    cmd.Parameters.AddWithValue(
                        "@gambar",
                        obat.gambar_obat);
                }


                return cmd.ExecuteNonQuery() > 0;
            }
        }




        // DELETE OBAT
        public bool Delete(int id)
        {

            using (SqlConnection conn = koneksi.GetConn())
            {

                conn.Open();


                string query =
                "DELETE FROM Obat WHERE id_obat=@id";


                SqlCommand cmd =
                new SqlCommand(query, conn);


                cmd.Parameters.AddWithValue(
                "@id",
                id);



                return cmd.ExecuteNonQuery() > 0;


            }

        }

        public string GetGambar(int id)
        {
            string gambar = "";

            using (SqlConnection conn = koneksi.GetConn())
            {
                conn.Open();


                string query =
                "SELECT gambar_obat FROM Obat WHERE id_obat=@id";


                SqlCommand cmd =
                new SqlCommand(query, conn);


                cmd.Parameters.AddWithValue(
                "@id",
                id);


                object hasil =
                cmd.ExecuteScalar();


                if (hasil != null && hasil != DBNull.Value)
                {
                    gambar = hasil.ToString();
                }

            }


            return gambar;
        }

    }
}
