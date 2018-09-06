using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Simpel
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] månedsløn = { 10000, 20000, 15000, 20000, 30000, 15000 };

            foreach (var løn in månedsløn)
            {
                Console.WriteLine(løn);
            }

            double gennemsnit = månedsløn.Average();

            Console.WriteLine("Gennemsnit: " + gennemsnit.ToString("N2"));

            Console.ReadKey();

        }
    }
}
