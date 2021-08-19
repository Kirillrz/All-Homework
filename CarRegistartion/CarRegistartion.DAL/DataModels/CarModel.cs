using System;
using System.Collections.Generic;

#nullable disable

namespace CarRegistartion.DAL.DataModels
{
    public partial class CarModel
    {
        public CarModel()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
