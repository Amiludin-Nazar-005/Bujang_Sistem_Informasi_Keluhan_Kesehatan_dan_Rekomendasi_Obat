using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace RsIndosiar
{




    public class DiagnosaDAL
    {

        Koneksi koneksi = new Koneksi();

        public DataTable GetAll()
        {
            DataTable dt = new DataTable();


            using (SqlConnection conn = koneksi.GetConn())
            {

                string query = @"
                SELECT *
                FROM Diagnosa";


                SqlDataAdapter da =
                new SqlDataAdapter(query, conn);


                da.Fill(dt);

            }


            return dt;
        }




        // AMBIL DATA DIAGNOSA
        public DataTable LoadDiagnosa()
        {

            DataTable dt = new DataTable();


            using (SqlConnection conn =
            koneksi.GetConn())
            {

                string query = @"
                SELECT *
                FROM Diagnosa";


                SqlDataAdapter da =
                new SqlDataAdapter(query, conn);


                da.Fill(dt);

            }


            return dt;

        }





        // UPDATE DIAGNOSA
        public bool Update(ClassDiagnosa d)
        {
            using (SqlConnection conn = koneksi.GetConn())
            {
                conn.Open();


                string query =
                @"UPDATE Diagnosa SET
        hasil_diagnosa=@hasil,
        obat=@obat,
        status='Selesai'
        WHERE id_diagnosa=@id";


                SqlCommand cmd =
                new SqlCommand(query, conn);


                cmd.Parameters.AddWithValue(
                "@hasil",
                d.hasil_diagnosa);


                cmd.Parameters.AddWithValue(
                "@obat",
                d.obat);


                cmd.Parameters.AddWithValue(
                "@id",
                d.id_diagnosa);


                return cmd.ExecuteNonQuery() > 0;
            }
        }





        // DELETE DIAGNOSA
        public bool Delete(int id)
        {
            using (SqlConnection conn = koneksi.GetConn())
            {
                conn.Open();


                string query =
                "DELETE FROM Diagnosa WHERE id_diagnosa=@id";


                SqlCommand cmd =
                new SqlCommand(query, conn);


                cmd.Parameters.AddWithValue(
                "@id",
                id);


                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
    }
