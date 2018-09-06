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

    }



}
