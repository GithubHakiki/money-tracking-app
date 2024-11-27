using nyobaprojek.Model.Entity;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace nyobaprojek
{
    public class Controller
    {
        private Repository _repository;
        SQLiteConnection _conn;

        public Controller(Repository repository, SQLiteConnection conn)
        {
            this._repository = repository;
            this._conn = conn;
        }

        public bool AuthenticateUser(string nama, string sandi)
        {
            // Assuming you have a method in the repository to check user credentials
            return _repository.ValidateUserCredentials(nama, sandi);
        }

        public int Create(DB db)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new Repository(context);
                result = _repository.Create(db);

                if (result > 0)
                {
                    MessageBox.Show("Data berhasil disimpan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                    MessageBox.Show("Data gagal disimpan !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public int Create(Transaksi trs)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new Repository(context);
                result = _repository.Create(trs);

                if (result > 0)
                {
                    MessageBox.Show("Data berhasil disimpan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Data gagal disimpan !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        public int Create(Kategori ktr)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new Repository(context);
                result = _repository.Create(ktr);

                if (result > 0)
                {
                    MessageBox.Show("Data berhasil disimpan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Data gagal disimpan !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        public int Create(Saldo sld)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new Repository(context);
                result = _repository.Create(sld);

                if (result > 0)
                {
                    MessageBox.Show("Data berhasil disimpan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Data gagal disimpan !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        public int Update(DB db)
        {
            // Lengkapi kode untuk method Update
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new Repository(context);
                result = _repository.Update(db);
            }
            if (result > 0)
            {
                MessageBox.Show("Data berhasil diperbarui !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data gagal diperbarui !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Update(Transaksi trs)
        {
            // Lengkapi kode untuk method Update
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new Repository(context);
                result = _repository.Update(trs);
            }
            if (result > 0)
            {
                MessageBox.Show("Data berhasil diperbarui !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data gagal diperbarui !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Update(Kategori ktr)
        {
            // Lengkapi kode untuk method Update
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new Repository(context);
                result = _repository.Update(ktr);
            }
            if (result > 0)
            {
                MessageBox.Show("Data berhasil diperbarui !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data gagal diperbarui !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return 1;
        }

        public int Delete(DB db)
        {
            // Lengkapi kode untuk method Delete
            int result = 0;

            if (MessageBox.Show("Apakah Anda yakin ingin menghapus data mahasiswa ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (DbContext context = new DbContext())
                {
                    _repository = new Repository(context);
                    result = _repository.Delete(db);
                }
                if (result > 0)
                {
                    MessageBox.Show("Data mahasiswa berhasil dihapus !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Data mahasiswa gagal dihapus !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        public int Delete(Transaksi trs)
        {
            // Lengkapi kode untuk method Delete
            int result = 0;

            if (MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (DbContext context = new DbContext())
                {
                    _repository = new Repository(context);
                    result = _repository.Delete(trs);
                }
                if (result > 0)
                {
                    MessageBox.Show("Data berhasil dihapus !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Data gagal dihapus !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        public int Delete(Kategori ktr)
        {
            // Lengkapi kode untuk method Delete
            int result = 0;

            if (MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (DbContext context = new DbContext())
                {
                    _repository = new Repository(context);
                    result = _repository.Delete(ktr);
                }
                if (result > 0)
                {
                    MessageBox.Show("Data berhasil dihapus !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Data gagal dihapus !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        public List<Transaksi> ReadAll()
        {
            List<Transaksi> list = new List<Transaksi>();

            using (DbContext context = new DbContext())
            {
                _repository = new Repository(context);
                list = _repository.ReadAll();
            }
            return list;
        }

         public List<Kategori> ReadAllKategori()
        {
            List<Kategori> list = new List<Kategori>();

            using (DbContext context = new DbContext())
            {
                _repository = new Repository(context);
                list = _repository.ReadAllKategori();
            }
            return list;
        }

        public List<Saldo> ReadSaldo()
        {
            List<Saldo> list = new List<Saldo>();

            using (DbContext context = new DbContext())
            {
                _repository = new Repository(context);
                list = _repository.ReadSaldo();
            }
            return list;
        }
    }
}
