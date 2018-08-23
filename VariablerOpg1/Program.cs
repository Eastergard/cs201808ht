using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablerOpg1
{
    class Program
    {
        static void Main(string[] args)
        {
            int heltal = 10;
            double kommatal = 12.5;

            // Adderer heltal med 1.
            Console.WriteLine($"heltal = {heltal++}");
            // Substraherer heltal med 1.
            Console.WriteLine($"heltal = {heltal--}");
            // Adderer heltal med 1.
            Console.WriteLine($"heltal = {heltal += 20}");

            // Adderer kommatal med 1.
            Console.WriteLine($"kommatal = {kommatal++}");
            // Substraherer kommatal med 1.
            Console.WriteLine($"kommatal = {kommatal--}");
            // Multiplicerer kommatal med 2.
            Console.WriteLine($"kommatal = {kommatal *= 2}");



            Console.ReadKey();
        }
    }
}
