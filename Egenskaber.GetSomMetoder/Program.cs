using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber.GetSomMetoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Trekant t = new Trekant(10, 10);
            Console.WriteLine($"Areal {t.Areal}");
            Console.WriteLine($"Areal {t.ArealSomMetode()}");


            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }


    class Trekant
    {
        public int Grundlinje { get; private set; }
        public int Højde { get; private set; }

        public Trekant(int grundlinje, int højde)
        {
            if (this.Grundlinje >= 0 && this.Højde >= 0)
            {
                this.Grundlinje = grundlinje;
                this.Højde = højde;
            }
        }

        public double Areal
        {
            get { return this.Grundlinje * this.Højde * 0.5; } 
        }

        public double ArealSomMetode()
        {
            return this.Grundlinje * this.Højde * 0.5;
        }
    }
}
