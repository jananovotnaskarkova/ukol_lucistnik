using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SimulatorLucistnika
{
    public class Lucistnik
    {
        private string Jmeno;
        private int PocetSipu;

        public Lucistnik(string jmeno, int pocetSipu)
        {
            Jmeno = jmeno;
            PocetSipu = pocetSipu;
        }

        public void Vystrel()
        {
            if (PocetSipu > 0)
            {
                PocetSipu--;
                Console.WriteLine("Lucistnik uspesne vystrelil");
            }
            else
            {
                Console.WriteLine("Lucistnik ma malo sipu, takze nemuze vystrelit");
            }
        }

        public void PridejSipy(int pocet)
        {
            if (pocet > 0)
            {
                PocetSipu = PocetSipu + pocet;
                (string, string) koncovky = VratKoncovku(pocet);
                Console.WriteLine($"Lucistnikovi byl{koncovky.Item1} pridan{koncovky.Item1} {pocet} sip{koncovky.Item2}");
            }
            else
            {
                Console.WriteLine("Nulovy ani zaporny pocet sipu nelze pridat");
            }
        }

        public void ZobrazStav()
        {
            Console.WriteLine("==============Info==============");
            Console.WriteLine($"Lucistnik se jmenuje {Jmeno} a ma {PocetSipu} sip{VratKoncovku(PocetSipu).Item2}");
        }

        private static (string, string) VratKoncovku(int mnozstviSipu)
        {
            switch(mnozstviSipu)
            {
                case 2 or 3 or 4:
                    return ("y", "y");
                case >= 5 or 0:
                    return ("o", "u");
                default:
                    return ("", "");
            }
        }

        public static void VypisMenu()
        {
            Console.WriteLine("=============Menu===============");
            Console.WriteLine("1: vystreleni sipu");
            Console.WriteLine("2: pridani sipu");
            Console.WriteLine("3: ukonceni programu");
            Console.WriteLine("================================");
        }
    }
}