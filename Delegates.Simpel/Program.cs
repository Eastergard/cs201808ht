using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Simpel
{
    class Program
    {
        public delegate int Beregn(int a, int b);



        static void Main(string[] args)
        {
            Beregn P = Plus;
            Beregn M = Minus;
            Beregn D = Divider;
            Beregn G = Gange;

            var res = Beregner(5, 5, P);
            Console.WriteLine(res);

            res = Beregner(5, 5, M);
            Console.WriteLine(res);

            res = Beregner(5, 5, D);
            Console.WriteLine(res);

            res = Beregner(5, 5, G);
            Console.WriteLine(res);

            var f = FindTilfældigFunktion();
            res = f(5, 5);
            Console.WriteLine(res);

            Console.ReadKey();
        }

        public static int Beregner(int a, int b, Beregn c)
        {
            return c(a, b);  
        }

        public static Beregn FindTilfældigFunktion()
        {
            switch (DateTime.Now.Millisecond%4)
            {
                case 0:
                    return Plus;
                case 1:
                    return Minus;
                case 2:
                    return Divider;
                default:
                    return Gange;

            }
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
