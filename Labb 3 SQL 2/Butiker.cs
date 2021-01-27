using System;
using System.Collections.Generic;

#nullable disable

namespace Labb_3_SQL_2
{
    public partial class Butiker
    {
        public Butiker()
        {
            Kunders = new HashSet<Kunder>();
            LagerSaldos = new HashSet<LagerSaldo>();
        }

        public int ButikId { get; set; }
        public string Butiknamn { get; set; }
        public string Butikadress { get; set; }

        public virtual ICollection<Kunder> Kunders { get; set; }
        public virtual ICollection<LagerSaldo> LagerSaldos { get; set; }
    }
}
