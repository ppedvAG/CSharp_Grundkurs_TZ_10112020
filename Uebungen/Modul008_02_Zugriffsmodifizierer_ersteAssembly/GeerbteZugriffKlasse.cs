using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul008_02_Zugriffsmodifizierer_ersteAssembly
{
    public class GeerbteZugriffKlasse : ZugriffKlasse
    {
        public void GeerbteZugriffTest()
        {
            Console.WriteLine($"hat Zugriff auf {publicString}");
            Console.WriteLine($"hat Zugriff auf {protectedString}");
            Console.WriteLine($"hat Zugriff auf {internalString}");
            Console.WriteLine($"hat Zugriff auf {protectedInternalString}");
            Console.WriteLine($"hat Zugriff auf {privateProtectedString}");

            Console.WriteLine("hat keinen Zugriff auf privateString");
        }
    }
}
