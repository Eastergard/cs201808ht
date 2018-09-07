using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv.ObjectPolymorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            Faktura f = new Faktura() { Nr = 215, Dato = DateTime.Now.Date, Kunde = "Poul A. Andersen" };

            Console.WriteLine(f.ToString());

            Console.ReadKey();
        }
    }

    class Faktura
    {
        public int Nr { get; set; }
        public DateTime Dato { get; set; }
        public string Kunde { get; set; }

        public override string ToString()
        {
            return $"Faktura til {Kunde} nr {Nr} fra {Dato}";
        }
    }
}
