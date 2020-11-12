using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul009_Fragen
{
    public class Form
    {
        public double Pi = Math.PI;
        protected double x, y;

        public Form(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual double Flaeche()
        {
            return x * y;
        }

        public override string ToString()
        {
            return $"Ich bin ein/eine { this.GetType().Name } und habe die Flaeche {Flaeche()}";
        }
    }
}
