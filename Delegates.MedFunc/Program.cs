using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.MedFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = Beregner(5, 5, Plus);
            Console.WriteLine(res);

            res = Beregner(5, 5, Minus);
            Console.WriteLine(res);

            res = Beregner(5, 5, Divider);
            Console.WriteLine(res);

            res = Beregner(5, 5, Gange);
            Console.WriteLine(res);

            Console.ReadKey();

        }


        public static int Beregner(int a, int b, Func<int, int, int> func)
        {
            return func(a, b);
        }



        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Divider(int a, int b)
        {
            return a / b;
        }

        public static int Gange(int a, int b)
        {
            return a * b;
        }
    }
}
