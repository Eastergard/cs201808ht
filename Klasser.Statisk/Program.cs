using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser.Statisk
{
    class Program
    {
        static void Main(string[] args)
        {
            // Beregninger b = new Beregninger(); fejl
            int res = Beregninger.LægSammen(1, 1);
            Console.WriteLine(res);

            int res1 = Beregninger.TrækFra(1, 1);
            Console.WriteLine(res1);

            int res2 = Beregninger.Gang(2, 4);
            Console.WriteLine(res2);

            float res3 = Beregninger.Divider(12, 0);
            Console.WriteLine(res3);

            float res4 = Beregninger.Divider(12, 2);
            Console.WriteLine(res4);


            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class Beregninger
    {
        private Beregninger() { }

        public static int LægSammen(int a, int b) => a + b;

        public static int TrækFra(int a, int b) => a - b;

        public static int Gang(int a, int b) => a * b;

        public static float Divider(int a, int b)
        {
            if (b == 0F)
                throw new Exception("Nævneren må ikke være nul!");
            return a / b;
        }

    }



}
