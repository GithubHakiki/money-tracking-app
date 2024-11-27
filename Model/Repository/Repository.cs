using nyobaprojek.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

using System.Data.SQLite;
using System.Diagnostics;

namespace nyobaprojek
{
    public class Repository
    {
        private SQLiteConnection _conn;

        public Repository(DbContext context)
        {
            _conn = context.Conn;
        }

        public bool ValidateUserCredentials(string nama, string sandi)
        {
            string sql = "SELECT COUNT(*) FROM dtuser WHERE nama = @Nama AND sandi = @Sandi";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Nama", nama);
                cmd.Parameters.AddWithValue("@Sandi", sandi);

                object result = cmd.ExecuteScalar();

                // Check for null before casting
                if (result != null && result != DBNull.Value)
                {
                    int count = Convert.ToInt32(result);
                    return count > 0;
                }

                // Return false if result is null or DBNull.Value
                return false;
            }
        }


        public int Create(DB db)
        {
            int result = 0;
            string sql = @"INSERT INTO [dtuser] ([nama], [sandi], [tgl_daftar])
                                        VALUES (@Nama, @Sandi, @Tgl_daftar)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Nama", db.Nama);
                cmd.Parameters.AddWithValue("@Sandi", db.Sandi);
                cmd.Parameters.AddWithValue("@Tgl_daftar", DateTime.Now);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                    return result; 
                }
            }

            return result; 
        }

        public int Create(Transaksi trs)
        {
            int result = 0;
            string sql = @"INSERT INTO [dttransaksi] ([id_transaksi], [tgl_transaksi], [nominal])
                                        VALUES (@idtransaksi, @Tgl_transaksi, @Nominal)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {

                cmd.Parameters.AddWithValue("@idtransaksi", trs.IDtransaksi);
                cmd.Parameters.AddWithValue("@Tgl_transaksi", trs.Tgl_Trn);
                cmd.Parameters.AddWithValue("@Nominal", trs.Nominal);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                    return result; 
                }
            } 
            return result; 
        }

        public int Create(Kategori ktr)
        {
            int result = 0;
            string sql = @"INSERT INTO [dtkategori] ([id_kategori],[kategori])
                                        VALUES (@idkategori,@Kategori)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@idkategori", ktr.IDkategori);
                cmd.Parameters.AddWithValue("@Kategori", ktr.Nm_Kategori);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                    return result;
                }
            }
            return result;
        }

        public int Create(Saldo sld)
        {
            int result = 0;
            string sql = @"INSERT INTO [dtsaldo] ([Saldo])
                                        VALUES (@Saldo)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Saldo", sld.saldo);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                    return result;
                }
            }
            return result;
        }

        //UPDATE

        public int Update(DB db)
        {
            int result = 0;
            //diganti sqlnya sesuai database
            string sql = @"update Dosen set Nama = @Nama, NIP = @NIP where ID_Dosen = @ID_Dosen";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Nama", db.Nama);
                cmd.Parameters.AddWithValue("@Sandi", db.Sandi);

                try
                {
                    result = cmd.ExecuteNonQuery();
                    Debug.Print("Create success. Rows affected: " + result);
                }
                catch (Exception ex)
                {
                    Debug.Print($"Create error: {ex.Message}");
                }
            }
            return result;
        }

        public int Update(Transaksi trs)
        {
            int result = 0;
            //diganti sqlnya sesuai database
            string sql = @"update dttransaksi set tgl_transaksi = @Tgl_transaksi, nominal = @Nominal where id_transaksi = @idtransaksi";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@idtransaksi", trs.IDtransaksi);
                cmd.Parameters.AddWithValue("@Tgl_transaksi", trs.Tgl_Trn);
                cmd.Parameters.AddWithValue("@Nominal", trs.Nominal);

                try
                {
                    result = cmd.ExecuteNonQuery();
                    Debug.Print("Create success. Rows affected: " + result);
                }
                catch (Exception ex)
                {
                    Debug.Print($"Create error: {ex.Message}");
                }
            }
            return result;
        }

        public int Update(Kategori ktr)
        {
            int result = 0;
            //diganti sqlnya sesuai database
            string sql = @"update dtkategori set kategori = @Kategori where id_kategori = @idkategori";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@idkategori", ktr.IDkategori);
                cmd.Parameters.AddWithValue("@Kategori", ktr.Nm_Kategori);

                try
                {
                    result = cmd.ExecuteNonQuery();
                    Debug.Print("Create success. Rows affected: " + result);
                }
                catch (Exception ex)
                {
                    Debug.Print($"Create error: {ex.Message}");
                }
            }
            return result;
        }

        public int Update(Saldo sld)
        {
            int result = 0;
            //diganti sqlnya sesuai database
            string sql = @"update Dosen set Nama = @Nama, NIP = @NIP where ID_Dosen = @ID_Dosen";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Tgl_transaksi", sld.saldo);

                try
                {
                    result = cmd.ExecuteNonQuery();
                    Debug.Print("Create success. Rows affected: " + result);
                }
                catch (Exception ex)
                {
                    Debug.Print($"Create error: {ex.Message}");
                }
            }
            return result;
        }

        //DELETE
        public int Delete(DB db)
        {
            int result = 0;
            string sql = @"delete from Dosen where ID_Dosen = @ID_Dosen";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {

                cmd.Parameters.AddWithValue("@Nama", db.Nama);
                cmd.Parameters.AddWithValue("@Sandi", db.Sandi);
                cmd.Parameters.AddWithValue("@Tgl_daftar", DateTime.Now);

                try
                {
                    result = cmd.ExecuteNonQuery();
                    Debug.Print("Create success. Rows affected: " + result);
                }
                catch (Exception ex)
                {
                    Debug.Print($"Create error: {ex.Message}");
                }
            }
            return result;
        }

        public int Delete(Transaksi trs)
        {
            int result = 0;
            string sql = @"DELETE FROM [dttransaksi] WHERE id_transaksi = @idtransaksi";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {

                cmd.Parameters.AddWithValue("@idtransaksi", trs.IDtransaksi);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }
            return result;
        }

        public int Delete(Kategori ktr)
        {
            int result = 0;
            string sql = @"delete from [dtkategori] WHERE id_kategori = @idkategori";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@idkategori", ktr.IDkategori);

                try
                {
                    result = cmd.ExecuteNonQuery();
                    Debug.Print("Create success. Rows affected: " + result);
                }
                catch (Exception ex)
                {
                    Debug.Print($"Create error: {ex.Message}");
                }
            }
            return result;
        }

        public List<Transaksi> ReadAll()
        {
            List<Transaksi> list = new List<Transaksi>();
            try
            {
                //diganti sesuaitabel di user1
                string sql = @"select tgl_transaksi, nominal from dttransaksi order by tgl_transaksi";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Transaksi trn = new Transaksi();
                            trn.Tgl_Trn = DateTime.Parse(dtr["tgl_transaksi"].ToString());
                            trn.Nominal = dtr["nominal"].ToString();
                            //trn.Kategori = dtr["angkatan"].ToString();

                            list.Add(trn);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return list;
        }

        public List<Kategori> ReadAllKategori()
        {
            List<Kategori> list = new List<Kategori>();
            try
            {
                //diganti sesuaitabel di user1
                string sql = @"select kategori from dtkategori order by kategori";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Kategori ktr = new Kategori();
                            ktr.Nm_Kategori = dtr["kategori"].ToString();
                            //trn.Kategori = dtr["angkatan"].ToString();

                            list.Add(ktr);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return list;
        }

        public List<Saldo> ReadSaldo()
        {
            List<Saldo> list = new List<Saldo>();
            try
            {
                //diganti sesuaitabel di user1
                string sql = @"select Saldo from dtsaldo order by Saldo";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Saldo ktr = new Saldo();
                            ktr.saldo = dtr["saldo"].ToString();
                            //trn.Kategori = dtr["angkatan"].ToString();

                            list.Add(ktr);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return list;
        }
    }
}
