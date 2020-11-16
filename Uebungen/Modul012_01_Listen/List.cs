using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Modul012_01_Listen
{
    public class ListBeispiel
    {
        public static void Beispiel()
        {
            //bekommt einen festgelegten Typ fuer die Elemente
            List<string> stringListe = new List<string>();

            //mit Add wird ein Element dem Dictionary hinzugefuegt
            stringListe.Add("Das");
            stringListe.Add("ist");
            stringListe.Add("eine");
            stringListe.Add("Liste");
            stringListe.Add("mit");
            stringListe.Add("strings");

            foreach (var item in stringListe)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            //sucht nach einem Element, welches den Kriterien des Predicate entspricht
            string finden = stringListe.Find(x => x.Length > 3);
            Console.WriteLine($"gefundenes Element: {finden}");

            Console.WriteLine();
            //sortiert die Liste nach den Bedingungen der Comparison-Anweisung
            stringListe.Sort(delegate (string a, string b)
            {
                if (a.Length == b.Length)
                    return 0;
                else if (a.Length > b.Length)
                    return -1;
                else
                    return 1;
            });

            Console.WriteLine($"Sortiert nach Groesse:");
            foreach (var item in stringListe)
            {
                Console.WriteLine(item);
            }

        }
    }
}
