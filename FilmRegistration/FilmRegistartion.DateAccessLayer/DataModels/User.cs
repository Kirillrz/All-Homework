using System;
using System.Collections.Generic;

#nullable disable

namespace FilmRegistartion.DateAccessLayer.DataModels
{
    public partial class User
    {
        public User()
        {
            Ratings = new HashSet<Rating>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
