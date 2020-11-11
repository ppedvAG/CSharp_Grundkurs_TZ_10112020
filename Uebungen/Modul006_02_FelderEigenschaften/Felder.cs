using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul006_02_FelderEigenschaften
{
    public class PersonFelder
    {
        //Felder sollte wenn moeglich private sein
        private string vorname;

        private string feldStandardwert = "Ich habe einen Standardwert!";

        //Zugriff ueber eine Set/Get-Methode
        public void SetVorname(string vorname)
        {
            this.vorname = vorname;
        }

        public string GetVorname()
        {
            return this.vorname;
        }

        public string GetFeldStandardwert()
        {
            return this.feldStandardwert;
        }
    }
}
