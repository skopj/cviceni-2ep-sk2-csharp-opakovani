using System;
using System.Security.Claims;

namespace _02_VstupVystup
{
    class Program
    {
        static void Main(string[] args)
        {
            // vystup dat do konzole
            Console.WriteLine("abc");
            Console.WriteLine(65465);
            Console.WriteLine("abc" + 123);
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.PI * 2);

            // vstup dat z konzole
            Console.ReadLine();

            // cely a pekne osetreny vstup dat
            // 0. priprava promennych (deklarace)
            string vstup; // retezec znaku (text)
            int hodnota; // cele cislo
            // 1. vyzva uzivateli
            Console.Write("Zadej něco: ");
            // 2. nacteni dat a ulozeni dat
            vstup = Console.ReadLine();
            // 3. reakce na vstup
            Console.WriteLine("Zadal/a jsi: " + vstup);

            // 1. a 2. zustavaji stejne
            Console.Write("Zadej číslo: ");
            vstup = Console.ReadLine();
            // 3a. zpracovani vstupnich dat

            try // blok kodu hrozici chybou
            {
                hodnota = Convert.ToInt32(vstup);
            }
            catch // zotaveni z chyby, pokud k ni dojde
            {
                ConsoleColor puvodniBarvaPisma = Console.ForegroundColor;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Zadanou hodnotu nelze použít jako číslo.");
                Console.WriteLine("Používá se místo toho hodnota 0.");
                hodnota = 0;

                Console.ForegroundColor = puvodniBarvaPisma;
            }

            int o1vetsi = hodnota + 1;
            // 3b. reakce na zpracovany vstup
            Console.WriteLine("Číslo o 1 větší než " + hodnota + " je " + o1vetsi + ".");

            double necelociselnaHodnota = double.NaN;
            double prevracenaHodnota = double.NaN;
            Console.Write("Zadej nenulové číslo: ");
            vstup = Console.ReadLine();

            try
            {
                necelociselnaHodnota = Convert.ToDouble(vstup);

                if (necelociselnaHodnota == 0)
                    throw new Exception("Dělení nulou."); // rucni vyvolani vyjimky

                prevracenaHodnota = 1 / necelociselnaHodnota;
            }
            catch
            {
                Console.WriteLine("Tak takhle ne!");

                Environment.Exit(0); // vypnuti programu
            }

            Console.WriteLine("Převrácená hodnota k číslu " + necelociselnaHodnota + " je " + prevracenaHodnota + ".");
        }
    }
}
