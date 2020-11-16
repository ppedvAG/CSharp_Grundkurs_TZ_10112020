using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul012_01_Listen
{
    public class HashtableBeispiel
    {
        public static void Beispiel()
        {
            //aehnlich wie Dictionary nur ohne Typdefinition
            //kann beliebige Datentypen in Key und Value beinhalten
            //Zugriff auf nicht vorhandene Keys ergibt keine Fehlermeldung

            Hashtable hashTable = new Hashtable();
            hashTable.Add("key1", "value1");
            hashTable.Add(20, 100);
            hashTable.Add(10.5, new DateTime(2012, 1, 1));

            //Rueckgabetyp ist immer ein object
            //Type sollte immer getestet werden bevor mit gearbeitet wird
            if (hashTable[10.5]?.GetType() == typeof(DateTime))
            {
                Console.WriteLine("Jahr: " + ((DateTime)hashTable[10.5]).Year);
            }

            Console.WriteLine();
            Console.WriteLine("DictionaryEntry :");
            //mithilfe der DictionaryEntries  kann man auf die einzelnen Elemente zugreifen
            foreach (DictionaryEntry item in hashTable)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            Console.WriteLine();
            Console.WriteLine("hashTable.Keys:");
            //mithilfe der Eigenschaft Keys kann auf eine Auflistung aller Keys zugegriffen werden
            foreach (var item in hashTable.Keys)
            {
                Console.WriteLine($"Key: {item}");
            }

            Console.WriteLine();
            Console.WriteLine("hashTable.Values:");
            //mithilfe der Eigenschaft Keys kann auf eine Auflistung aller Keys zugegriffen werden
            foreach (var item in hashTable.Values)
            {
                Console.WriteLine($"Value: {item}");

            }
        }
    }
}
