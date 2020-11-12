using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul007_02_UeberlagerungParameter
{
    public class Ueberladung
    {
        //Methode "addieren" mit int als Rueckgabewert und zwei int als Parameter
        public static int Addieren(int a, int b)
        {
            int summe = a + b;
            return summe;
        }

        //Methode "addieren" mit int als Rueckgabewert und drei int als Parameter
        public static int Addieren(int a, int b, int c)
        {
            int summe = a + b + c;
            return summe;
        }

        //Methode "addieren" mit double als Rueckgabewert und zwei double als Parameter
        public static double Addieren(double a, double b)
        {
            double summe = a + b;
            return summe;
        }
    }
}
