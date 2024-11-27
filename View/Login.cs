using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace nyobaprojek.View
{
    public partial class Login : Form
    {
        private User1 user1Form;
        private Controller controller;
        private Daftar daftarForm;

        //private string authenticatedUsername;

        private void User1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public Login(User1 user1Form, Controller controller)
        {
            InitializeComponent();
            this.user1Form = user1Form;
            this.controller = controller;
        }

        public Login(Daftar daftarForm)
        {
            InitializeComponent();
            controller = new Controller(new Repository(new DbContext()), new SQLiteConnection());
            this.daftarForm = daftarForm;
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            string enteredNama = tbNama.Text;
            string enteredSandi = tbSandi.Text;

            // Assuming you have a method in the controller to authenticate the user
            bool isAuthenticated = controller.AuthenticateUser(enteredNama, enteredSandi);

            if (isAuthenticated)
            {
                this.Hide();

                User1 user1 = new User1(daftarForm, controller, enteredNama);
                user1.FormClosed += User1_FormClosed;
                user1.Show();
            }
            else
            {
                MessageBox.Show("Nama atau Sandi salah!", "Autentikasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_daftar_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Tampilkan form daftar
            Daftar daftarForm = new Daftar();
            daftarForm.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
