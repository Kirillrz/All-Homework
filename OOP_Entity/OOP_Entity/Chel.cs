using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Entity
{
    public class Chel:Ml
    {
        public Chel(int age) : base(age)
        {

        }

        public override void Move()
        {
            Console.WriteLine("Движение человека");
        }
        public override bool Beat(Entity entity)
        {
            Console.WriteLine("Человек не дерется");
            return base.Beat(entity);
        }
    }
}
