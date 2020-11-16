using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Modul012_01_Listen
{
    public class TupleBeispiel
    {
        public static void Beispiel()
        {
            //ueber die Methode Create in der Klasse Tuple kann ein Tuple-Objekt erstellt werden
            //ein Tuple kann unterschiedliche Datentypen entgegenehmen (ist generisch) 
            var hund = Tuple.Create("Bello", 11, 'm', 1.15m, true);

            //Zugriff auf die einzelnen Elemente erfolgt ueber die Eigenschaften Item1, Item2, .. 
            Console.WriteLine($"Name: {hund.Item1}");
            Console.WriteLine($"Alter: {hund.Item2}");
            Console.WriteLine($"Geschlecht: {hund.Item3}");
            Console.WriteLine($"Groesse: {hund.Item4}");
        }
    }
}
