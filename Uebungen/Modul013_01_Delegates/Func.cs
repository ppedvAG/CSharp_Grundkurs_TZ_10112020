using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Modul013_01_Delegates
{
    public class FuncBeispiel
    {
        public static Func<int, int, string> MeineFunc;

        public static void Beispiel()
        {
            //eine Methode kann ueber den "+="-Operator dem Func-Delegate angehangen werden
            //es koennenn mehrere Methoden als Referenz angegeben werden
            //referenzierte Methoden muessen als Rueckgabewert den zuletzt angegbenen Datentyp haben (hier string)
            //referenzierte Methoden muessen als Parameterliste alle Datentypen bis auf den letzten entgegennehmen (hier int, int)
            MeineFunc += new Func<int, int, string>(Addieren);
            MeineFunc += new Func<int, int, string>(Subtrahieren);
            MeineFunc += new Func<int, int, string>(Multiplizieren);

            Console.WriteLine("Aufruf der Funcs");
            //Aufruf der Func 
            Console.WriteLine(MeineFunc(10, 20)); 
            //Das Produkt aus 10 und 20 ist 200
            //als Rueckgabe wird nur der letze Methodenaufruf zurueckgegeben

            Console.WriteLine();
            Console.WriteLine("einzelner Aufruf der Methoden");
            //um alle Rueckgaben zu erhalten muss man die Methoden einzeln ausfuehren lassen
            foreach (Func<int, int, string> item in MeineFunc.GetInvocationList())
            {
                Console.WriteLine(item(10, 20));
            }
            //Die Summe aus 10 und 20 ist 30
            //Die Differenz aus 10 und 20 ist - 10
            //Das Produkt aus 10 und 20 ist 200
        }

        public static string Addieren(int zahl1, int zahl2)
        {
            return $"Die Summe aus {zahl1} und {zahl2} ist {zahl1 + zahl2}";
        }

        public static string Subtrahieren(int zahl1, int zahl2)
        {
            return $"Die Differenz aus {zahl1} und {zahl2} ist {zahl1 - zahl2}";
        }

        public static string Multiplizieren(int zahl1, int zahl2)
        {
            return $"Das Produkt aus {zahl1} und {zahl2} ist {zahl1 * zahl2}";
        }
    }
}
