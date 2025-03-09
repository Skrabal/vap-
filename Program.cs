using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ifElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zadejte den");
            string den2 = Console.ReadLine();
            if (den2 == "pondělí")
            {
                Console.WriteLine("začátek týdne");
            }
            else
            {
                Console.WriteLine("neni začátek týdne ");
            }
            //rok
            Console.WriteLine("zadejte zadejte rok");
            int rok1 = Convert.ToInt32(Console.ReadLine());
            if (rok1 % 4 == 0 && rok1 % 100 != 0 && rok1 % 400 != 0)
            {
                Console.WriteLine("je přestupný rok");
            }
            else
            {
                Console.WriteLine("neni přestupný rok ");
            }
            //prošel
            Console.WriteLine("zadejte známku");
            int cislo4 = Convert.ToInt32(Console.ReadLine());
            if (cislo4 > 4)
            {
                Console.WriteLine("neprošel");
            }
            else
            {
                Console.WriteLine("prošel");
            }
            //měsíc
            Console.WriteLine("zadejte měsíc");
            string mesic = Console.ReadLine();
            if (mesic == "leden" || mesic == "únor" || mesic =="březen")
            {
                Console.WriteLine("je zima");
            }
            else
            {
                Console.WriteLine("neni zima");
            }

            //velikost 50
            Console.WriteLine("zadejte číslo");
            int cislo5 = Convert.ToInt32(Console.ReadLine());
            if (cislo5 > 50)
            {
                Console.WriteLine("velké číslo");
            }
            else
            {
                Console.WriteLine("malé číslo");
            }
            // číslo0 až 100
            Console.WriteLine("zadejte číslo");
            int cislo6 = Convert.ToInt32(Console.ReadLine());
            if (cislo6 > 0 && cislo < 100)
            {
                Console.WriteLine("Číslo je mezi 0 a 100.");
            }
            else
            {
                Console.WriteLine("Číslo není v požadovaném rozsahu.");
            }
            //admin
            Console.WriteLine("zadejte jméno");
            string jmeno2 = Console.ReadLine();
            if (jmeno2 == "admin")
            {
                Console.WriteLine("uživatel je admin");
            }
            else
            {
                Console.WriteLine("uživatel neni admin");
            }
            //víkend
            Console.WriteLine("zadejte ¨den");
            string den = Console.ReadLine();
            if (den == "sobota" || den == "neděle")
            {
                Console.WriteLine("je víkend");
            }
            else
            {
                Console.WriteLine(" není víkend");
            }
            //délka textu
            Console.WriteLine("zadejte text");
            string text = Console.ReadLine();
            if (text.Length > 5)
            {
                Console.WriteLine("Dlouhý text");
            }
            else
            {
                Console.WriteLine("Krátký text");
            }
            //teplota
            Console.WriteLine("zadejte teplotu");
            int teplota = Convert.ToInt32(Console.ReadLine());
            if (teplota > 25)
            {
                Console.WriteLine("Teplo");
            }
            else
            {
                Console.WriteLine("Chladno");
            }
            //století
            Console.WriteLine("zadejte rok");
            int rok = Convert.ToInt32(Console.ReadLine());
            if (rok < 2000)
            {
                Console.WriteLine("20 století");
            }
            else
            {
                Console.WriteLine("¨21 století");
            }
            //menší než 0 nebo větší než 100
            Console.WriteLine("zadejte teplotu");
            int cislo7 = Convert.ToInt32(Console.ReadLine());
            if (cislo < 0 || cislo > 100)
            {
                Console.WriteLine("Číslo je menší než 0 nebo větší než 100");
            }
            else
            {
                Console.WriteLine("Číslo je mezi 0 a 100");
            }
            Console.ReadKey();
        }
    }
}
