using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul007_01_Objekte
{
    public class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public DateTime Geburtstag{ get; set; }

        //Konstruktor mit zwei Parametern
        public Person(string vorname, string nachname)
        {
            this.Vorname = vorname;
            this.Nachname = nachname;
        }

        //Konstruktor mit mehreren Parametern, der den ersten Konstruktor erweitert
        public Person(string vorname, string nachname, DateTime geburtstag) : this(vorname, nachname)
        {
            this.Geburtstag = geburtstag;
        }

        //Destruktor wird durch die GC aufgerufen
        ~Person()
        {
            Console.WriteLine("Destruktoraufruf: das Objekt wird nun zerstoert");
        }
    }
}
