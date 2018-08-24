using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoderOpg1
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = LægSammen(5, 2);
            double res2 = BeregnAreal(5);

            Console.WriteLine(res);
            Console.WriteLine(res2);
            Console.WriteLine("Dette er en test");

            Console.ReadKey();
        }

        static int LægSammen(int a, int b) { return a + b; }

        static double BeregnAreal(int radius)
        {
            double pi = Math.PI;

            return radius * radius * pi;
        }

        static void Udskriv(string txt)
        {
            Console.WriteLine(txt);
        }


    }
}
