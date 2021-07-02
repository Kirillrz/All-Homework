using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Entity
{
    public class Spiders : Chlenist
    {
        
        public Spiders(int age): base(age)
        {

        }
        public override void Move()
        {
            Console.WriteLine("паук полёзт вверх");
        }
    }
}
