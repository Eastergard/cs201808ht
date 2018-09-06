using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser_Terning_
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            Terning t2 = new Terning(true);
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();
        }
    }


    class Terning
    {
        public int Værdi;
        private bool Snyd;
        private static Random RND = new Random();

        public Terning()
        {
            this.Værdi = 1;
            this.Snyd = false;
        }

        public Terning(bool snyd)
        {
            this.Værdi = 1;
            this.Snyd = snyd;
        }

        public void Skriv()
        {
            Console.WriteLine("[" + this.Værdi + "]");
        }

        public void Ryst()
        {
            if (!this.Snyd)
                this.Værdi = RND.Next(1, 7);
            else
                this.Værdi = 6;
        }

    }
}
