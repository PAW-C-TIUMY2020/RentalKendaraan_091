using System;
using System.Collections.Generic;

namespace RentalKendaraan_091.Models
{
    public partial class Peminjaman
    {
        public int IdPeminjaman { get; set; }
        public DateTime? TglPeminjaman { get; set; }
        public int? IdKendaraan { get; set; }
        public int? IdCustomer { get; set; }
        public int? IdJaminan { get; set; }
        public int? Biaya { get; set; }

        public KondisiKendaraan IdPeminjaman1 { get; set; }
        public Kendaraan IdPeminjamanNavigation { get; set; }
        public Customer Customer { get; set; }
        public Jaminan Jaminan { get; set; }
    }
}
