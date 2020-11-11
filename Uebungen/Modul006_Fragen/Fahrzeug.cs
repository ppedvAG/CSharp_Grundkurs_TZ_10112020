using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul006_Fragen
{
    class Fahrzeug
    {
        private int id = 0;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        private string marke = "keine Angabe";
        public string Marke
        {
            get
            {
                return marke;
            }
            set
            {
                marke = value;
            }
        }

        private string modell = "keine Angabe";
        public string Modell
        {
            get
            {
                return modell;
            }
            set
            {
                modell = value;
            }
        }

        private DateTime baujahr;
        public DateTime Baujahr
        {
            get
            {
                return baujahr;
            }
            set
            {
                baujahr = value;
            }
        }
        public Fahrzeug()
        {
            this.Baujahr = DateTime.Now;
        }

        public Fahrzeug(int id, string marke, string modell) : this()
        {
            this.Id = id;
            this.Marke = marke;
            this.Modell = modell;
        }
    }
}
