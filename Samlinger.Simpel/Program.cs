using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samlinger.Simpel
{
    class Program
    {
        static void Main(string[] args)
        {
            var familie = new List<Person>();
            familie.Add(new Person() { Id = 1, Navn = "Bjarke" });
            familie.Add(new Person() { Id = 2, Navn = "Anja" });
            familie.Add(new Person() { Id = 0, Navn = "Nano" });

            foreach (var person in familie)
            {
                Console.WriteLine($"Person med ID: {person.Id} er {person.Navn}.");
            }

            var husstand = new Person().Husstand;
            foreach (var person in familie)
            {
                husstand.Add(person.Id, person);
            }

            foreach (var person in husstand)
            {
                Console.WriteLine($"Person med ID: {person.Value.Id} er {person.Value.Navn}.");
            }

            Console.ReadKey();
        }
    }

    class Person
    {
        public Person()
        {
            this.Husstand = new Dictionary<int, Person>();
        }

        public int Id { get; set; }
        public string Navn { get; set; }

        public Dictionary<int, Person> Husstand { get; set; }

    }
}
