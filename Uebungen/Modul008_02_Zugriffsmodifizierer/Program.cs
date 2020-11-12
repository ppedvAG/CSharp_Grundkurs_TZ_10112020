using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul008_02_Zugriffsmodifizierer_ersteAssembly;
using Modul008_02_Zugriffsmodifizierer_zweiteAssembly;

namespace Modul008_02_Zugriffsmodifizierer
{
    class Program
    {
        static void Main(string[] args)
        {
            //public => ueberall
            //private => innerhalb der selben Klasse
            //protected => innerhalb der selben Klasse oder innerhalb abgeleiteter Klassen
            //internal => innerhalb der aktuellen Assembly
            //protected internal => innerhalb der aktuellen Assembly oder abgeleitet in anderer Assembly
            //private protected => innerhalb der selben Klasse oder innerhalb einer abgeleiteten Klasse in der aktuellen Assembly

            Console.WriteLine("Zugriff innerhalb der Basisklasse:");
            ZugriffKlasse basisKlasse = new ZugriffKlasse();
            basisKlasse.ZugriffTest();
            //hat Zugriff auf publicString
            //hat Zugriff auf privaterString
            //hat Zugriff auf protectedString
            //hat Zugriff auf internalString
            //hat Zugriff auf protectedInternalString
            //hat Zugriff auf privateProtectedString

            Console.WriteLine();
            Console.WriteLine("Zugriff innenhalb einer abgeleiteten Klasse:");
            GeerbteZugriffKlasse geerbteKlasse = new GeerbteZugriffKlasse();
            geerbteKlasse.GeerbteZugriffTest();
            //hat Zugriff auf publicString
            //hat Zugriff auf protectedString
            //hat Zugriff auf internalString
            //hat Zugriff auf protectedInternalString
            //hat Zugriff auf privateProtectedString
            //hat keinen Zugriff auf privateString

            Console.WriteLine();
            Console.WriteLine("Zugriff innenhalb einer abgeleiteten Klasse in einer anderern Assembly:");
            GeerbteZugriffKlasseZweiteAssembly geerbteKlasseZweiteAssembly = new GeerbteZugriffKlasseZweiteAssembly();
            geerbteKlasseZweiteAssembly.GeerbteZugriffZweiteAssemblyTest();
            //hat Zugriff auf publicString
            //hat Zugriff auf protectedString
            //hat Zugriff auf protectedInternalString
            //hat keinen Zugriff auf privateString
            //hat keinen Zugriff auf internalString
            //hat keinen Zugriff auf privateProtectedString

            Console.WriteLine();
            Console.WriteLine("Zugriff durch Objekt innerhalb der gleichen Assembly:");
            ZugriffTestGleicheAssembly.ZugriffTest();
            //hat Zugriff auf basisKlasse.publicString
            //hat Zugriff auf basisKlasse.internalString
            //hat Zugriff auf basisKlasse.protectedInternalString
            //hat keinen Zugriff auf basisKlasse.privateString
            //hat keinen Zugriff auf basisKlasse.protectedString
            //hat keinen Zugriff auf basisKlasse.privateProtectedString

            Console.WriteLine();
            Console.WriteLine("Zugriff durch Objekt innerhalb einer anderen Assembly:");
            ZugriffTestZweiteAssembly.ZugriffTest();
            //hat Zugriff auf basisKlasse.publicString
            //hat keinen Zugriff auf basisKlasse.privateString
            //hat keinen Zugriff auf basisKlasse.protectedString
            //hat keinen Zugriff auf basisKlasse.internalString
            //hat keinen Zugriff auf basisKlasse.protectedInternalString
            //hat keinen Zugriff auf basisKlasse.privateProtectedString

            Console.ReadLine();
        }
    }

}
