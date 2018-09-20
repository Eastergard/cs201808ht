using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };


            int index = a.FindIndex(tal => tal == 51);
            Console.WriteLine(index);

            index = a.FindIndex(Find51);
            Console.WriteLine(index);

            a.ForEach(tal => Console.WriteLine(tal));

            a.ForEach(ListVærdi);

            Console.ReadKey();

        }

        public static bool Find51(int a) => a == 51;

        public static void ListVærdi(int a) => Console.WriteLine(a);

    }
}
