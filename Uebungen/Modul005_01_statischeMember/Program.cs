using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul005_01_statischeMember
{
    class Program
    {
        static void Main(string[] args)
        {

            //Aufruf einer statischen Methode durch [Klassenname].[Methodenname]()
            Console.WriteLine("Text");

            //Aufruf einer statischen Methode mit Rueckgabewert
            string eingabe = Console.ReadLine();

            //Zuweisung mit einer statischen Eigenschaft durch [Klassenname].[Eigenschaft]
            DateTime heute = DateTime.Now;


            #region Funktionalitaet ohne Methode
            //gleiche Funktionalitaet wird mehrfach hintereinander geschrieben
            //bei Aenderungen muss jede Ausgabe/Berechnung/etc. angepasst werden
            int zahl1 = 1;
            int zahl2 = 2;
            int summe = zahl1 + zahl2;
            Console.WriteLine($"Die Summe von {zahl1} und {zahl2} ist {summe}.");

            zahl1 = 5;
            zahl2 = 9;
            summe = zahl1 + zahl2;
            Console.WriteLine($"Die Summe von {zahl1} und {zahl2} ist {summe}.");

            zahl1 = 2;
            zahl2 = 7;
            summe = zahl1 + zahl2;
            Console.WriteLine($"Die Summe von {zahl1} und {zahl2} ist {summe}.");
            #endregion
            Console.ReadKey();


            #region gleiche Funktionalitaet mit statischer Methode
            //Aufruf einer statischen Methode nur mit den unterschiedlichen Parametern
            //Aenderungen werden einmalig in der Methode gemacht und betreffen somit jeden Aufrug
            SummeAusgeben(1, 2);
            SummeAusgeben(5, 9);
            SummeAusgeben(2, 7);

            #endregion
            Console.ReadKey();
        }

        //statische Methode, welche zwei Parameter entgegennimmt und eine Ausgabe in der Console wiedergibt
        static void SummeAusgeben(int zahl1, int zahl2)
        {
            int summe = zahl1 + zahl2;
            Console.WriteLine($"Die Summe von {zahl1} und {zahl2} ist {summe}.");
        }
    }
}
