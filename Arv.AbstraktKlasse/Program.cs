using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv.AbstraktKlasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Kursist k = new Kursist() { ID = 1, Navn = "a" };
            k.Skriv1();
            k.Skriv2();

            Console.ReadKey();
        }
    }

    abstract class Person
    {
        public int ID { get; set; }
        public string Navn { get; set; }

        public void Skriv1()
        {
            Console.WriteLine($"Person med id {ID} og navn {Navn}");
        }

        public abstract void Skriv2();

    }

    class Kursist : Person
    {
        public override void Skriv2()
        {
            Console.WriteLine($"Kursist med id {ID} og navn {Navn}");
        }
    }
}
