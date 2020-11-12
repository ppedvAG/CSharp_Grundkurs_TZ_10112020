using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul007_Fragen
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

        public int MaximaleGeschwindigkeit { get; private set; }

        private int aktuelleGeschwindigkeit;
        public int AktuelleGeschwindigkeit { 
            get
            {
                return aktuelleGeschwindigkeit;
            }
            set
            {
                if (value > MaximaleGeschwindigkeit)
                    aktuelleGeschwindigkeit = MaximaleGeschwindigkeit;
                else if (value < 0)
                    aktuelleGeschwindigkeit = 0;
                else
                    aktuelleGeschwindigkeit = value;


            }
        }
        public bool MotorLaeuft { get; set; }

        public Fahrzeug()
        {
            this.Baujahr = DateTime.Now;
            this.AktuelleGeschwindigkeit = 0;
            this.MotorLaeuft = false;
            this.MaximaleGeschwindigkeit = 120;
        }

        public Fahrzeug(int id, string marke, string modell) : this()
        {
            this.Id = id;
            this.Marke = marke;
            this.Modell = modell;
        }

        public void StarteMotor()
        {
            this.MotorLaeuft = true;
        }

        public void StoppeMotor()
        {
            this.MotorLaeuft = false;
        }

        public void Beschleunigen(int wert)
        {
            if (MotorLaeuft)
            {
                this.AktuelleGeschwindigkeit += wert;
                Console.WriteLine($"Geschwindigkeit erhoeht auf {AktuelleGeschwindigkeit}");
            }
            else
            {
                Console.WriteLine("Der Motor ist noch aus!");
            }
        }

        public static double KmhZuMph(double kmh)
        {
            return 0.6214 * kmh;
        }
    }
}
