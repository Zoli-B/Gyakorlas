using System;
using System.Globalization;
using System.Net.WebSockets;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            /*// Első feladat
            BekeroEsKiir();
            // Második feladat       
            ParosEllenorzes();
            //Harmadik feladat
            KicsiNagy();
            //Negyedik feladat
            Legkisebb();
            //Ötödik
            Szamsor();
            //Hatodik feladat
            SzamOsszead(osszesszam);
            //Hetedik feladat
            OsszesParos();
            //Nyolcadik feladat
            RandomNumber();
            //Kilencedik feladat
            Darabszam();
            //Tizedik feladat
            Legnagyobb();
            //Tizenegyedik feladat
            Atlag();
            //Tizenkettedik feladat*/
            LetterNumber();
            //Tizenharmadik feladat
            Palindrom();
            //Tizennegyedik
            SzoVizsgalat();

            Console.WriteLine("Nyomj meg egy gombot a kilépéshez...");
            Console.ReadKey();
        }

        static int[] osszesszam = new int[0];
        static int[] szamok = new int[0];
        static string palidrom = "";
        static HashSet<string> szotar = new HashSet<string>();

        // 1. feladat
        static void BekeroEsKiir()
        {
            Console.WriteLine("Első feladat");
            Console.Write("Add meg a neved: ");
            string name = Console.ReadLine();

            Console.Write("Add meg a születési éved: ");
            string date = Console.ReadLine();

            Console.Write("Add meg a kedvenc színed: ");
            string color = Console.ReadLine();

            Console.WriteLine($"{Adatok("Név: " + name + "\n", "Születési év: " + date + "\n", "Kedvenc szín: " + color)}");
        }
        static string Adatok(string x, string y, string z)
        {
            return x + y + z;
        }

        // 2. feladat
        static void ParosEllenorzes()
        {
            Console.WriteLine("Második feladat");
            Console.Write("Adj meg egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            if (szam % 2 == 0)
            {
                Console.WriteLine("Ez a szám páros.");
            }
            else
            {
                Console.WriteLine("Ez a szám páratlan.");
            }
        }

        //3. feladat
        static void KicsiNagy()
        {
            Console.WriteLine("Harmadik feladat");
            Console.WriteLine("Adj meg egy számot");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adj meg még egy számot");
            int szam2 = Convert.ToInt32(Console.ReadLine());

            if (szam < szam2)
            {
                Console.WriteLine("A " + szam2 + " nagyobb mint " + szam);

            }
            if (szam > szam2)
            {
                Console.WriteLine("A " + szam + " nagyobb mint " + szam2);

            }
        }
        //4. feladat
        static void Legkisebb()
        {
            Console.WriteLine("Negyedik feladat");
            Console.WriteLine("Adj meg 5 számot");
            int[] number = new int[5];
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = number.Min();
            Console.WriteLine("A legkisebb szám: " + max);

        }
        //5. feladat
        static int[] Szamsor()
        {
            Console.WriteLine("Ötödik feladat");
            int[] szam = new int[10];
            for (int i = 0; i < szam.Length; i++)
            {
                szam[i] = i + 1;
            }
            for (int i = 0; i < szam.Length; i++)
            {
                Console.WriteLine(szam[i]);
                osszesszam = szam;
            }


            return szam;
        }
        //6. feladat
        static void SzamOsszead(int[] a)
        {
            Console.WriteLine("Hatodik feladat");
            int osszeg = a.Sum();
            Console.WriteLine("A számok össz értéke: " + osszeg);

        }
        //7. feladat
        static void OsszesParos()
        {
            Console.WriteLine("Hetedik feladat");
            Console.WriteLine("Adj meg 5 számot:");

            int[] number = new int[5];
            int osszeg = 0;

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());

                if (number[i] % 2 == 0)
                {
                    osszeg += number[i];
                }
            }

            Console.WriteLine("A páros számok összértéke: " + osszeg);
        }
        //8. feladat
        static void RandomNumber()
        {
            Console.WriteLine("Nyolcadik feladat");
            Console.WriteLine("Adj meg egy számot a random generátor határértékéhez");
            int szam = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, szam + 1);
            int userNumber = 0;
            int Next = 4444;

            while (randomNumber != userNumber)
            {
                Console.WriteLine("Találd ki melyik számra gondoltam.. (Feladáshoz írd be 4444)");
                userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == Next)
                {
                    Console.WriteLine("Feladtad");
                    break;
                }
            }
            if (randomNumber == userNumber)
            {
                Console.WriteLine("Erre gondoltam");
            }

        }
        //9. feladat
        static void Darabszam()
        {
            Console.WriteLine("Kilencedik feladat");
            Console.WriteLine("Hány számot szeretnél eltárolni?");
            int kezdoszam = Convert.ToInt32(Console.ReadLine());
            int[] szam = new int[kezdoszam];

            for (int i = 0; i < szam.Length; i++)
            {
                Console.WriteLine("Add meg a számokat");
                szam[i] = Convert.ToInt32(Console.ReadLine());
            }
            string eredemny = string.Join(",", szam);
            Console.WriteLine("Összes szám " + eredemny);

            szamok = szam;
            Console.WriteLine(szamok.Length);

        }
        //10. feladat
        static void Legnagyobb()
        {
            Console.WriteLine("Tizedik feladat");
            Console.WriteLine("A legnagyobb szám " + szamok.Max());
        }
        //11. feladat
        static void Atlag()
        {
            Console.WriteLine("Tizenegyedik feladat");
            Console.WriteLine("A számok átlaga " + szamok.Average());
        }
        //12. feladat
        static void LetterNumber()
        {
            Console.WriteLine("Tizenkettedik feladat");
            Console.WriteLine("Írj be egy szót");

            string szoveg = Console.ReadLine();
            Console.WriteLine("A szöveg hossza " + szoveg.Length);

            palidrom = szoveg;
        }
        //13. feladat
        static void Palindrom()
        {
            Console.WriteLine("Tizenharmadik feladat");
            bool check = palidrom == new string(palidrom.Reverse().ToArray());
            Console.WriteLine(check ? "Palindrom" : "Nem palindrom");
        }
        //14. feladat
        static void SzoVizsgalat()
        {
            Console.WriteLine("Tizennegyedik feladat");
            //Console.WriteLine("Aktuális könyvtár: " + Directory.GetCurrentDirectory());


            try
            {
                string[] sorok = File.ReadAllLines("szotar.txt");
                szotar = new HashSet<string>(sorok.Select(s => s.Trim().ToLower()));
                Console.WriteLine("Szótár sikeresen beolvasva, " + szotar.Count + " szó található benne.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Hiba: A szotar.txt fájl nem található.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba történt a szótár beolvasásakor: " + ex.Message);
            }

            string normal = palidrom.Trim().ToLower();
            string forditott = new string(normal.Reverse().ToArray());

            if (szotar.Contains(forditott))
            {
                Console.WriteLine("A visszafelé írt szó is értelmes: " + forditott);
            }
            else
            {
                Console.WriteLine("A visszafelé írt szó értelmetlen: " + forditott);
            }
        }

    }
}
