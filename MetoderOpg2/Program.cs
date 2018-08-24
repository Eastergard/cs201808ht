using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoderOpg2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Beregn(1, 2));
            Console.WriteLine(Beregn(1, 2, 3));
            Console.WriteLine(Beregn(1, 2, 4, 5));

            Console.ReadKey();
        }

        static int Beregn(int a, int b) { return a + b; }

        static int Beregn(int a, int b, int c) { return Beregn(Beregn(a, b), c); }

        static int Beregn(int a, int b, int c, int d) { return Beregn(Beregn(a, b, c), d); }
    }
}
