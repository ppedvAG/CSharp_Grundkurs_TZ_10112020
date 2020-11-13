using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul011_Fragen
{
    public class Oldtimer : IOldtimer
    {
        public string Modell { get; set; }
    }

    public class Neuwagen : INeuwagen
    {
        public string Modell { get; set; }
    }

    public class Jahreswagen : IJahreswagen
    {
        public string Modell { get; set; }
    }
}
