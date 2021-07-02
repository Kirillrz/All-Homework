using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Entity
{
    public class Dog : Ml
    {
        public Dog() : base(1)
        {

        }
        public override void Move()
        {
            Console.WriteLine("Движение собаки");
        }
        public override bool Beat(Entity entity)
        {
            var beated = base.Beat(entity);
            Console.WriteLine("Собака кусается");
            return true;
        }
        public override int LungsSize { get => base.LungsSize; set => base.LungsSize = value; }
    }
}
