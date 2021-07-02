using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<int> numbers = new Stack<int>();

            numbers.Push(7);

            int pp = numbers.Peek();
            Console.WriteLine(pp);

            numbers.Push(5);
            numbers.Push(8);

            int stackElement = numbers.Pop(); 
            Console.WriteLine(stackElement);

            Mathimaticks.All_Math();
            
        }
    }
    public class Mathimaticks
    {
        public static void All_Math()
        {


            int a = 5 / 3;
            Console.WriteLine(a);

            double b = 5.0 / 3;
            b=Math.Round(b, 4);
            Console.WriteLine(b);

            double c = 5%3;
            Console.WriteLine(c);


            Console.ReadLine();
        }
    }
}