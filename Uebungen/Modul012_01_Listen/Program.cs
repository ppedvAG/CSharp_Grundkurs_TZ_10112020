using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul012_01_Listen
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("####List<T> Beispiel####");
            ListBeispiel.Beispiel();
            Console.WriteLine();
            Console.WriteLine("####Stack<T> Beispiel####");
            StackBeispiel.Beispiel();
            Console.WriteLine();
            Console.WriteLine("####Queue<T> Beispiel####");
            QueueBeispiel.Beispiel();
            Console.WriteLine();
            Console.WriteLine("####Dictionary<TKey, TValue> Beispiel####");
            DictionaryBeispiel.Beispiel();
            Console.WriteLine();
            Console.WriteLine("####Hashtable Beispiel####");
            HashtableBeispiel.Beispiel(); 
            Console.WriteLine();
            Console.WriteLine("####Tuple Beispiel####");
            TupleBeispiel.Beispiel();

            Console.ReadLine(); 
        }
    }
}
