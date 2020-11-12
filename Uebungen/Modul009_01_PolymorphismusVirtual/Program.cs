using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul009_01_PolymorphismusVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schluesselwort override");
            Obst obst = new Obst();
            Console.WriteLine(obst.WasBinIch());
            //Ich bin ein Obst

            Apfel apfel = new Apfel();
            Console.WriteLine(apfel.WasBinIch());
            //Ich bin ein Obst und kann zu Apfelmus verarbeitet werden

            //der Zugriff erfolgt immer auf die Methode der Laufzeit-Instanz 
            //wenn dies eine uberschriebene Methode des gecasteten Typs ist
            Obst apfelAlsObst = (Obst)apfel;
            Console.WriteLine(apfelAlsObst.WasBinIch());
            //Ich bin ein Obst und kann zu Apfelmus verarbeitet werden

            Console.WriteLine();
            Console.WriteLine("Schluesselwort new");

            Fahrzeug fahrzeug = new Fahrzeug();
            Console.WriteLine(fahrzeug.WasBinIch());
            //Ich bin ein Fahrzeug

            Auto auto = new Auto();
            Console.WriteLine(auto.WasBinIch());
            //Ich bin ein Auto

            //da Auto.WasBinIch eine neue (new) Methode ist
            //kann Fahrzeug nicht auf diese Zugreifen und benutzt somit die Methode der Basisklasse
            Fahrzeug autoAlsFahrzeug = (Fahrzeug)auto;
            Console.WriteLine(autoAlsFahrzeug.WasBinIch());
            //Ich bin ein Fahrzeug

            Console.WriteLine();
            Console.WriteLine("Schluesselwort sealed");
            Lebewesen lebewesen = new Lebewesen();
            Console.WriteLine(lebewesen.WasBinIch());
            //Ich bin ein Lebewesen

            Mensch mensch = new Mensch();
            Console.WriteLine(mensch.WasBinIch());
            //Ich bin ein Mensch

            Kind kind = new Kind();
            Console.WriteLine(kind.WasBinIch());
            //Ich bin ein Mensch


            Console.ReadLine();
        }
    }
}
