using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul012_01_Listen
{
    public class QueueBeispiel
    {
        public static void Beispiel()
        {
            //arbeitet nach dem First In First Out Prinzip
            //Elemente werden in eine Reihe gepackt und nacheinander abgearbeitet
            Queue<string> stringQueue = new Queue<string>();

            //mit Enqueue wird ein Element hinzugefuegt
            stringQueue.Enqueue("Element 1");
            stringQueue.Enqueue("Element 2");
            
            foreach (var item in stringQueue)
            {
                Console.WriteLine(item);
            }
            //Element 1
            //Element 2

            //mit Peak bekommt man das aelteste Element zurueck
            stringQueue.Peek();  //=> "Element 2"

            //mit Dequeue bekommt man das aelteste Element zurueck und es wird aus der Queue entfernt
            stringQueue.Dequeue();   //=>  Element 2 herunternehmen

            Console.WriteLine("nach Dequeue");
            foreach (var item in stringQueue)
            {
                Console.WriteLine(item);
            }
            //Element 2
        }
    }
}
