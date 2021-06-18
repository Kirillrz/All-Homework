using System;

namespace Менюшка
{
    class Program
    {
        static void Main(string[] args)
        {           
            var key=-10;
            int exit = 0;
            while (exit < 2)
            {
                Console.WriteLine("~~~~~~~Менюшка~~~~~~ \t\t\t\t\t\t\t\t\t\t\t\t v-1.2");
                Console.WriteLine("0 - Показать единицу");
                Console.WriteLine("1 - Показать двойку");
                Console.WriteLine("2 - показать первую букву алфавита");
                Console.WriteLine("9 - Выйти из программы");
                try     { key = Convert.ToInt32(Console.ReadLine()); }
                catch   { key = -10; }
                if (key == 0) { Console.Clear(); Console.WriteLine("1"); Console.ReadKey(); }
                else if (key == 1) { Console.Clear(); Console.WriteLine("2"); Console.ReadKey(); }
                else if (key == 2) { Console.Clear(); Console.WriteLine("A"); Console.ReadKey(); }
                else if (key == 9) exit = 3;
                else               { Console.Clear(); Console.WriteLine("Пососи"); Console.ReadKey(); }
                    Console.Clear();
            }
        }
    }
}
