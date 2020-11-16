using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Modul013_01_Delegates
{
    public class PredicateBeispiel
    {
        public static Predicate<int> MeinPredicate;

        public static void Beispiel()
        {
            //dem Predicate-Delegate wird nur eine Methode zugewiesen
            //die Methoden muessen als Rueckgabewert einen bool haben
            //die Methode muss als Parameter den Datentyp, welcher beim Predicate angegeben wurde, annehmen

            MeinPredicate = DurchSechsTeilbar;

            int[] intArray = new int[] { 1, 2, 3, 4, 5, 6,
                                         7, 8, 9, 10, 11, 12,
                                        13, 14, 15, 16, 17, 18,
                                        19, 20, 21, 22, 23, 24,
                                        25, 26, 27, 28, 29, 30};

            Console.WriteLine("Methode Find");
            //mit der Methode Find wird das erste Element zurueckegeben, der dem Predicate entspricht
            int ersterIntDurchSechsTeilbar = Array.Find(intArray, MeinPredicate);
            Console.WriteLine(ersterIntDurchSechsTeilbar);
            //6

            Console.WriteLine();
            Console.WriteLine("Methode FindAll");
            //mit der Methode FindAll werden alle Elemente zurueckgegeben, die dem Predicate entsprechen
            IEnumerable<int> intArrayDurchSechsTeilbar = Array.FindAll(intArray, MeinPredicate);
            foreach (int i in intArrayDurchSechsTeilbar)
                Console.Write(i + ", ");
            //6, 12, 18, 24, 30,

            Console.WriteLine("\n");
            Console.WriteLine("Lambda-Ausdruck");
            //man kann ein Predicate auch als Lambda-Ausdruck angeben
            IEnumerable<int> intArrayLambda = Array.FindAll(intArray, x => x % 6 == 0);
            foreach (int i in intArrayLambda)
                Console.Write(i + ", ");
            //6, 12, 18, 24, 30,
            Console.WriteLine();
        }

        public static bool DurchSechsTeilbar(int zahl1)
        {
            return zahl1 % 6 == 0;
        }
    }
}
