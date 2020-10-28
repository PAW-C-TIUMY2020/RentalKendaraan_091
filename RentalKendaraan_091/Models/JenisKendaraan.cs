using System;
using System.Collections.Generic;

namespace RentalKendaraan_091.Models
{
    public partial class JenisKendaraan
    {
        public int IdJenisKendaran { get; set; }
        public string NamaJenisKendaraan { get; set; }

        public Kendaraan IdJenisKendaranNavigation { get; set; }
    }
}
