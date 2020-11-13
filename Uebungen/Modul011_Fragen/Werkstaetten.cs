using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul011_Fragen
{
    public class WerkstattA : IWerkstatt
    {
        public string Name { get; set; }

        public bool BieteReparaturAn(IAuto auto)
        {
            if (auto is IOldtimer)
                return false;

            return true;
        }

        public decimal Reparatur(IAuto auto)
        {
            if (BieteReparaturAn(auto))
                return 559.95m;

            return 0;
        }
    }

    public class WerkstattB : IWerkstatt
    {
        public string Name { get; set; }

        public bool BieteReparaturAn(IAuto auto)
        {
            return (auto is IOldtimer || auto is INeuwagen);
        }

        public decimal Reparatur(IAuto auto)
        {
            if (BieteReparaturAn(auto))
            {
                if (auto is IOldtimer)
                    return 1529.45m;
                else if (auto is INeuwagen)
                    return 989.95m;
            }
            return 0;
        }
    }
}
