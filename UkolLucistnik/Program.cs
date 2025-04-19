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
            int zadani = NactiCeleCisloZKonzole(vyzva);
            
            switch (zadani)
            {
                case 1:
                    karel.Vystrel();
                    break;
                case 2:
                    string vyzvaPocetSipu = "Zadej kolik sipu se ma pridat";
                    int pocet = NactiCeleCisloZKonzole(vyzvaPocetSipu);
                    karel.PridejSipy(pocet);
                    break;
                case 3:
                    Console.WriteLine("Ukoncuji program");
                    return;
                default:
                    Console.WriteLine("Neplatna volba, zadej prosim cislo z menu");
                    break;
            }
        }
    }

    public static int NactiCeleCisloZKonzole(string vyzva)
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
