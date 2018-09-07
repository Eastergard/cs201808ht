using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv.Simpel
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person() { Fornavn = "Bjarke", Efternavn = "Nielsen" };
            Console.WriteLine(p.FuldtNavn());

            Elev e = new Elev() { Efternavn = "t", Fornavn = "g", Klasselokale = "A" };
            Instruktør i = new Instruktør() { Efternavn = "2", Fornavn = "s", NøgleId = 1 };
            Console.WriteLine(p.FuldtNavn());
            Console.WriteLine(e.FuldtNavn());
            Console.WriteLine(i.FuldtNavn());
            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }


    class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public Person()
        {
            this.Fornavn = "";
            this.Efternavn = "";
        }

        public string FuldtNavn()
        {
            return this.Fornavn + " " + this.Efternavn;
        }
    }

    class Elev : Person
    {
        public string Klasselokale { get; set; }
    }

    class Instruktør : Person
    {
        public int NøgleId { get; set; }
    }
}
