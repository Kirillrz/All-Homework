using System;
using System.Collections.Generic;

namespace queue
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Queue<Person> persons = new Queue<Person>();
            persons.Enqueue(new Person() { Name = "Kirill" });
            persons.Enqueue(new Person() { Name = "Artem" });
            persons.Enqueue(new Person() { Name = "Gleb" });

           
            Person pp = persons.Peek();
            Console.WriteLine(pp.Name);

            Console.WriteLine("Сейчас в очереди {0} человек(а)", persons.Count);

           
            foreach (Person p in persons)
            {
                Console.WriteLine(p.Name);
            }

            
            Person person = persons.Dequeue(); 
            Console.WriteLine(person.Name);

            Console.ReadLine();
        }
    }

    class Person
    {
        public string Name { get; set; }
    }
}