using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul007_01_Objekte
{
    class Program
    {
        static void Main(string[] args)
        {

            ///Objekte werden durch den Aufruf eines Konstruktors erstellt
            ///[Datentyp/Klassenname] [Objektname] = new [Konstruktor/Klassenname]([Parameter]);
            ///
            ///Es kann mehrere Objekte(Instanzen) einer Klasse geben.
            ///Objekte sind untereinander eigenstaendig und koennen nur auf ihre eigenen Daten zugreifen

            //ein Objekt erstellt durch den Aufruf eines Konstruktors mit zwei uebergebenen Parametern
            Person erstesObjekt = new Person("Max", "Mustermann");
            Console.WriteLine($"Hallo, mein Name ist {erstesObjekt.Vorname} {erstesObjekt.Nachname}.");
            //Hallo, mein Name ist Max Mustermann.

            //ein zweites Objekt der gleichen Klasse
            Person zweitesObjekt = new Person("Martina", "Mustermann");
            Console.WriteLine($"Hallo, mein Name ist {zweitesObjekt.Vorname} {zweitesObjekt.Nachname}.");
            //Hallo, mein Name ist Martina Mustermann.
        }
    }
}
