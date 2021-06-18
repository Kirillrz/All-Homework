using System;
using System.Collections.Generic;
namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = 0;
            Console.WriteLine("1 - Array");
            Console.WriteLine("2 - list");
            key = Convert.ToInt32(Console.ReadLine());

            if (key == 1)
            {
                Console.WriteLine("Array count:");
                int x = Convert.ToInt32(Console.ReadLine());


                int[] array = new int[x];

                for (int i = 1; i <= x; i++)
                {
                    Console.WriteLine("Add " + i + " elem");
                    array[i-1] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("All elements:");

                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine(array[i]);
                }
                Console.ReadKey();
            }

            if (key == 2)
            {
                List<string> numbers = new List<string>();
                Console.WriteLine("List count:");
                int count = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= count; i++)
                {
                    Console.WriteLine("Add " + i + " elem");
                    numbers.Add(Console.ReadLine());
                }
                Console.WriteLine("All elements:");

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

        }
    }
}
