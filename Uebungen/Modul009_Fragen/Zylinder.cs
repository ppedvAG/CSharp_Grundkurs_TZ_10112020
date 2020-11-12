using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul009_Fragen
{
    public class Zylinder : Form
    {
        public Zylinder(double radius, double hoehe) : base(radius, hoehe)
        {

        }

        public override double Flaeche()
        {
            return (2 * (Pi * x * x)) + (2 * Pi * x * y);
        }
    }
}
