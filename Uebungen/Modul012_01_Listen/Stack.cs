using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul012_01_Listen
{
    public class StackBeispiel
    {
        public static void Beispiel()
        {
            //arbeitet nach dem Last In First Out Prinzip
            //Elemente werden "nach oben" gestapelt und "von oben" abgearbeitet
            Stack<string> stringStack = new Stack<string>();
            
            //mit Push wird ein Element hinzugefuegt
            stringStack.Push("Element 1");
            stringStack.Push("Element 2");

            foreach (var item in stringStack)
            {
                Console.WriteLine(item); 
            }
            //Element 1
            //Element 2

            //mit Peak bekommt man das oberste Element zurueck
            stringStack.Peek();  //=> "Element 2"

            //mit Pop bekommt man das oberste Element zurueck und es wird aus dem Stack entfernt
            stringStack.Pop();   //=>  Element 2 herunternehmen
            
            Console.WriteLine("nach Pop");
            foreach (var item in stringStack)
            {
                Console.WriteLine(item);
            }
            //Element 1

        }
    }
}
