using System;

namespace _03_RidiciStruktury
{
    class Program
    {
        static void Main(string[] args)
        {
            int cislo;

            try
            {
                Console.Write("Zadej číslo: ");
                cislo = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Tak bohužel...");
                Environment.Exit(0);

                cislo = 0;
            }

            // 1. vetveni
            if (cislo > 0)
            {
                Console.WriteLine(cislo + " je kladné.");
            }
            else if(cislo < 0)
            {
                Console.WriteLine(cislo + " je záporné.");
            }
            else
            {
                Console.WriteLine(cislo + " je nulové.");
            }

            // 2. opakovani
            while(cislo > 0)
            {
                Console.WriteLine(cislo);
                //cislo = cislo - 1;
                cislo -= 1;
                //cislo--;
            }
            Console.WriteLine(cislo);

            // s operatory ++ a -- OPATRNE
            cislo = --cislo + ++cislo;
            Console.WriteLine(cislo);
            cislo = --cislo + cislo++;
            Console.WriteLine(cislo);
            cislo = cislo-- + cislo++;
            Console.WriteLine(cislo);

            do
            {
                cislo += 1;
                Console.WriteLine(cislo);
            }
            while (cislo < 0);

            // k cemu je dobry for??
            cislo = 0;
            while(cislo < 10)
            {
                Console.WriteLine(cislo);
                cislo += 1;
            }

            for (cislo = 0; cislo < 10; cislo++)
            {
                Console.WriteLine(cislo);
            }
        }
    }
}
