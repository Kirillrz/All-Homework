using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Менюшка_циклы_классы
{
    class Calc
    {
        public static void menu()
        {
            
            int key;
            while (true)
            {
                Console.WriteLine("1 - сложение");
                Console.WriteLine("2 - вычитание");
                Console.WriteLine("3 - умножение");
                Console.WriteLine("4 - деление");
                Console.WriteLine("любая другая ЦИФРА - назад");
                 
                try   { key = Convert.ToInt32(Console.ReadLine()); break; }
                catch { Console.Clear(); Console.WriteLine("Ошибка, повторите ввод"); Console.ReadKey(); Console.Clear(); }
            }
            Console.Clear();

            Calc.input(key);
        }
        public static void sum(double a,double b)
        {
            Console.Clear();
            a +=b; 
            Console.WriteLine("A+B="+a);
            Console.ReadKey();
        }
        public static void sub(double a, double b)
        {
            Console.Clear();
            a -= b; 
            Console.WriteLine("A-B=" + a);
            Console.ReadKey();
        }
        public static void multi(double a, double b)
        {
            Console.Clear();
            a *= b; 
            Console.WriteLine("A*B=" + a);
            Console.ReadKey();
        }
        public static void division(double a, double b)
        {
            Console.Clear();
            a /= b; 
            Console.WriteLine("A/B=" + a);
            Console.ReadKey();
        }

        public static void input(int key)
        {
            double a,b;


            if (key <= 4)
            {
                while (true)
                {
                    Console.WriteLine("Введите первое число (А):");
                    try { a = Convert.ToDouble(Console.ReadLine()); break; }
                    catch { Console.Clear(); Console.WriteLine("Ошибка, повторите ввод"); Console.ReadKey(); Console.Clear(); }
                }

                Console.Clear();
                while (true)
                {
                    Console.WriteLine("Введите второе число (Б):");
                    try { b = Convert.ToDouble(Console.ReadLine()); break; }
                    catch { Console.Clear(); Console.WriteLine("Ошибка, повторите ввод"); Console.ReadKey(); Console.Clear(); }
                }
                switch (key)
                {
                    case 1: { Calc.sum(a, b); break; }
                    case 2: { Calc.sub(a, b); break; }
                    case 3: { Calc.multi(a, b); break; }
                    case 4: { Calc.division(a, b); break; }


                    default: break;
                }
            }

        }
    }
}
