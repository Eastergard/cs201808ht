using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace io.FileDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindesDenne(@"C:\temp"));

            Console.WriteLine();
            DenneIndeholder(@"C:\temp");

            Console.WriteLine();
            Console.WriteLine(File.Exists(@"C:\temp\data.txt"));


            File.WriteAllText(@"C:\temp\data.txt", "xxx");

            File.AppendAllText(@"C:\temp\data.txt", "yyy");

            Console.WriteLine();
            HentOgSkriv(@"C:\temp\data.txt");

            File.Delete(@"C:\temp\data.txt");


            Console.ReadKey();
        }

        public static bool FindesDenne(string s) => Directory.Exists(s);

        public static void DenneIndeholder(string s)
        {
            var filer = Directory.EnumerateFiles(s);

            if (!filer.Any())
                Console.WriteLine("Mappen er tom");
            else
                Console.WriteLine($"Stien {s} indeholder:");


            foreach (var fil in filer)
            {
                Console.WriteLine(fil);
            }
        }

        public static void HentOgSkriv(string s)
        {
            var txt = File.ReadAllText(s);
            Console.WriteLine(txt);
        }

    }
}
