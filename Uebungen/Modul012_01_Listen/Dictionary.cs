using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul012_01_Listen
{
    public class DictionaryBeispiel
    {
        public static void Beispiel()
        {
            //bekommt einen festgelegten Typ fuer die Keys und die Values
            Dictionary<int, string> stringDictionary = new Dictionary<int, string>();

            //mit Add wird ein Element dem Dictionary hinzugefuegt
            stringDictionary.Add(5, "Element 1");
            stringDictionary.Add(10, "Element 2");

            //mit dem Key kann auf das Element mithilfe der eckigen Klammern zugegriffen werden
            string value10 = stringDictionary[10]; // "Element 2"

            //mit ContainsKey kann geprueft werden ob ein Key vorhanden ist
            stringDictionary.ContainsKey(5); //true

            //mit ContainsValue kann geprueft werden ob ein Value vorhanden ist
            stringDictionary.ContainsValue("Element 3"); //false

            Console.WriteLine("KeyValuePairs:");
            //mithilfe der KeyValPairs kann man auf die einzelnen Elemente zugreifen
            foreach (KeyValuePair<int,string> item in stringDictionary)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            Console.WriteLine();
            Console.WriteLine("stringDictionary.Keys:");
            //mithilfe der Eigenschaft Keys kann auf eine Auflistung aller Keys zugegriffen werden
            foreach (var item in stringDictionary.Keys)
            {
                Console.WriteLine($"Key: {item}");
            }

            Console.WriteLine();
            Console.WriteLine("stringDictionary.Values:");
            //mithilfe der Eigenschaft Keys kann auf eine Auflistung aller Keys zugegriffen werden
            foreach (var item in stringDictionary.Values)
            {
                Console.WriteLine($"Value: {item}");

            }
        }
    }
}
