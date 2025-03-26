using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace úkol
{
    internal class Progra
    {
        static void Main(string[] args)
        {
            //Return the Sum of Two Numbers
            int cislo1 = 5;
            int cislo2 = 7;
            int vysledek = (cislo1 + cislo2);
            Console.WriteLine(vysledek);

            //Convert Minutes into Seconds
            Console.WriteLine("zadejte počet sekund");
            int cislo3 = Convert.ToInt32(Console.ReadLine());
            int vysledek2 = cislo3 * 60;
            Console.WriteLine("2 minuty mají"+vysledek2);


            //Return the Next Number from the Integer Passed
            Console.WriteLine("zadejte číslo");
            float cislo4 = Convert.ToInt32(Console.ReadLine());
            float limit = cislo4 + 1;
           while (cislo4< limit)
            {
                cislo4++;
                
            }
            Console.WriteLine(cislo4);
            //Circuit Power Calculator
            float cislo5 = 4;
            float cislo6 = 3;
            float vysledek3 = cislo5 * cislo6;
            Console.WriteLine(cislo5 + "násobek" + cislo6 + "je " + vysledek3);

            //Convert Age to Days
            Console.WriteLine("zadejte kolik je vám let ");
            int rok = Convert.ToInt32(Console.ReadLine());

            float dny = rok * 365;
            Console.WriteLine("jste na světě " + dny + "dní");
            //Area of a Triangle

            int cislo7 = 7;
            int cislo8 = 4;
            int vysledek4 = (cislo7 * cislo8)/2;
            Console.WriteLine(vysledek4);
            // malá násobilak
            int nasobika = 1;
            while(nasobika < 100)
            {
                nasobika++;
                Console.WriteLine(nasobika);
            }
            //sudosst čísel
            Console.WriteLine("zadejte číslo ");
            int cislo10 = Convert.ToInt32(Console.ReadLine());

            switch (cislo10 / 2)
            {
                case 0:
                    Console.WriteLine("číslo je sudé");
                    break;
                default: Console.WriteLine("číslo neni sudé");
                    break;
            }

            // kávovár
            Console.WriteLine("Automat na kávu");
            Console.WriteLine("Vyberte druh kávy:");
            Console.WriteLine("AA - Espresso (25 Kč)");
            Console.WriteLine("BB - Americano (20 Kč)");
            Console.WriteLine("CC - Cappuccino (40 Kč)");
            Console.Write("Zadejte kód kávy: ");

            string bageta = Console.ReadLine();
            int cena_bagety = 0;


            switch (bageta.ToUpper()) // Převod na velká písmena pro jistotu
            {
                case "AA":
                    cena_bagety = 25;
                    break;
                case "BB":
                    cena_bagety = 20;
                    break;
                case "CC":
                    cena_bagety = 40;
                    break;
                default:
                    Console.WriteLine("Neplatný kód! Zvolte správnou bagetu.");
                    return;
            }

            Console.WriteLine($"Cena vybrané bagety: {cena_bagety} Kč.");

            int vklad_dohromady = 0;
            while (vklad_dohromady < cena_bagety)
            {
                Console.Write("Vložte mince: ");
                int vklad = Convert.ToInt32(Console.ReadLine()); // Pokud uživatel zadá nečíslo, program spadne

                if (vklad <= 0)
                {
                    Console.WriteLine("Neplatná částka. Zadejte prosím kladné číslo.");
                    continue;
                }

                vklad_dohromady += vklad;

                if (vklad_dohromady >= cena_bagety)
                {
                    int preplatek = vklad_dohromady - cena_bagety;
                    Console.WriteLine("Děkujeme za nákup!");
                    if (preplatek > 0)
                    {
                        Console.WriteLine($"Vracíme {preplatek} Kč zpět.");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine($"Ještě zbývá doplatit {cena_bagety - vklad_dohromady} Kč.");
                }
            }
            Console.WriteLine("chcet ke caffe mléko zadejte 1 -ano ,2- ne");
            int milk = Convert.ToInt32(Console.ReadLine());
            if (milk <2)
            {
                Console.WriteLine("počkejte mleko se připravuje");
            }
            Console.WriteLine("Přejeme dobrou chuť!");
         
        
        Console.ReadKey();
        }
    }
}
