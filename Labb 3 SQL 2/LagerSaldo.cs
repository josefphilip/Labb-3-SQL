using System;
using System.Collections.Generic;

#nullable disable

namespace Labb_3_SQL_2
{
    public partial class LagerSaldo
    {
        public int ButikId { get; set; }
        public string Isbn { get; set; }
        public int? Antal { get; set; }

        public virtual Butiker Butik { get; set; }
        public virtual Böcker IsbnNavigation { get; set; }
    }
}
