using nyobaprojek.Model.Entity;
using System;
using System.Windows.Forms;

namespace nyobaprojek
{
    public partial class TambahSaldo : Form
    {
        private User1 user1;
        private Controller controller;
        //private Repository repository;

        private bool isNewData = true;
        private Saldo sld;
        public TambahSaldo(User1 user1, Controller controller)
        {
            InitializeComponent();
            this.user1 = user1;
            this.controller = controller;
        }
        
        public TambahSaldo(User1 user1)
        {
            this.user1 = user1;
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            if (isNewData)
            {
                sld = new Saldo();
            }

            sld.saldo = tbSaldo.Text;

            int result = 0;

            if (controller != null)
            {
                result = controller.Create(sld);
            }
            else
            {
                MessageBox.Show("Controller is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //code nyimpen data
            //this.Close();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
            user1.Show();
        }
    }
}
