using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber.SimpelEgenskab
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v = new Vare();
            v.Navn = "vare #1";
            v.Pris = 100;
            Console.WriteLine(v.PrisMedMoms());
            Vare v2 = new Vare("vare #2", 200);
            Console.WriteLine(v2.PrisMedMoms());

            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }




    public class Vare
    {
        private string _navn;
        private double _pris;

        public Vare() { }

        public Vare(string navn, double pris)
        {
            this.Navn = navn;
            this.Pris = pris;
        }

        public string Navn
        {
            get
            {
                Console.WriteLine("Navn er sat til:" + _navn);
                return _navn;
            }
            set
            {
                Console.WriteLine("Navn sættes til:" + value);
                _navn = value;
            }
        }


        public double Pris
        {
            get
            {
                Console.WriteLine("Pris er sat til:" + _pris);
                return _pris;
            }
            set
            {
                Console.WriteLine("Pris sættes til:" + value);
                _pris = value;
            }
        }

        public double PrisMedMoms()
        {
            return Pris * 1.25;
        }
    }

}
