using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul008_02_Zugriffsmodifizierer_ersteAssembly;

namespace Modul008_02_Zugriffsmodifizierer_zweiteAssembly
{
    public class GeerbteZugriffKlasseZweiteAssembly : ZugriffKlasse
    {
        public void GeerbteZugriffZweiteAssemblyTest()
        {
            Console.WriteLine($"hat Zugriff auf {publicString}");
            Console.WriteLine($"hat Zugriff auf {protectedString}");
            Console.WriteLine($"hat Zugriff auf {protectedInternalString}");

            Console.WriteLine("hat keinen Zugriff auf privateString");
            Console.WriteLine("hat keinen Zugriff auf internalString");
            Console.WriteLine("hat keinen Zugriff auf privateProtectedString");
        }
    }
}
