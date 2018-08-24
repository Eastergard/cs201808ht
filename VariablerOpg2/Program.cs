using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablerOpg2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(1991, 2, 17, 12, 00, 00);
            DateTime d3 = new DateTime(1992, 7, 24, 12, 00, 00);
            TimeSpan t2 = new TimeSpan(16, 00, 00);
            TimeSpan t3 = new TimeSpan(00, 30, 00);
            TimeSpan t4 = t2 - t3;
            TimeSpan t5 = t2 + t3;

            // Udskriver dette tidspunkt.
            Console.WriteLine(d1);
            // Lægger 10 dage til og udskriver.
            d1 = d1.AddDays(10);
            Console.WriteLine(d1);
            // Lægger 20 min. til og udskriver.
            d1 = d1.AddMinutes(20);
            Console.WriteLine(d1);
            // Trækker en måned fra og udskriver.
            d1 = d1.AddMonths(-1);
            Console.WriteLine(d1);

            // Differencen mellem d3 og d2 i dage.
            Console.WriteLine(d3.Subtract(d2).TotalDays);

            // Udskriver t2.
            Console.WriteLine(t2);

            // Udskriver t3.
            Console.WriteLine(t3);

            // Udskriver t4.
            Console.WriteLine(t4);

            // Udskriver t5.
            Console.WriteLine(t5);

            Console.ReadKey();
        }
    }
}
