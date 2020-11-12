using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul008_Fragen
{
    public class Mitarbeiter : Person
    {
        public string Titel { get; set; }
        public decimal Gehalt { get; set; }

        public Mitarbeiter()
        {

        }

        public Mitarbeiter(string vorname, string nachname, DateTime geburtstag, string titel, decimal gehalt) : base(vorname, nachname, geburtstag)
        {
            this.Titel = titel;
            this.Gehalt = gehalt;
        }

        public string Arbeitsdetails()
        {
            return $"Ich arbeite als {Titel} und verdiene {Gehalt} Euro.";
        }

        public void GehaltErhoehen(decimal betrag)
        {
            this.Gehalt += betrag;
        }
    }
}
