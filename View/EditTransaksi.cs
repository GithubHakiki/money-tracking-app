using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nyobaprojek.View
{
    public partial class EditTransaksi : Form
    {
        private Transaksi editedTransaksi;
        private Kategori editedKategori;
        private Controller controller;
        private User1 user1;
        public EditTransaksi(User1 user1, Controller controller, Transaksi transaksi, Kategori kategori)
        {
            InitializeComponent();

            this.user1 = user1;
            this.controller = controller;
            this.editedTransaksi = transaksi;

            dtTanggal.Value = editedTransaksi.Tgl_Trn;
            tbJumlah.Text = editedTransaksi.Nominal.ToString();
            //cbKategori.SelectedItem = editedKategori.Nm_Kategori.;
            this.editedKategori = kategori;

            cbKategori.SelectedItem = editedKategori.Nm_Kategori;
        }
        /*
        public EditTransaksi(User1 user1, Controller controller, Kategori kategori)
        {
            InitializeComponent();

            this.user1 = user1;
            this.controller = controller;
            this.editedKategori = kategori;

            cbKategori.SelectedItem = editedKategori.Nm_Kategori;
        }*/


        private void btnTambah_Click(object sender, EventArgs e)
        {
            // Ambil nilai dari kontrol input
            DateTime tanggal = dtTanggal.Value;
            string jumlah = tbJumlah.Text;

            // Perbarui properti objek editedTransaksi
            editedTransaksi.Tgl_Trn = tanggal;
            editedTransaksi.Nominal = jumlah;
            // Panggil metode untuk menyimpan perubahan
            int result = controller.Update(editedTransaksi);
            //int result = controller.Update(editedKategori);
            if (result > 0 )
            {
                MessageBox.Show("Data berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Perbarui tampilan di User1 setelah penyimpanan berhasil
                user1.LoadDataUser();
                user1.LoadDataKategori();
                this.Close(); // Tutup form setelah penyimpanan berhasil
            }
            else
            {
                MessageBox.Show("Data gagal diperbarui!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void editKategori(Kategori kategori)
        {

            Kategori selectedKategori = cbKategori.SelectedItem as Kategori;
            editedTransaksi.SelectedKategori = selectedKategori; // Assuming you have a property like this
            int result = controller.Update(editedKategori);

            if (result > 0)
            {
                MessageBox.Show("Data berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Perbarui tampilan di User1 setelah penyimpanan berhasil
                user1.LoadDataUser();
                user1.LoadDataKategori();
                this.Close(); // Tutup form setelah penyimpanan berhasil
            }
            else
            {
                MessageBox.Show("Data gagal diperbarui!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
