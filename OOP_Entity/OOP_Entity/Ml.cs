using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Entity
{
    public abstract class Ml : Entity
    {
        //protected Ml() : this(10)
        //{

        //}
        protected Ml(int age):base(age)
        {

        }

        protected override void Breathe()
        {
            //Using Lungs 
        }
        public virtual int LungsSize { get; set; }
        public virtual bool Beat (Entity entity)
        {
            Console.WriteLine("Млекопитающие не дерутся");
            return false;
        }
    }
}
