using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber.AutomatiskEgenskab
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Fornavn = "Mikkel";
            p.Efternavn = "Cronberg";
            Console.WriteLine(p.FuldtNavn());

            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    public class Person
    {
        public string Fornavn { get; set; }

        private string _efternavn;

        public string Efternavn
        {
            get { return _efternavn; }
            set
            {
                if (value.Length < 3)
                    _efternavn = "";
                else
                    _efternavn = value;
            }
        }

        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }

    }
}
