using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Менюшка_циклы_классы
{
    class Menu
    {
        public static void Chose()
        {
            byte y = 0;
            while (y < 10)
            {
                Console.Clear();
                Console.WriteLine("\t~~~Меню~~~");
                Console.WriteLine("1 - Сравнить два числа");
                Console.WriteLine("2 - произвести арифметическое преобразование 2-х чисел");
                Console.WriteLine("3 - показать кошелёк для донатов автору");
                Console.WriteLine("666 - выход из программы");
                var a = Console.ReadLine();


                switch (a)
                {
                    case "1": { Console.Clear(); Compare.switcher(); break; }
                    case "2": { Console.Clear(); Calc.menu(); break; }
                    case "3": { Console.Clear(); Cash.author(); break; }

                    case "666": { Console.Clear(); y = 111; break; }

                    default: { Console.Clear(); Console.WriteLine("\tОшибка, повторите ввод\n"); break; }
                }
            }
        }
    }
}
