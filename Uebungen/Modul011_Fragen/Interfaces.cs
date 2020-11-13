using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul011_Fragen
{
    public interface IAuto
    {
        string Modell { get; set; }
    }

    public interface IOldtimer : IAuto
    {

    }

    public interface INeuwagen : IAuto
    {

    }

    public interface IJahreswagen : IAuto
    {

    }

    public interface IWerkstatt
    {
        string Name { get; set; }
        decimal Reparatur(IAuto auto);
        bool BieteReparaturAn(IAuto auto);
    }
}
