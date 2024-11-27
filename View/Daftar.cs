using nyobaprojek.View;
using System;
using System.Data.SQLite;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace nyobaprojek
{
    public partial class Daftar : Form
    {
        private Controller controller;
        private bool isNewData = true;
        private DB db;

        // Property to indicate whether to show the login form after closing Daftar
        public bool ShowLoginForm { get; private set; }

        public Daftar()
        {
            InitializeComponent();
            using (var dbContext = new DbContext())
            {
                // Pass the DbContext instance to the Repository, and obtain the SQLiteConnection from DbContext
                var repository = new Repository(dbContext);

                // Now, pass the Repository and SQLiteConnection to the Controller
                controller = new Controller(repository, dbContext.Conn);
            }
        }


        private void btnDaftar_Click(object sender, EventArgs e)
        {
            if (isNewData)
            {
                db = new DB();
            }

            db.Nama = tbNama.Text;
            db.Sandi = tbSandi.Text;

            int result = 0;

            try
            {
                if (controller != null)
                {
                    result = controller.Create(db);

                    // Handle the result as needed
                    if (result > 0)
                    {
                        // Set the property to false since we don't want to show the login form
                        ShowLoginForm = false;
                    }
                    else
                    {
                        // Set the property to false since we don't want to show the login form
                        ShowLoginForm = false;
                    }
                }
                else
                {
                    MessageBox.Show("Controller is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            // Set the property to true to show the login form after closing Daftar
            ShowLoginForm = true;

            // Close the registration form
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
