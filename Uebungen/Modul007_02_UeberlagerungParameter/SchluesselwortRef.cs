using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul007_02_UeberlagerungParameter
{
    public class SchluesselwortRef
    {
        public static int Addiere(int zahl1, int zahl2, ref int anzahlAdditionen)
        {
            int summe = zahl1 + zahl2;
            anzahlAdditionen += 1;

            return summe;
        }
    }
}
