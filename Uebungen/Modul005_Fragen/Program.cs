using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul005_Fragen
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                Console.WriteLine("Waehle eine Rechenart aus:");
                Console.WriteLine("1 => +");
                Console.WriteLine("2 => -");
                Console.WriteLine("3 => *");
                Console.WriteLine("4 => /");

                int rechenart = int.Parse(Console.ReadLine());

                if (rechenart == 1)
                {
                    Addition();
                }
                else if (rechenart == 2)
                {
                    Subtraktion();
                }
                else if (rechenart == 3)
                {
                    Multiplikation();
                }
                else if (rechenart == 4)
                {
                    Division();
                }
                else
                {
                    Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 4 ein!");
                }

                Console.WriteLine("Neue Rechenart waehlen? (J)");
                
            } while (Console.ReadLine().ToUpper() == "J");

            Console.WriteLine("Anwendung wird beendet..");
            Console.ReadLine();
        }
        static void Addition()
        {
            Console.WriteLine("Gebe sie den ersten Summanden ein:");
            int summand1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Gebe sie den zweiten Summanden ein:");
            int summand2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Die Summe der zwei Zahlen ist " + (summand1 + summand2));
        }
        static void Subtraktion()
        {
            Console.WriteLine("Geben Sie den Minuend ein");
            int minuend = int.Parse(Console.ReadLine());

            Console.WriteLine("Geben Sie den Subtrahend ein");
            int subtrahend = int.Parse(Console.ReadLine());

            Console.WriteLine("Die Differenz der beiden Zahlen ist " + (minuend - subtrahend));
        }

        static void Multiplikation()
        {
            Console.WriteLine("Geben Sie den Multiplikator ein");
            int multiplikator = int.Parse(Console.ReadLine());

            Console.WriteLine("Geben Sie den Multiplikand ein");
            int multiplikand = int.Parse(Console.ReadLine());

            Console.WriteLine("Das Produkt der beiden Zahlen ist " + (multiplikator * multiplikand));
        }

        static void Division()
        {
            Console.WriteLine("Geben Sie den Dividend  ein");
            int dividend = int.Parse(Console.ReadLine());

            Console.WriteLine("Geben Sie den Divisor  ein");
            int divisor = int.Parse(Console.ReadLine());
            double quotien = dividend / (divisor == 0 ? 1 : divisor);

            Console.WriteLine("Der Quotient der beiden Zahlen ist " + quotien);
        }
    }
}
