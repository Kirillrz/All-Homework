using System;

namespace Калькулятор
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = -10;
            var a = 0;
            var b = 0.0;
            double c =  0;

            int exit = 0;
            while (exit < 2)
            {
                Console.WriteLine("~~~~~~~Менюшка~~~~~~ \t\t\t\t\t\t\t\t\t\t\t\t v-2.1");
                Console.WriteLine("1 - сложение");
                Console.WriteLine("2 - вычитание");
                Console.WriteLine("3 - умножение");
                Console.WriteLine("4 - деление");
                Console.WriteLine("9 - Выйти из программы");
                try     { key = Convert.ToInt32(Console.ReadLine()); }
                catch   { key = -10; }

               
                    
                if  (key == 1) { 
                
                for (int i = 0; i < 2;)
                {
                    Console.Clear(); Console.WriteLine("Введите первое число:");
                    try { a = Convert.ToInt32(Console.ReadLine()); i++; }
                    catch { a = 0; i = 0; Console.WriteLine("Пососи"); Console.ReadKey(); }
                    Console.Clear();
                    Console.WriteLine("Введите второе число:");
                    try { b = Convert.ToInt32(Console.ReadLine()); i++; }
                    catch { b = 0; i = 0; Console.WriteLine("Пососи"); Console.ReadKey(); }
                    Console.Clear();
                }

                c = a + b; Console.WriteLine(c); Console.ReadKey(); }
                else if (key == 2) {
                
                for (int i = 0; i < 2;)
                    {
                        Console.Clear(); Console.WriteLine("Введите первое число:");
                        try { a = Convert.ToInt32(Console.ReadLine()); i++; }
                        catch { a = 0; i = 0; Console.WriteLine("Пососи"); Console.ReadKey(); }
                        Console.Clear();
                        Console.WriteLine("Введите второе число:");
                        try { b = Convert.ToInt32(Console.ReadLine()); i++; }
                        catch { b = 0; i = 0; Console.WriteLine("Пососи"); Console.ReadKey(); }
                        Console.Clear();
                    }
                    c = a - b; Console.WriteLine(c); Console.ReadKey(); }
                else if (key == 3) {
                    
                    for (int i = 0; i < 2;)
                    {
                        Console.Clear(); Console.WriteLine("Введите первое число:");
                        try { a = Convert.ToInt32(Console.ReadLine()); i++; }
                        catch { a = 0; i = 0; Console.WriteLine("Пососи"); Console.ReadKey(); }
                        Console.Clear();
                        Console.WriteLine("Введите второе число:");
                        try { b = Convert.ToInt32(Console.ReadLine()); i++; }
                        catch { b = 0; i = 0; Console.WriteLine("Пососи"); Console.ReadKey(); }
                        Console.Clear();
                    }


                    c = a * b; Console.WriteLine(c); Console.ReadKey(); }
                else if (key == 4)
                {
                    
                    for (int i = 0; i < 2;)
                    {
                        Console.Clear(); Console.WriteLine("Введите первое число:");
                        try { a = Convert.ToInt32(Console.ReadLine()); i++; }
                        catch { a = 0; i = 0; Console.WriteLine("Пососи"); Console.ReadKey(); }
                        Console.Clear();
                        Console.WriteLine("Введите второе число:");
                        try { string f = Console.ReadLine(); b = Convert.ToDouble(f); i++; }
                        catch { b = 0; i = 0; Console.WriteLine("Пососи"); Console.ReadKey(); }
                        Console.Clear();
                    }


                    c = a / b; Console.WriteLine(c); Console.ReadKey();
                }
                else if (key == 9) exit = 3;
                else { Console.Clear(); Console.WriteLine("Пососи"); Console.ReadKey(); }
                Console.Clear();
            }
        }
    }
}
