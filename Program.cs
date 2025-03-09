using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //switch= typ větvení, kde dochází k plnění podmínek
            //      -ve své podstatě jde ostejný princip jak if , els
            //      -vstupuje jiným způsobem do paměti
            //       - hodnotí zadanou proměnnou a podle jejího obsahu, rozhoduje, jakým směrem se program vydá
            //     -   VÝHODA =pro větší větvení (cca.  5 více), je to efektivnější elegatnější, než použití mnoho if příkazů

            //příklad syntaxe
            // jaký je den v týdnu podle čísla

            int den = 5; //=pátek
            switch (den)
            {

                case 1:
                    Console.WriteLine("pondělí");
                    break;
                case 2:
                    Console.WriteLine("úterý");
                    break;
                case 3:
                    Console.WriteLine("středa");
                    break;
                case 4:
                    Console.WriteLine("čtvrtek");
                    break;
                case 5:
                    Console.WriteLine("pátek");
                    break;
                case 6:
                    Console.WriteLine("sobota");
                    break;
                case 7:
                    Console.WriteLine("neděle");
                    break;

                default:
                    Console.WriteLine("10/10 svištů doporučuje switch");
                    break;
            }
            //swith příklady
            //program, který vyhodnocuje, zda je zadané písmeno je souhlaska/ a, e ,i ,o ,u
            char znak = 'A'; // shift ň
            switch (znak)
            {
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine("samohláska");
                    break;
                case 'S':
                    Console.WriteLine("svišť");
                    break;
                default:
                    Console.WriteLine("souhláska");
                    break;
            }
            // automat na svačiny
            //bude brát uživatelský vstup, vytvořte nabídku (např AA-šunková, AB- sýrová)



            Console.WriteLine("nabídka: AA- šunková, AB- sýrová, AC- česneková AD- kuřecí");
            string bageta = Console.ReadLine().ToUpper();
            switch (bageta)
            {
                case "AA":
                    Console.WriteLine("vybrali jste šunkovou za 44kč");
                    break;
                case "AB":
                    Console.WriteLine("vybrali jste sýrovou za 50kč");
                    break;
                case "AC":
                    Console.WriteLine("vybrali jste česnekovou za 45kč");
                    break;
                case "AD":
                    Console.WriteLine("vybrali jste kuřecí za 40Kč");
                    break;
                default:
                    Console.WriteLine("chybná volba");
                    break;
            }

            //vysvětelení syntaxe-
            //swith- nám uvozuje že bzačíná větvení
            // (promená)- hodnota, která se kontroluje
            //{ }- ohrádka pro dění větvení
            //case případ, k jakému může dojít
            // za case musí být zapsaná hodnota
            // do case se napíše kod
            // break _ konec větvení
            // default- výchozí hodnota, pokud nedošlo k jinému vyhodnocen
            Console.ReadKey();
        }
    }
}
