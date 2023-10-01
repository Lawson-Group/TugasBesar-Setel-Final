using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeLah_Setel.Models
{
    internal class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public UserData dataUser { get; set; }
        public Peminjaman peminjaman { get; set; }
        public List<Peminjaman> historyPeminjaman { get; set; }

    }
}
