using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nyobaprojek
{
    public class Transaksi
    {
        public DateTime Tgl_Trn { get; set; } // datetime
        public string Nominal { get; set; }
        public int IDtransaksi { get; set; }
        public Kategori SelectedKategori { get; internal set; }

        //public string NamaKategori {  get; set; }

    }
}
