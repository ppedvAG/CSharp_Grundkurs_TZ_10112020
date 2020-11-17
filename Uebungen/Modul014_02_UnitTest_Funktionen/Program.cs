using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul014_02_UnitTest_Funktionen
{
    static class Program
    {
        static void Main(string[] args)
        {
            //um einen UnitTest zu starten gehen Sie in Visual Studio auf Test > Alle Test durchfuehren 
            //oder verwenden den Tastaturbefehl STRG+R,STRG+A

            //VisualStudio durchucht dann die komplette Projektmappe nach UnitTest und fuehrt diese aus
        }
    }

    public class UnitTestKlasse
    {
        //Methode die einen int verdoppel soll
        public int Verdoppeln(int zahl)
        {
            return zahl * 2;
        }

        //methode die einen int halbieren soll
        public int Halbieren(int zahl)
        {
            //um einen fehler zu provozieren wird jeder int der durch 13 teilbar ist durch 3 geteilt
            if (zahl % 13 == 0)
                return zahl / 3;

            return zahl / 2;
        }
    }
}
