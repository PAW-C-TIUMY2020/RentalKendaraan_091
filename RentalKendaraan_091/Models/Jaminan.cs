using System;
using System.Collections.Generic;

namespace RentalKendaraan_091.Models
{
    public partial class Jaminan
    {
        public int IdJaminan { get; set; }
        public string NamaJaminan { get; set; }

        public Peminjaman IdJaminanNavigation { get; set; }
    }
}
