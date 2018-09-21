using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCronberg;

namespace AnonymeTyper
{
    class Program
    {
        static void Main(string[] args)
        {

            dynamic hest = new { navn = "Per", alder = "10" };

            Console.WriteLine($"Hesten hedder {hest.navn} og er {hest.alder} år.");
            SkrivHest(hest);

            dynamic kat = new ExpandoObject();
            kat.navn = "Pelle";
            kat.alder = 65;

            Console.WriteLine($"Katten hedder {kat.navn} og er {kat.alder} år.");
            SkrivHest(kat);

            // Keep console open when debugging
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }


        public static void SkrivHest(dynamic a) => Console.WriteLine($"Hesten hedder {a.navn} og er {a.alder} år.");

    }
}
