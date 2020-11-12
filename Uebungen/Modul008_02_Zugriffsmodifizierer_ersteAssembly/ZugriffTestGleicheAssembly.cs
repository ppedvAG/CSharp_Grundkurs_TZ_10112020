using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul008_02_Zugriffsmodifizierer_ersteAssembly
{
    public class ZugriffTestGleicheAssembly
    {
        public static void ZugriffTest()
        {
            ZugriffKlasse basisKlasse = new ZugriffKlasse(); 
            Console.WriteLine($"hat Zugriff auf basisKlasse.{basisKlasse.publicString}");
            Console.WriteLine($"hat Zugriff auf basisKlasse.{basisKlasse.internalString}");
            Console.WriteLine($"hat Zugriff auf basisKlasse.{basisKlasse.protectedInternalString}");

            Console.WriteLine($"hat keinen Zugriff auf basisKlasse.privateString");
            Console.WriteLine($"hat keinen Zugriff auf basisKlasse.protectedString");
            Console.WriteLine($"hat keinen Zugriff auf basisKlasse.privateProtectedString");
        }
    }
}
