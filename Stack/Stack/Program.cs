using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<int> numbers = new Stack<int>();

            numbers.Push(7); 
            numbers.Push(5); 
            numbers.Push(8); 

            
            int stackElement = numbers.Pop(); 
            Console.WriteLine(stackElement);

           
            Console.ReadLine();
        }
    }

    class Person
    {
        public string Name { get; set; }
    }
}