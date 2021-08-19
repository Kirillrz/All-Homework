using System;
using System.Collections.Generic;

#nullable disable

namespace CarRegistartion.DAL.DataModels
{
    public partial class Car
    {
        public int Id { get; set; }
        public int EngineTypeId { get; set; }
        public int? CarModelId { get; set; }
        public string Vin { get; set; }

        public virtual CarModel CarModel { get; set; }
        public virtual EngineType EngineType { get; set; }
    }
}
