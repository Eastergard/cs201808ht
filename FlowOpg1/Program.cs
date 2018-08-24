using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowOpg1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                int tal = 0;
                for (int j = 1; j <= 10; j++)
                {
                    tal += i;
                    if (tal > 50)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = ConsoleColor.Gray;

                    Console.Write(tal.ToString().PadLeft(4));
                }

                Console.Write("\n");
            }



            Console.ReadKey();
        }
    }
}
