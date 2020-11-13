using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul011_01_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Auto meinAuto = new Auto();
            meinAuto.Losfahren();
            //Das Auto faehrt los! (implizierte Implementierung)


            //wenn eine explizite Implementierung vorhanden ist, wird diese bei einem gecasteten Objekt aufgerufen
            //
            IFahrzeug autoAlsFahrzeug = (IFahrzeug)meinAuto;
            autoAlsFahrzeug.Losfahren();
            //Das Fahrzeug (Auto) faehrt los! (explizite  Implementierung)

            Console.ReadLine();
        }
        interface IFahrzeug
        {
            //Eigenschaften und Methoden sind standardmaessig public
            //Eigenschaften werden nicht automatisch implementiert (auch wenn der Aufbau so aussieht)
            string Bezeichnung { get; set; }
            int Baujahr { get; set; }
            void Losfahren();
        }

        class Auto : IFahrzeug
        {
            //in der Klasse werden die Eigenschaften und Methoden implementiert
            public string Bezeichnung { get; set; }
            public int Baujahr { get; set; }

            //implizierte Implementierung
            //Member wird als public Implementiert
            public void Losfahren()
            {
                Console.WriteLine("Das Auto faehrt los! (implizierte Implementierung)");
            }

            //explizite  Implementierung
            //Member wird ohne public implementirt, ist es aber dennoch
            void IFahrzeug.Losfahren()
            {
                Console.WriteLine("Das Fahrzeug (Auto) faehrt los! (explizite  Implementierung)");
            }
        }
    }
}
