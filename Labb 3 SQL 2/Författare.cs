using System;
using System.Collections.Generic;

#nullable disable

namespace Labb_3_SQL_2
{
    public partial class Författare
    {
        public Författare()
        {
            Böckers = new HashSet<Böcker>();
        }

        public int Identitet { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public int? Födelsedatum { get; set; }
        public int? Död { get; set; }

        public virtual ICollection<Böcker> Böckers { get; set; }
    }
}
