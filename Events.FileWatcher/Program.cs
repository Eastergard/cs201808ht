using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.FileWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;

            w.Changed += (s,e) => Console.WriteLine(DateTime.Now.ToLongTimeString() + $": Filen {e.Name} er rettet.");
            w.Created += (s, e) => Console.WriteLine(DateTime.Now.ToLongTimeString() + $": Filen {e.Name} er oprettet.");
            w.Deleted += (s, e) => Console.WriteLine(DateTime.Now.ToLongTimeString() + $": Filen {e.Name} er slettet.");
            w.Renamed += (s, e) => Console.WriteLine(DateTime.Now.ToLongTimeString() + $": Filen {e.Name} er omdøbt.");

            do
            {

            } while (true);
        }
    }
}
