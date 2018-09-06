using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Split
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "3;5;22;1;10;15;5";
            string[] arr = txt.Split(';');

            int sum = 0;
            foreach (var tal in arr)
            {
                sum += Convert.ToInt32(tal);
            }

            Console.WriteLine(sum.ToString());
            Console.ReadKey();
        }
    }
}
