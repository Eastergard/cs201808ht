using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser_SimpelKlasse_
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person()
            {
                Fornavn = "Bjarke",
                Efternavn = "Nielsen",
                Fødselsår = 1991
            };

            Console.WriteLine("Mit navn er: " + p.FuldtNavn());
            Console.WriteLine("Min alder er: " + p.Alder().ToString());

            Person p1 = new Person();

            Console.WriteLine("Mit navn er: " + p1.FuldtNavn());
            Console.WriteLine("Min alder er: " + p1.Alder().ToString());

            Person p2 = new Person("Anja", "Christensen", 1992);

            Console.WriteLine("Mit navn er: " + p2.FuldtNavn());
            Console.WriteLine("Min alder er: " + p2.Alder().ToString());

            Console.ReadKey();

        }

    }

    class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;

        public Person()
        {
            this.Fornavn = "";
            this.Efternavn = "";
        }

        public Person(string fornavn, string efternavn, int fødselsår)
        {
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;
            this.Fødselsår = fødselsår;
        }


        public string FuldtNavn()
        {
            return this.Fornavn + " " + this.Efternavn;
        }

        public int Alder()
        {
            if (this.Fødselsår != 0)
                return DateTime.Now.Year - this.Fødselsår;
            return 0;
        }
    }

}
