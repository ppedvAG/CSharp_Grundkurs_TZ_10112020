using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul004_03_Schleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            int dauer = 10;

            //inkrementale for-Schleife
            Console.WriteLine("inkrementale for-Schleife");
            for (int i = 0; i < dauer; i++)
            {
                //zaehlt nach jedem Durchlauf  i + 1  solange die Bedingung "i < dauer" erfuellt ist
                Console.Write($"{i}, ");
            }
            //0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
            Console.WriteLine("\n");

            //dekrementale for-Schleife
            Console.WriteLine("dekrementale for-Schleife");
            for (int i = dauer; i > 0; i--)
            {
                //zaehlt nach jedem Durchlauf  i - 1  solange die Bedingung "i > 0" erfuellt ist
                Console.Write($"{i}, ");
            }
            //10, 9, 8, 7, 6, 5, 4, 3, 2, 1,
            Console.WriteLine("\n");


            int[] zahlen = new int[] { 1, 5, 7, 9, 4, 2, 6, 45, 581 };
            //eine Array mit einer for-Schleife durchlaufen
            Console.WriteLine("Array mit for-Schleife");
            for (int i = 0; i < zahlen.Length; i++)
            {
                //ueber den Index i muss auf das Element zugegriffen werden
                Console.Write($"{zahlen[i]}, ");
            }
            //1, 5, 7, 9, 4, 2, 6, 45, 581
            Console.WriteLine("\n");

            //eine Array mit einer foreach-Schleife durchlaufen
            Console.WriteLine("Array mit foreach-Schleife");
            foreach (var item in zahlen)
            {
                //Zugriff auf das Element erfolgt direkt ueber die Variable item
                Console.Write($"{item}, ");
            }
            //1, 5, 7, 9, 4, 2, 6, 45, 581
            Console.WriteLine("\n");

            //kopfgesteuerte Schleife (while)
            string bedingung = "falsch";
            while (bedingung == "wahr")
            {
                //prueft vor jedem Durchlauf 
                //ob Bedingung true ist
            }

            //fussgesteuerte Schleife (do-while)
            do
            {
                //fuehrt erst aus und prüft dann
                //beginnt von vorne wenn 
                //Bedingung true ist
            } while (bedingung == "wahr");


            //Schluesselwort continue
            //beendet den aktuellen Durchlauf und springt zur naechsten Ueberpruefung
            Console.WriteLine("Schluesselwort continue");
            for (int i = 0; i < 10; i++)
            {
                if (i % 3 == 0) //durch drei teilbar
                    continue;

                Console.Write($"{i}, ");
            }
            //0, 1, 2, 4, 5, 7, 8,
            Console.WriteLine("\n");

            //Schluesselwort break
            //beendet den die komplette Schleife
            Console.WriteLine("Schluesselwort break");
            for (int i = 0; i < 10; i++)
            {
                if (i > 5)
                    break;

                Console.Write($"{i}, ");
            }
            //0, 1, 2, 3, 4, 5, 

            Console.ReadLine();

        }
    }
}
