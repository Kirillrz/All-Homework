using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Менюшка_циклы_классы
{
    class Compare
    {
        public static void switcher()
        {
            var a = 0;
            var b = 0;
            
            
                Console.WriteLine("Предоставьте два числа для их сравнения");
                // Console.Clear();


                while (true)
                    {
                    Console.WriteLine("Введите первое число (А):");
                    try { a = Convert.ToInt32(Console.ReadLine()); break; }
                    catch { Console.Clear(); Console.WriteLine("Ошибка, повторите ввод"); Console.ReadKey(); Console.Clear(); }
                    }

                Console.Clear();
            while (true)
            {
                Console.WriteLine("Введите второе число (Б):");
                try
                {
                    b = Convert.ToInt32(Console.ReadLine());

                    if (a > b) Compare.more(a, b);
                    else if (a == b) Compare.equally(a, b);
                    else Compare.less(a, b);
                    break;

                }
                catch { Console.Clear(); Console.WriteLine("Ошибка, повторите ввод"); Console.ReadKey(); Console.Clear(); }
            }
                
            
            Console.ReadKey();
            Console.Clear();

        }
        public static void more(int a,int b)
        {
            Console.Clear();
            Console.WriteLine("A>B");
            Console.WriteLine(a +">"+ b);
        }
        public static void less(int a, int b)
        {
            Console.Clear();
            Console.WriteLine("A<B");
            Console.WriteLine(a + "<" + b);
        }
        public static void equally(int a, int b)
        {
            Console.Clear();
            Console.WriteLine("A=B");
            Console.WriteLine(a + "=" + b);
        }
    }
}
