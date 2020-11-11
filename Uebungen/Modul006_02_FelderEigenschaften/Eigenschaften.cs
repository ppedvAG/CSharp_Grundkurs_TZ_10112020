using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul006_02_FelderEigenschaften
{
    public class PersonEigenschaft
    {
        private string vorname;

        //kurze Version der Get/Set-Methode ueber die Schluesselwoerter "get;set;"
        public string Vorname
        {
            get
            {
                return vorname;
            }
            set
            {
                //Zuweisung ueber das Schluesselwort value
                vorname = value;
            }
        }
    }

    public class PersonAutoEigenschaft //Auto-Property
    {
        //wird im Hintergrund in Variante von PersonEigenschaft umgewandelt
        public string Vorname { get; set; }
        public string EigenschaftStandardwert { get; set; } = "Ich habe einen Standardwert!";
    }
}
