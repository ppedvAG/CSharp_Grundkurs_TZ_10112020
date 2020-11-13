using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul010_Fragen
{
    public class Wuerfel : Form
    {
        double seite;

        public Wuerfel(double seite)
        {
            this.seite = seite;
        }
        public override string Info()
        {
            return $"Ich bin ein ein Wuerfel und habe ein Volumen von {Volumen()}!";
        }

        public override double Volumen()
        {
            return seite * seite * seite;
        }
    }
}
