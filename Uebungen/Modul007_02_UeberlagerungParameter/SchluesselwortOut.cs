using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul007_02_UeberlagerungParameter
{
    public class SchluesselwortOut
    {
        public static int Berechne(int zahl1, int zahl2, out int min, out int max, out int avg)
        {
            int summe = zahl1 + zahl2;

            if (zahl1 < zahl2)
            {
                min = zahl1;
                max = zahl2;
            }
            else
            {
                min = zahl2;
                max = zahl1;
            }
            avg = summe / 2;

            return summe;
        }
    }
}
