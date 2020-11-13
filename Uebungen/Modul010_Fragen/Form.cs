using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul010_Fragen
{
    public abstract class Form
    {
        public abstract double Volumen();

        public virtual string Info()
        {
            return "";
        }
    }
}
