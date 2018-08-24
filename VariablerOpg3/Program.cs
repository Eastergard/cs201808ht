using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablerOpg3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Udskrver csc og 0.
            Filtyper ft = Filtyper.csv;
            Console.WriteLine(ft);
            Console.WriteLine((int)ft);

            // Danner en person "Mikkel" med id 1.
            Person p = new Person()
            {
                Navn = "Mikkel",
                Id = 1
            };
            Console.WriteLine(p.Navn);
            Console.WriteLine(p.Id);

            Console.ReadKey();
        }
    }

    /// <summary>
    /// Person
    /// </summary>
    struct Person
    {
        public int Id;
        public string Navn;
    }

    /// <summary>
    /// Filtyper
    /// </summary>
    enum Filtyper
    {
        csv,
        pdf,
        txt
    }

}
