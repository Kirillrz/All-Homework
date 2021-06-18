using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinX
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 0.0;
            List<double> num = new List<double>();
            double el = Math.Round(Math.Pow(Math.Sin(s + 2), 2), 3);
            Console.WriteLine(0 + ")sin(" + s + "+2)^2=" + el);
            //Console.WriteLine(value: el);



            for (int k = 1; !num.Contains(el); k++)
            {
                //  Console.WriteLine("s");
                s = Math.Round(s + 0.1, 1);


                num.Add(el);
                el = Math.Round(Math.Pow(Math.Sin(s + 2), 2), 3);
                Console.WriteLine(k + ")sin(" + s + "+2)^2=" + el);


            }

            Console.ReadKey();
        }
    }
}
