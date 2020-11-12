using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul008_02_Zugriffsmodifizierer_ersteAssembly
{
    public class ZugriffKlasse
    {
        public string publicString = "publicString";
        private string privateString = "privaterString";
        protected string protectedString = "protectedString";
        internal string internalString = "internalString";
        protected internal string protectedInternalString = "protectedInternalString";
        private protected string privateProtectedString = "privateProtectedString";

        public void ZugriffTest()
        {
            Console.WriteLine($"hat Zugriff auf {publicString}");
            Console.WriteLine($"hat Zugriff auf {privateString}");
            Console.WriteLine($"hat Zugriff auf {protectedString}");
            Console.WriteLine($"hat Zugriff auf {internalString}");
            Console.WriteLine($"hat Zugriff auf {protectedInternalString}");
            Console.WriteLine($"hat Zugriff auf {privateProtectedString}");
        }
    }
}
