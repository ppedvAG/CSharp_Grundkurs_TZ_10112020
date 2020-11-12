using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul009_Fragen
{
    public class Kreis : Form
    {
        public Kreis(double radius) : base(radius, 0)
        {

        }

        public override double Flaeche()
        {
            return Pi * x * x;
        }
    }
}
