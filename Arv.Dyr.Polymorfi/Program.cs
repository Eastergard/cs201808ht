using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv.DyrPolymorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            Dyr d = new Dyr();
        }
    }

    protected class Dyr
    {
        private string _navn;

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public virtual void SigNoget()
        {
            Console.WriteLine("Jeg er et dyr og hedder " + this.Navn);
        }

    }

    class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en hund og hedder "+ this.Navn);
        }
    }

    class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en kat og hedder " + this.Navn);
        }
    }
}
