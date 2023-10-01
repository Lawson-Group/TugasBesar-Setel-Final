using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeLah_Setel.Models
{
    internal class Peminjaman
    {
        public DateTime WaktuPeminjaman { get; set; }
        public string NamaPeminjam { get; set; }
        public string shelterAwal { get; set; }
        public string shelterAkhir { get; set; }
        public Kendaraan kendaraan { get; set; }
        public DateTime batasWaktuPengembalian { get; set; }

    }
}
