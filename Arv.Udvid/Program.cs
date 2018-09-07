using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv.Udvid
{
    class Program
    {
        static void Main(string[] args)
        {
            UdvidetRandom r = new UdvidetRandom();
            Console.WriteLine(r.NextBool()); // true eller false

            Console.ReadKey();
        }
    }


    class UdvidetRandom : Random
    {
        public bool NextBool()
        {
            int tal = Next(1, 1002);
            if (tal <= 500)
                return true;
            return false;
        }
    }
}
