using System;
using System.Collections.Generic;

#nullable disable

namespace Labb_3_SQL_2
{
    public partial class Genre
    {
        public Genre()
        {
            Böckers = new HashSet<Böcker>();
        }

        public int GenreId { get; set; }
        public string Genrenamn { get; set; }

        public virtual ICollection<Böcker> Böckers { get; set; }
    }
}
