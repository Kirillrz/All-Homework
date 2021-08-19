using System;
using System.Collections.Generic;

#nullable disable

namespace FilmRegistartion.DateAccessLayer.DataModels
{
    public partial class FilmsToActor
    {
        public int? FilmId { get; set; }
        public int? ActorsId { get; set; }

        public virtual Actor Actors { get; set; }
        public virtual Film Film { get; set; }
    }
}
