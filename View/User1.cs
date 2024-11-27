using nyobaprojek.Model.Entity;
using nyobaprojek.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace nyobaprojek
{
    public partial class User1 : Form
    {
        private List<Transaksi> listOfUser = new List<Transaksi>();
        private List<Kategori> listOfKategori = new List<Kategori>();
        private Daftar daftarForm;
        private Controller controller;
        private Kategori ktr = new Kategori();
        private Transaksi trn = new Transaksi();    

        private string authenticatedUsername;

        public User1(Daftar daftar, Controller controller, string authenticatedUsername)
        {
            InitializeComponent();
            InisialisasiListView();
            InisialisasiListView1();
            this.daftarForm = daftar;
            this.controller = controller;
            this.authenticatedUsername = authenticatedUsername;
            LoadDataUser();
            LoadDataKategori();
            //LoadKategori();
            //LoadDataUser1();
        }
        private void InisialisasiListView()
        {
            lvwUser.View = System.Windows.Forms.View.Details;
            lvwUser.FullRowSelect = true;
            lvwUser.GridLines = true;
            lvwUser.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwUser.Columns.Add("Tanggal", 140, HorizontalAlignment.Center);
            lvwUser.Columns.Add("Nominal", 160, HorizontalAlignment.Center);
           // lvwUser.Columns.Add("Kategori", 140, HorizontalAlignment.Center);
        }

        private void InisialisasiListView1()
        {
            lsvKategori.View = System.Windows.Forms.View.Details;
            lsvKategori.FullRowSelect = true;
            lsvKategori.GridLines = true;
            lsvKategori.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lsvKategori.Columns.Add("Kategori", 140, HorizontalAlignment.Center);
        }



        public void LoadDataUser()
        {
            lvwUser.Items.Clear();
            listOfUser = controller.ReadAll();

            foreach (var trn in listOfUser)
            {
                var noUrut = lvwUser.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());

                var formattedDate = trn.Tgl_Trn.ToString("yyyy-MM-dd"); // Change the format as needed

                item.SubItems.Add(formattedDate);
                //item.SubItems.Add(mhs.Nm_Kategori);
                item.SubItems.Add(trn.Nominal);

                lvwUser.Items.Add(item);
            } 

        }

        public void LoadDataKategori()
        {
            lsvKategori.Items.Clear();

            // Assuming ReadAllKategori method returns List<nyobaprojek.Kategori>
            listOfKategori = controller.ReadAllKategori(); // Adjust the method name as per your implementation

            foreach (var ktr in listOfKategori)
            {
                /*
                var noUrut = lsvKategori.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                */
                var item = new ListViewItem();
                item.SubItems.Add(ktr.Nm_Kategori);

                lsvKategori.Items.Add(item);
            }
        }

         
        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            TambahTransaksi tambahtransaksi = new TambahTransaksi(this, controller);
            tambahtransaksi.ShowDialog();
            LoadDataUser();
            LoadDataKategori();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Login login = new Login(this, controller);
            login.ShowDialog();
        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            TambahSaldo tambahsaldo = new TambahSaldo(this, controller);
            tambahsaldo.ShowDialog();
        }

        private void lvwUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_Nama_TextChanged(object sender, EventArgs e)
        {
            //menggil dat nama yang daftar

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {

            if (lvwUser.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    Transaksi trs = listOfUser[lvwUser.SelectedIndices[0]];

                    var result = controller.Delete(trs);
                    if (result > 0) LoadDataUser();
                }
            }
            else if(lsvKategori.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    Kategori ktr = listOfKategori[lsvKategori.SelectedIndices[0]];

                    var result = controller.Delete(ktr);
                    if (result > 0) LoadDataKategori(); 
                }
            }
            else
            {
                MessageBox.Show("Data mahasiswa belum dipilih !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void OnUpdateEventHandler(Transaksi trn)
        {
            int index = lvwUser.SelectedIndices[0];

            ListViewItem itemRow = lvwUser.Items[index];

            // Assuming Tgl_Trn is of type DateTime
            string formattedDate = trn.Tgl_Trn.ToString("yyyy-MM-dd"); // Change the format as needed

            itemRow.SubItems[1].Text = formattedDate;
            itemRow.SubItems[2].Text = trn.Nominal;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvwUser.SelectedItems.Count > 0)
            {
                // Get the selected item
                ListViewItem selectedItem = lvwUser.SelectedItems[0];
                //ListViewItem selectedItemm = lsvKategori.SelectedItems[0];

                // Get the index of the selected item
                int selectedIndex = selectedItem.Index;

                // Get the corresponding Transaksi object from the list
                Transaksi selectedTransaksi = listOfUser[selectedIndex];
                Kategori selectedKategori = listOfKategori[selectedIndex];

                // Open the EditTransaksi form for editing
                EditTransaksi editTransaksiForm = new EditTransaksi(this, controller, selectedTransaksi, selectedKategori);
                editTransaksiForm.ShowDialog();

                // Reload data after editing
                LoadDataUser();
                LoadDataKategori();
            }
            else if  (lsvKategori.SelectedItems.Count > 0){
             
                ListViewItem selectedItem = lvwUser.SelectedItems[0];
                //ListViewItem selectedItemm = lsvKategori.SelectedItems[0];

                // Get the index of the selected item
                int selectedIndex = selectedItem.Index;

                // Get the corresponding Transaksi object from the list
                Transaksi selectedTransaksi = listOfUser[selectedIndex];
                Kategori selectedKategori = listOfKategori[selectedIndex];

                // Open the EditTransaksi form for editing
                EditTransaksi editTransaksiForm = new EditTransaksi(this, controller, selectedTransaksi, selectedKategori);
                editTransaksiForm.ShowDialog();

                // Reload data after editing
                LoadDataUser();
                LoadDataKategori();
            }
       
            else
            {
                MessageBox.Show("Please select a transaction to edit.", "Edit Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }



        private void tb_Saldo_TextChanged(object sender, EventArgs e)
        {
            // Assuming ReadSaldo returns a List<nyobaprojek.Model.Entity.Saldo>
            var saldoList = controller.ReadSaldo(); 

            // Assuming you want to display the first item in the list, adjust this based on your business logic
            
                tb_Saldo.Text = saldoList.ToString(); // You need to convert the Saldo object to string or get a property of Saldo
            
        }

    }
}
