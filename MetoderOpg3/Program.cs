using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoderOpg3
{
    class Program
    {
        static void Main(string[] args)
        {
            TælTil10();

            Console.ReadKey();
        }

        static void TælTil10(int tal = 1)
        {
            if (tal > 10)
                return;

            Console.WriteLine(tal);
            tal++;
            TælTil10(tal);
        }
    }
}
