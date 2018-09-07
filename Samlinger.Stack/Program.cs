using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samlinger.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Bunke b = new Bunke();
            b.TilføjKort(new Kort() { Kulør = "Spar", Værdi = 2 });
            b.TilføjKort(new Kort() { Kulør = "Hjerter", Værdi = 14 });
            b.TilføjKort(new Kort() { Kulør = "Ruder", Værdi = 3 });
            b.Vis();

            var k = b.FjernKort();
            Console.WriteLine($"Fjerner kort: {k}.");


            b.Vis();

            Console.ReadKey();
        }
    }

    public class Kort
    {
        public string Kulør { get; set; }
        public int Værdi { get; set; }
        public override string ToString()
        {
            return this.Kulør + " " + this.Værdi;
        }
    }

    public class Bunke
    {
        private Stack<Kort> _bunke = new Stack<Kort>();


        public void TilføjKort(Kort kort)
        {
            Console.WriteLine($"Kort: {kort.ToString()} er blevet tilføjet til bunken.");
            this._bunke.Push(kort);
        }

        public string FjernKort()
        {
            return this._bunke.Pop().ToString();
        }

        public void Vis()
        {
            foreach (var kort in this._bunke)
            {
                Console.WriteLine($"Bunken indeholder: {kort.ToString()}.");
            }
        }
    }
}
