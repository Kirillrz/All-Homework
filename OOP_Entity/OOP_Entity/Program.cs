using System;

namespace OOP_Entity
{

    public abstract class Entity
    {
        public int Weight { get; set; }
        public int Age { get; }
        public abstract void Move();
        protected virtual void Breathe()
        {
            
        }
        protected Entity (int age)
        {
            Age = age;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int spider_age = 10;
            Chel chelo = new Chel(5);
            Dog doge = new Dog();
            Spiders spider = new Spiders(spider_age);

            spider.Move();
            chelo.Move();
            Ml mleko = doge;
           // Ml mleko = spider;
            mleko.Beat(chelo);
            Console.ReadKey();
        }
    }
}
