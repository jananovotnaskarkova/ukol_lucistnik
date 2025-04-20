using System.Runtime.InteropServices;

namespace SimulatorLucistnika;

class Program
{
    static void Main(string[] args)
    {
        Lucistnik karel = new Lucistnik("Karel", 7);

        while (true)
        {
            karel.ZobrazStav();
            Lucistnik.VypisMenu();
            string vyzva = "Zadej prosim cislo z menu";
            bool cisloZMenu = false;
            
            while (!cisloZMenu)
            {            
                int zadani = NactiKladneCeleCisloZKonzole(vyzva);
                
                switch (zadani)
                {
                    case 1:
                        karel.Vystrel();
                        cisloZMenu = true;
                        break;
                    case 2:
                        string vyzvaPocetSipu = "Zadej kolik sipu se ma pridat";
                        int pocet = NactiKladneCeleCisloZKonzole(vyzvaPocetSipu);
                        karel.PridejSipy(pocet);
                        cisloZMenu = true;
                        break;
                    case 3:
                        Console.WriteLine("Ukoncuji program");
                        return;
                    default:
                        Console.WriteLine("Neplatna volba");
                        break;
                }
            }
            
        }
    }

    public static int NactiKladneCeleCisloZKonzole(string vyzva)
    {
        Console.WriteLine(vyzva);
        int cislo = 0;
        bool validniVstup = false;
        string chybovaHlaska = "Nezadal jsi kladne cele cislo, zkus to prosim znovu";

        while (!validniVstup)
        {
            string vstup = Console.ReadLine();

            if (int.TryParse(vstup, out cislo))
            {
                if (cislo > 0)
                {
                    validniVstup = true;
                }
                else
                {
                    Console.WriteLine(chybovaHlaska);
                }
            }
            else
            {
                Console.WriteLine(chybovaHlaska);
            }
        }
        return cislo;
    }
}
