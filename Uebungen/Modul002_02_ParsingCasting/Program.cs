using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul002_02_ParsingCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl1 = 25;
            //implizierte Konvertierung in einen String durch den "+" Operator
            string satz1 = "Wert der Zahl: " + zahl1;
            //explizierte Konvertierung durch die Methode ".ToString()"
            string satz2 = "Wert der Zahl: " + zahl1.ToString();


            //Parsen von string in einen numerischen Datentyp
            string zahlenwort1 = "123";
            int zahl2 = Int32.Parse(zahlenwort1); //Parsen ueber den .NET-Typ System.Int32
            int zahl3 = int.Parse(zahlenwort1); //Parsen eber das Schluesselwort "int" (.NET-Typ System.Int32)

            string zahlenwort2 = "123.456";
            float zahl5 = Single.Parse(zahlenwort2); //Parsen ueber den .NET-Typ System.Single
            float zahl6 = float.Parse(zahlenwort2); //Parsen ueber das Schluesselwort float (.NET-Typ System.Single)

            ///Schluesselwort   .NET-Typ        Beschreibung
            ///sbyte            System.SByte    8-Bit-Zahl mit Vorzeichen
            ///byte             System.Byte     8-Bit-Zahl ohne Vorzeichen
            ///short            System.Int16    16-Bit-Zahl mit Vorzeichen
            ///ushort           System.Int16    16-Bit-Zahl ohne Vorzeichen
            ///int              System.Int32    32-Bit-Zahl mit Vorzeichen
            ///uint             System.Int32    32-Bit-Zahl ohne Vorzeichen
            ///long             System.Int64    64-Bit-Zahl mit Vorzeichen
            ///ulong            System.Int64    64-Bit-Zahl ohne Vorzeichen

            ///float            System.Single   32-Bit-Zahl (~6-9 Stellen Genauigkeit)
            ///double           System.Double   64-Bit-Zahl (~15-17 Stellen Genauigkeit)
            ///decimal          System.Decimal  128-Bit-Zahl (28-29 Stellen Genauigkeit)

            //Casten von numerischen Datentypen in einen anderen numerischen Datentyp
        }
    }
}
