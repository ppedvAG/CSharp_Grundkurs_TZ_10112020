using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul008_02_Zugriffsmodifizierer_ersteAssembly;

namespace Modul008_02_Zugriffsmodifizierer_zweiteAssembly
{
    public class ZugriffTestZweiteAssembly
    {
        public static void ZugriffTest()
        {
            ZugriffKlasse basisKlasse = new ZugriffKlasse();
            Console.WriteLine($"hat Zugriff auf basisKlasse.{basisKlasse.publicString}");

            Console.WriteLine($"hat keinen Zugriff auf basisKlasse.privateString");
            Console.WriteLine($"hat keinen Zugriff auf basisKlasse.protectedString");
            Console.WriteLine($"hat keinen Zugriff auf basisKlasse.internalString");
            Console.WriteLine($"hat keinen Zugriff auf basisKlasse.protectedInternalString");
            Console.WriteLine($"hat keinen Zugriff auf basisKlasse.privateProtectedString");
        }
    }
}
