using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul009_01_PolymorphismusVirtual
{

    public class Obst
    {
        public virtual string WasBinIch()
        {
            return "Ich bin ein Obst";
        }
    }

    public class Apfel : Obst
    {
        //durch Schluesselwort override kann die Methode der Basisklasse ueberschrieben werden
        //Zugriff auf Methode der Basisklasse ueber das Schluesselwort "base"
        public override string WasBinIch()
        {
            string wasBinIch = base.WasBinIch();
            wasBinIch += " und kann zu Apfelmus verarbeitet werden";
            return wasBinIch;

        }
    }
}
