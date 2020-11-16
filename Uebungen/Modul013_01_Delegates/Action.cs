using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Modul013_01_Delegates
{
    public class ActionBeispiel
    {
        public static Action<int, int> MeineAction; 

        public static void Beispiel()
        {
            //eine Methode kann ueber den "+="-Operator dem Action-Delegate angehangen werden
            //es koennenn mehrere Methoden als Referenz angegeben werden
            //referenzierten Methoden muessen als Rueckgabewert "void" haben
            MeineAction += new Action<int, int>(Addieren);
            MeineAction += new Action<int, int>(Subtrahieren);
            MeineAction += new Action<int, int>(Multiplizieren);

            Console.WriteLine("Aufruf der Actions");
            //Aufruf der Action 
            MeineAction(10, 20);
        }

        public static void Addieren(int zahl1, int zahl2)
        {
            Console.WriteLine($"Die Summe aus {zahl1} und {zahl2} ist {zahl1 + zahl2}");
        }

        public static void Subtrahieren(int zahl1, int zahl2)
        {
            Console.WriteLine($"Die Differenz aus {zahl1} und {zahl2} ist {zahl1 - zahl2}");
        }

        public static void Multiplizieren(int zahl1, int zahl2)
        {
            Console.WriteLine($"Das Produkt aus {zahl1} und {zahl2} ist {zahl1 * zahl2}");
        }
    }
}
