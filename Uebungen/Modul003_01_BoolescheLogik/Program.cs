using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul003_01_BoolescheLogik
{
    class Program
    {
        static void Main(string[] args)
        {
            bool booleanWahr = true;
            bool booleanFalsch = false;

            int kleineZahl = 3;
            int kleineZahl2 = 3;
            int grosseZahl = 5;

            string ersterString = "Inhalt des Strings";
            string zweiterString = "Inhalt des Strings";

            //Gleichheitsoperatoren (gleich, ungleich)
            bool ergebnis1 = booleanWahr == booleanFalsch; //false
            bool ergebnis2 = booleanWahr != booleanFalsch; //true
            
            bool ergebnis3 = kleineZahl == grosseZahl; //false
            bool ergebnis4 = kleineZahl != grosseZahl; //true

            bool ergebnis5 = ersterString == zweiterString; //true
            bool ergebnis6 = ersterString != zweiterString; //false

            //Vergleichsoperatoren (kleiner, groesser, kleiner-gleich, groesser-gleich)
            bool ergebnis7 = kleineZahl < grosseZahl; //true
            bool ergebnis8 = kleineZahl > grosseZahl; //false

            bool ergebnis9 = kleineZahl <= grosseZahl; //true
            bool ergebnis10 = kleineZahl <= kleineZahl2; //true

            bool ergebnis11 = kleineZahl >= grosseZahl; //false
            bool ergebnis12 = kleineZahl >= kleineZahl2; //true

            //bedingte logische Operatoren (und, oder)
            bool ergebnis13 = booleanWahr && booleanFalsch; //false
            bool ergebnis14 = booleanWahr || booleanFalsch; //true

            //logische Operatoren (und, oder, exklusiv oder)
            bool ergebnis15 = booleanWahr & booleanFalsch; //false
            bool ergebnis16 = booleanWahr | booleanFalsch; //true
            bool ergebnis17 = booleanWahr ^ booleanFalsch; //true
            bool ergebnis18 = booleanWahr ^ booleanWahr; //false
            bool ergebnis19 = booleanFalsch ^ booleanFalsch; //false
            
            //Negationsoperator (nicht)
            bool ergebnis20 = !booleanWahr;
            bool ergebnis21 = !booleanFalsch;

            Console.ReadLine();
        }
    }
}
