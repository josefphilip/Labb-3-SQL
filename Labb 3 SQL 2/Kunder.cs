using System;
using System.Collections.Generic;

#nullable disable

namespace Labb_3_SQL_2
{
    public partial class Kunder
    {
        public int Id { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public string Address { get; set; }
        public bool SkickaMail { get; set; }
        public string EMail { get; set; }
        public string Bok { get; set; }
        public int? Butik { get; set; }

        public virtual Böcker BokNavigation { get; set; }
        public virtual Butiker ButikNavigation { get; set; }
    }
}
