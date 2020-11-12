using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul007_02_UeberlagerungParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ein Methodenname kann mehrfach in einer Klasse vorkommen, 
            //wenn die einzelnen Methoden unterschiedliche Parameterlisten haben.

            Console.WriteLine("Methode \"Addieren\" mit zwei int:");
            Console.WriteLine($"1 + 3 = {Ueberladung.Addieren(1, 3)}");
            //1 + 3 = 4
            Console.WriteLine();
            Console.WriteLine("Methode \"Addieren\" mit drei int:");
            Console.WriteLine($"5 + 9 + 1 = {Ueberladung.Addieren(5, 9, 1)}");
            //5 + 9 + 1 = 15
            Console.WriteLine();
            Console.WriteLine("Methode \"Addieren\" mit zwei double:");
            Console.WriteLine($"15.7 + 47.9 = {Ueberladung.Addieren(15.7, 47.9)}");
            //15.7 + 47.9 = 63.6

            Console.ReadLine();

            Console.WriteLine("Methode \"StringsVerbinden\" ohne Angabe eines Trennzeichens:");
            string ersterString = OptionaleParameter.StringsVerbinden(new string[] { "Das", "sind", "meine", "Strings", "ohne", "eigenes", "Trennzeichen" });
            Console.WriteLine(ersterString);
            //Das/sind/meine/Strings/ohne/eigenes/Trennzeichen
            Console.WriteLine();
            Console.WriteLine("Methode \"StringsVerbinden\" mit Angabe eines Trennzeichens:");
            string zweiterString = OptionaleParameter.StringsVerbinden(new string[] { "Das", "sind", "meine", "Strings", "mit", "eigenem", "Trennzeichen" }, '-');
            Console.WriteLine(zweiterString);
            //Das-sind-meine-Strings-mit-eigenem-Trennzeichen
            Console.WriteLine();


            Console.ReadLine();

            Console.WriteLine("Methode \"Addieren\" mit unterschiedlicher Anzahl von Parametern:");
            Console.WriteLine(SchluesselwortParams.Addiere(1, 2, 3, 4));  // 10
            Console.WriteLine(SchluesselwortParams.Addiere());  // 0
            Console.WriteLine(SchluesselwortParams.Addiere(6, 9));  // 15


            Console.ReadLine();

            int min;
            int max;
            int avg;
            int summe = SchluesselwortOut.Berechne(3, 5, out min, out max, out avg);
            Console.WriteLine("Berechnung von 3 und 5:");
            Console.WriteLine($"Summe: {summe}, Min: {min}, Max: {max}, Avg: {avg}");
            //Summe: 8, Min: 3, Max: 5, Avg: 4

            Console.ReadLine();

            int anzahl = 0;
            int ergebnis = 0;
            ergebnis = SchluesselwortRef.Addiere(ergebnis, 3, ref anzahl); 
            Console.WriteLine($"Nach der {anzahl}. Berechnung ist das Ergebnsis {ergebnis}.");
            //Nach der 1. Berechnung ist das Ergebnsis 3.
            ergebnis = SchluesselwortRef.Addiere(ergebnis, 8, ref anzahl);
            Console.WriteLine($"Nach der {anzahl}. Berechnung ist das Ergebnsis {ergebnis}.");
            //Nach der 2. Berechnung ist das Ergebnsis 11.
            ergebnis = SchluesselwortRef.Addiere(ergebnis, 45, ref anzahl);
            Console.WriteLine($"Nach der {anzahl}. Berechnung ist das Ergebnsis {ergebnis}.");
            //Nach der 3. Berechnung ist das Ergebnsis 56.
            
            Console.ReadLine();

        }
    }
}
