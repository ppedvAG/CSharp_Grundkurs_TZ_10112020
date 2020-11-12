using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul009_Fragen
{
    public class Kugel : Form
    {
        public Kugel(double radius) : base(radius, 0)
        {

        }

        public override double Flaeche()
        {
            return 4 * Pi * x * x;
        }
    }
}
