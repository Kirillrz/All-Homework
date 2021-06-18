using System;

namespace Тест
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Всем привет, сегодня мы напишем программу на считывание с консоли, далее напишите своё имя");

            string name = Console.ReadLine();


            Console.WriteLine("Теперь напишите свою фамилию");
            string surname = Console.ReadLine();

            Console.WriteLine(name +" "+ surname);
            
        }
    }
}
