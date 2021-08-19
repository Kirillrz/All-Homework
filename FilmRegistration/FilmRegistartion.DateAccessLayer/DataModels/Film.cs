using System;
using System.Collections.Generic;

#nullable disable

namespace FilmRegistartion.DateAccessLayer.DataModels
{
    public partial class Film
    {
        public Film()
        {
            Ratings = new HashSet<Rating>();
        }

        public int Id { get; set; }
        public string FilmName { get; set; }
        public string DescriptionId { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public TimeSpan? Duration { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
