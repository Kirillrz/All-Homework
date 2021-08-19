using System;
using System.Collections.Generic;

#nullable disable

namespace FilmRegistartion.DateAccessLayer.DataModels
{
    public partial class Rating
    {
        public int Id { get; set; }
        public int Rating1 { get; set; }
        public string TextRating { get; set; }
        public int? FilmId { get; set; }
        public int? UserId { get; set; }

        public virtual Film Film { get; set; }
        public virtual User User { get; set; }
    }
}
