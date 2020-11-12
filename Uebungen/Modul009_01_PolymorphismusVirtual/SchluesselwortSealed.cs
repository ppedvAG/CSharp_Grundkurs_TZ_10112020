using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul009_01_PolymorphismusVirtual
{
    public class Lebewesen
    {
        //Methode "WasBinIch" wird initialisiert und kann auch so verwendet werden
        //durch "virtual" kann es in abgeleitetetn Klassen auch ueberschrieben werden
        public virtual string WasBinIch()
        {
            return "Ich bin ein Lebewesen";
        }
    }
    public class Mensch : Lebewesen
    {
        //durch Schluesselwort sealed vor weiterem Ueberschreiben durch abgeleitete Klassen geschuetzt
        public sealed override string WasBinIch()
        {
            //Zugriff auf Methode der Basisklasse ueber das Schluesselwort "base"
            return "Ich bin ein Mensch";
        }
    }
    public class Kind : Mensch
    {
        //Kann nicht ueberschrieben werden

        //public override string WasBinIch()
        //{
            
        //}
    }
}
