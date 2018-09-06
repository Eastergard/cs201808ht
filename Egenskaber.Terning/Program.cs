using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber.Terning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning();
            t.Skriv();
            t.Ryst();
            t.Skriv();
            t.Værdi = 7;
            t.Skriv();
            t = new Terning(6);
            t.Skriv();

            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class Terning
    {
        private int _værdi;
        private static Random _rnd = new Random();

        public Terning()
        {
            this.Ryst();
        }

        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }

        public int Værdi
        {
            get
            {
                Console.WriteLine("Nu læses Værdi: " + _værdi);
                return _værdi;
            }
            set
            {
                Console.WriteLine("Nu sættes Værdi: " + value);
                if (value < 1 || value > 6)
                    _værdi = 1;
                else
                    _værdi = value;
            }
        }

        public void Ryst()
        {
            Værdi = _rnd.Next(1, 7);
        }

        public void Skriv()
        {
            Console.WriteLine("[" + Værdi + "]");
        }

    }

}
