using nyobaprojek.View;
using System;
using System.Windows.Forms;

namespace nyobaprojek
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Daftar daftarForm = new Daftar();

            Application.Run(daftarForm);

            if (daftarForm.ShowLoginForm)
            {
                Application.Run(new Login(daftarForm));
            }
        }
    }
}
