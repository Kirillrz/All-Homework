using System;
using System.Collections.Generic;

#nullable disable

namespace CarRegistartion.DAL.DataModels
{
    public partial class Log
    {
        public int Id { get; set; }
        public DateTime DayTime { get; set; }
        public string Changes { get; set; }
    }
}
