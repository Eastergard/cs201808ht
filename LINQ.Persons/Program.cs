using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new PersonNuGetPackage.PersonRepositoryRandom();
            var people = r.GetPeople(10);
            Skriv(people);

            Console.WriteLine();
            var res = people.OrderBy(p => p.Name);
            foreach (var person in res)
                Console.WriteLine(person.Name);

            Console.WriteLine();
            var res1 = people.OrderBy(p => p.Gender).ThenBy(p => p.Name);
            foreach (var person in res1)
                Console.WriteLine(person.Gender.ToString() +" " + person.Name);

            Console.WriteLine();
            var res2 = people.Where(p => p.Height < 170);
            foreach (var person in res2)
                Console.WriteLine(person.Height.ToString() + " " + person.Name);

            Console.WriteLine();
            var res3 = people.Where(p => p.Height <= 170 && p.IsHealthy);
            foreach (var person in res3)
                Console.WriteLine(person.Height.ToString() + " " + person.Name);

            Console.WriteLine();
            var res4 = people.GroupBy(p => p.Gender);
            foreach (var gender in res4)
            {
                Console.WriteLine();
                Console.WriteLine("Nu udskrives et køn:");
                foreach (var person in gender)
                {
                    Console.WriteLine(person.Gender.ToString() + " " + person.Name);
                }
            }

            Console.WriteLine();
            var res5 = people.OrderBy(p => p.Name).Select(p => new { navn = p.Name, højde = p.Height });
            foreach (var person in res5)
                Console.WriteLine(person.højde.ToString() + " " + person.navn);

            Console.WriteLine();
            var res6 = people.OrderBy(p => p.Height);
            
            for (int i = 170; i <= 210; i += 10)
            {
                Console.WriteLine();
                foreach (var p in res6.Where(n => n.Height < i && n.Height > i-10))
                {
                    Console.WriteLine(p.Height + " " + p.Name);
                }
            }
                
            


            Console.ReadKey();
        }


        public static void Skriv(List<PersonNuGetPackage.Person> p)
        {
            foreach (var person in p)
                Console.WriteLine(person.Name);
        }
    }
}
