using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul002_01_Datentypen
{
    class Program
    {
        static void Main(string[] args)
        {
            char textzeichen = 'A'; //mit Apostroph initialisieren

            string text = "Das ist ein String"; // mit Anfuehrungszeichen initialisieren

            bool boolean = true; //true oder false

            byte minByte = 0;
            byte maxByte = 255;

            short minShort = -32768; // -32.768
            short maxShort = 32767; // 32.767

            int minInt = -2147483648; //-2.147.483.648
            int maxInt = 2147483647; // 2.147.483.647

            long minLong = -9223372036854775808; // –9.223.372.036.854.775.808
            long maxLong = 9223372036854775807;// 9.223.372.036.854.775.807


            //float minFloat = +- 1.5 * 10^-45  
            //float minFloat = +- 3.4 * 10^38
            //Genauigkeit auf ~6-9 Stellen
            //Initialisierung mit dem Suffix "f" oder "F"
            //32-bit Gleitkommazahl

            //double minDouble = +- 5 * 10^-324
            //double minDouble =  +- 1.7 * 10^308
            //Genauigkeit auf ~15-17 Stellen
            //Initialisierung ohne Suffix oder mit dem Suffix "d" oder "D"
            //64-bit Gleitkommazahl (doppelte Genauigkeit zu float)


            //decimal minDecimal = +- 1 * 10^-28
            //decimal minDecimal = +- 7.9228 * 10^28
            //Genauigkeit auf 28-29 Stellen
            //Initialisierung mit dem Suffix "m" oder "M"

            //decimal hat zwar einen kleineren Wertebereich, jedoch eine hoehere Genauigkeit.
            //Eignet sich fuer Finanz- und Waehrungskalkulationen

            //Beispiel fuer Ungenauigkeit von Gleitkommazahlen
            double a = 69.82;
            double b = 69.2 + 0.62;
            Console.WriteLine(a == b); //false
            Console.WriteLine(a - b); //-1,4210854715202 x 10^-14

            //Die Abweichung ist sehr gering, aber vorhanden.

            decimal decimal1 = 69.82m;
            decimal decimal2 = 69.2m + 0.62m;
            Console.WriteLine(decimal1 == decimal2); //true
            Console.WriteLine(decimal1 - decimal2); //0

            Console.ReadLine();

        }
    }
}
