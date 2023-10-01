using System.Collections.Generic;

namespace BikeLah_Setel.Models
{
    internal class Shelter
    {
        public string LokasiShelter { get; set; }
        public List<Kendaraan> KendaraanTersedia { get; set; }

        public Shelter(string lokasiShelter) 
        {
            this.LokasiShelter = lokasiShelter;
            KendaraanTersedia = new List<Kendaraan>();
        }
    }
}
