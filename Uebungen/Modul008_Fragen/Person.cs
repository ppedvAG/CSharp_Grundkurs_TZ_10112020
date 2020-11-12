using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul008_Fragen
{
    public class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public DateTime Geburtstag { get; set; }

        public Person()
        {

        }

        public Person(string vorname, string nachname, DateTime geburtstag)
        {
            this.Vorname = vorname;
            this.Nachname = nachname;
            this.Geburtstag = geburtstag;
        }

        public string Vorstellung()
        {
            return $"Mein Name ist {Vorname} {Nachname} und ich habe am {Geburtstag.ToShortDateString()} Geburtstag.";
        }
    }
}
