using System;
using System.Windows.Forms;



namespace nyobaprojek
{
    public partial class TambahTransaksi : Form
    {
        private User1 user1;
        private Controller controller;
        //private bool isNewData = true;
        private Transaksi trn = new Transaksi();
        private Kategori ktr = new Kategori();

        public delegate void CreateUpdateEventHandler(Kategori ktr, Transaksi trn);
        public event CreateUpdateEventHandler OnCreate;
        private bool isNewData = true;

        public TambahTransaksi(User1 user1, Controller controller)
        {
            InitializeComponent();
            this.user1 = user1;
            using (var dbContext = new DbContext())
            {
                // Pass the DbContext instance to the Repository, and obtain the SqlConnection from DbContext
                var repository = new Repository(dbContext);

                // Now, pass the Repository and SqlConnection to the Controller
                //controller = new Controller(repository, dbContext.Conn);
                this.controller = controller;
            }
        }

        public TambahTransaksi(string title, Transaksi obj, Controller controller)
        {
            this.Text = title;
            this.controller = controller;

            isNewData = false;
            trn = obj;
            
            ktr = new Kategori();  // Create a new instance of Kategori
            ktr.Nm_Kategori = tbKategori.Text;  // Assign the value or property as needed
            
            trn.Tgl_Trn = dt_Tanggal.Value; // datetime
            trn.Nominal = tbJumlah.Text;
        }



        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (isNewData) trn =  new Transaksi();
            if (isNewData) ktr = new Kategori();

            ktr.Nm_Kategori = tbKategori.Text;
            //trn.Tgl_Trn = tbtglTambah.Text;
            trn.Tgl_Trn = dt_Tanggal.Value; // datetime
            trn.Nominal = tbJumlah.Text;
            int result = 0;
            if (isNewData)
            {

                result = controller.Create(trn);
                result = controller.Create(ktr);
                if (result > 0)
                {
                    //OnCreate(ktr);
                    //OnCreate(trn);

                    tbKategori.Text = "";
                    tbJumlah.Clear();
                    
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD

                result = controller.Update(ktr);

                if (result > 0)
                {
                    //OnUpdate(ktr); // panggil event OnUpdate
                    this.Close();
                }

            }
            /*
            if (isNewData)
            {
                trn = new Transaksi();
                ktr = new Kategori();
            }

            ktr.Nm_Kategori = tbKategori.Text;
            //trn.Tgl_Trn = tbtglTambah.Text;
            trn.Tgl_Trn = dt_Tanggal.Value; // datetime
            trn.Nominal = tbJumlah.Text;

            int result = 0;

            if (controller != null)
            {
                result = controller.Create(trn);
                result = controller.Create(ktr);
            }
            else
            {
                MessageBox.Show("Controller is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/


            //this.Close();
        }

        private void tbKategori_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbJumlah_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbtglTambah_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
            user1.Show();
        }

        private void dt_Tanggal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TambahTransaksi_Load(object sender, EventArgs e)
        {

        }

        private void tbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
