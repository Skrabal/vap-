using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //hmotnost
            Console.WriteLine("zadejte vaši hmotnost v kg");
            double hmotnost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("zadejte vaši výšku v m");
            double velikost = Convert.ToDouble(Console.ReadLine());
            double bmi = hmotnost / Math.Pow(velikost, 2);
            if (bmi < 18.5)
            {
                Console.WriteLine("...podváha");
            }
            else if (bmi >= 18.5 && bmi <= 24.99) {
                Console.WriteLine("...optimální váha");
            }
            else if (bmi <= 24.99 && bmi <= 29.99)
            {
                Console.WriteLine("...nadváha");
            }
            else
            {
                Console.WriteLine("došlo k neočekávané hodnotě");
            }
            //Určí, zda předaná proměnná je liché nebo sudé číslo
            Console.WriteLine("zadejte číslo");
            float cislo = float.Parse(Console.ReadLine());

            if (cislo % 2 == 0)
            {

                Console.WriteLine("číslo je sudé");
            }
            else if (cislo % 2 == 1)
            {
                Console.WriteLine("číslo je liché");
            }
                
            else
            {
                Console.WriteLine("číslo je nula");
            }
            //Bude hodnoty 0-100 přiřazovat k příslušným známkám
            Console.WriteLine("zadejte počet bodů vkteré jste získaly v testu");
            float cislo2 = float.Parse(Console.ReadLine());
            if (cislo2 >= 95)
            {
                Console.WriteLine("známka je 1");
            }
            else if (cislo2 >= 85) 
            {
                Console.WriteLine("známka je 2");     
            }
            else if(cislo2 >= 65)
            {
                Console.WriteLine("známka je 3");
            }
            else if (cislo2 >= 50)
            {
                Console.WriteLine("známka je 4");
            }
            else 
            {
                Console.WriteLine("známka je 5");
            }

            // ||    &&
            // ROKY NA DNY
            Console.WriteLine("UVEDTE POČET LET");
            int rok = Convert.ToInt32(Console.ReadLine());
            int dny = rok * 365;
            Console.WriteLine("rok "+rok + "má" + dny + "dní");
            if (rok %4==0 && rok %400==0)
            {
                Console.WriteLine("rok je přestupný");
            }
            else
            {
                Console.WriteLine("rok neni přestupný");
            }
            Console.WriteLine("Automat na svačinu");
            Console.WriteLine("Vyberte bagetu:");
            Console.WriteLine("AA - Šunková bageta (25 Kč)");
            Console.WriteLine("BB - Sýrová bageta (20 Kč)");
            Console.WriteLine("CC - Stripsová bageta (40 Kč)");
            Console.Write("Zadejte kód bagety: ");

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

            Console.WriteLine("Přejeme dobrou chuť!");
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
