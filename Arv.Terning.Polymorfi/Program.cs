using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv.Terning.Polymorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning();
            t.Skriv();
            t.Ryst();
            t.Skriv();

            LudoTerning l = new LudoTerning();
            l.Skriv();
            Console.WriteLine(l.ErGlobus());
            Console.WriteLine(l.ErStjerne());

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
        private static Random _rnd;

        static Terning() => _rnd = new Random();

        public Terning() => this.Ryst();

        public Terning(int tal) => this.Værdi = tal;


        public int Værdi
        {
            get { return _værdi; }
            set
            { _værdi = (value > 0 && value < 7) ? value : 1; }
        }

        public void Ryst() { Værdi = _rnd.Next(1, 7); }

        public virtual void Skriv() { Console.WriteLine("[" + Værdi.ToString() + "]"); }

    }

    class LudoTerning : Terning
    {
        public LudoTerning()
        {
            new Terning();
        }

        public LudoTerning(int tal)
        {
            new Terning(tal);
        }

        public bool ErGlobus() => this.Værdi == 3 ? true : false;
        public bool ErStjerne() => this.Værdi == 5 ? true : false;

        public override void Skriv()
        {
            if (ErGlobus())
                Console.WriteLine("[G]");
            else if (ErStjerne())
                Console.WriteLine("[S]");
            else
                base.Skriv();
        }

    }

}
