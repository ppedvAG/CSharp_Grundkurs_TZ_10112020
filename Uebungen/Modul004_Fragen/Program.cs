using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul004_Fragen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Taschenrechner();
            Lotto();
        }

        static void Taschenrechner()
        {
            do
            {
                Console.WriteLine("Waehle eine Rechenart aus:");
                Console.WriteLine("1 => +");
                Console.WriteLine("2 => -");
                Console.WriteLine("3 => *");
                Console.WriteLine("4 => /");

                int rechenart = int.Parse(Console.ReadLine());

                if (rechenart >= 1 && rechenart <= 4)
                {
                    Console.WriteLine("Gebe die erste Zahl ein:");
                    int zahl1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Gebe die zweite Zahl ein:");
                    int zahl2 = int.Parse(Console.ReadLine());

                    int ergebnis;
                    if (rechenart == 1)
                    {
                        ergebnis = zahl1 + zahl2;
                    }
                    else if (rechenart == 2)
                    {
                        ergebnis = zahl1 - zahl2;
                    }
                    else if (rechenart == 3)
                    {
                        ergebnis = zahl1 * zahl2;
                    }
                    else
                    {
                        if (zahl2 == 0)
                        {
                            ergebnis = zahl1;
                        }
                        else
                        {
                            ergebnis = zahl1 / zahl2;
                        }
                    }
                    Console.WriteLine($"Das Ergebnis der Berechnung ist {ergebnis}");
                }
                else
                {
                    Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 4 ein!");
                }

                Console.WriteLine("Erneut ausfuehren? (J)");
            } while (Console.ReadLine().ToUpper() == "J");

            Console.WriteLine("Anwendung wird beendet..");
            Console.ReadLine();
        }

        static void Lotto()
        {
            Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 10 ein: ");
            int zahl1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 10 ein: ");
            int zahl2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 10 ein: ");
            int zahl3 = int.Parse(Console.ReadLine());

            Random randomGenerator = new Random();

            int zufall1 = randomGenerator.Next(1, 11);
            int zufall2 = randomGenerator.Next(1, 11);
            int zufall3 = randomGenerator.Next(1, 11);

            int anzahlRichtigeZahlen = 0;

            #region if 
            //if (zahl1 == zufall1)
            //{
            //    richtigeZahlen++;
            //}
            //else if (zahl1 == zufall2)
            //{
            //    richtigeZahlen++;
            //}
            //else if (zahl1 == zufall3)
            //{
            //    richtigeZahlen++;
            //}

            //if (zahl2 == zufall1)
            //{
            //    richtigeZahlen++;
            //}
            //else if (zahl2 == zufall2)
            //{
            //    richtigeZahlen++;
            //}
            //else if (zahl2 == zufall3)
            //{
            //    richtigeZahlen++;
            //}

            //if (zahl3 == zufall1)
            //{
            //    richtigeZahlen++;
            //}
            //else if (zahl3 == zufall2)
            //{
            //    richtigeZahlen++;
            //}
            //else if (zahl3 == zufall3)
            //{
            //    richtigeZahlen++;
            //}
            #endregion

            #region if in kurz
            //if (zahl1 == zufall1 || zahl1 == zufall2 || zahl1 == zufall3)
            //{
            //    richtigeZahlen++;
            //}
            //if (zahl2 == zufall1 || zahl2 == zufall2 || zahl2 == zufall3)
            //{
            //    richtigeZahlen++;
            //}
            //if (zahl3 == zufall1 || zahl3 == zufall2 || zahl3 == zufall3)
            //{
            //    richtigeZahlen++;
            //}
            #endregion

            #region if in noch kuerzer
            //if (zahl1 == zufall1 || zahl1 == zufall2 || zahl1 == zufall3)
            //    richtigeZahlen++;
            //if (zahl2 == zufall1 || zahl2 == zufall2 || zahl2 == zufall3)
            //    richtigeZahlen++;
            //if (zahl3 == zufall1 || zahl3 == zufall2 || zahl3 == zufall3)
            //    richtigeZahlen++;


            #endregion

            #region mit Array
            int[] zufallszahlen = new int[] { zufall1, zufall2, zufall3 };
            anzahlRichtigeZahlen += zufallszahlen.Contains(zahl1) ? 1 : 0;
            anzahlRichtigeZahlen += zufallszahlen.Contains(zahl2) ? 1 : 0;
            anzahlRichtigeZahlen += zufallszahlen.Contains(zahl3) ? 1 : 0;
            #endregion

            Console.WriteLine($"1. Gewinnzahl: {zufall1}");
            Console.WriteLine($"2. Gewinnzahl: {zufall2}");
            Console.WriteLine($"3. Gewinnzahl: {zufall3}");

            Console.WriteLine($"Sie haben {anzahlRichtigeZahlen} richtige Zahlen getippt!");

            Console.ReadLine();
        }
    }
}
