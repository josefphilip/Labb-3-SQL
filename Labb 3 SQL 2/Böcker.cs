using System;
using System.Collections.Generic;

#nullable disable

namespace Labb_3_SQL_2
{
    public partial class Böcker
    {
        public Böcker()
        {
            Kunders = new HashSet<Kunder>();
            LagerSaldos = new HashSet<LagerSaldo>();
        }

        public string Isbn { get; set; }
        public string Titel { get; set; }
        public string Språk { get; set; }
        public int? Pris { get; set; }
        public string Utgivningsdatum { get; set; }
        public int FörfattareId { get; set; }
        public int Genre { get; set; }

        public virtual Författare Författare { get; set; }
        public virtual Genre GenreNavigation { get; set; }
        public virtual ICollection<Kunder> Kunders { get; set; }
        public virtual ICollection<LagerSaldo> LagerSaldos { get; set; }
    }
}
