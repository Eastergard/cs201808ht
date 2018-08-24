using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablerOpg4
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";
            string samletNavn = fornavn + " " + efternavn;
            string navnStort = samletNavn.ToUpper();
            string navnLille = samletNavn.ToLower();
            string del = samletNavn.Substring(7, 4);

            Console.WriteLine(fornavn);
            Console.WriteLine(efternavn);
            Console.WriteLine(samletNavn);
            Console.WriteLine(navnStort);
            Console.WriteLine(navnLille);
            Console.WriteLine(del);

            Console.ReadKey();
        }
    }
}
