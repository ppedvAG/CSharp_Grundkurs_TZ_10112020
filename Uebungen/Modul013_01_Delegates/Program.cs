using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul013_01_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Action Beispiel:");
            ActionBeispiel.Beispiel();
    
            Console.WriteLine("\n################");
            Console.WriteLine("Func Beispiel:");
            FuncBeispiel.Beispiel();

            Console.WriteLine("\n################");
            Console.WriteLine("Predicate Beispiel:");
            PredicateBeispiel.Beispiel();

            Console.WriteLine("\n################");
            Console.WriteLine("Anonyme Methoden Beispiel:");
            AnonymeMethodenBeispiel.Beispiel();
            Console.ReadLine();
        }
    }
}
