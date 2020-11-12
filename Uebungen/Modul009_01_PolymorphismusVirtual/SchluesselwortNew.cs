using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul009_01_PolymorphismusVirtual
{
    public class Fahrzeug
    {
        public virtual string WasBinIch()
        {
            return "Ich bin ein Fahrzeug";
        }
    }

    public class Auto : Fahrzeug
    {

        //durch Schluesselwort new eine neue Methode erzeugt
        //ueberschreibt die virtuelle Methode der Basisklasse nicht
        public new string WasBinIch()
        {
            return "Ich bin ein Auto";

        }
    }
}
