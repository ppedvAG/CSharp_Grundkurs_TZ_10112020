using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul011_Fragen
{
    class Program
    {
        static void Main(string[] args)
        {
            WerkstattA werkstattA = new WerkstattA() { Name = "Werkstatt Meier" };
            WerkstattB werkstattB = new WerkstattB() { Name = "Werkstatt Paulsen" };


            Oldtimer oldtimer = new Oldtimer() { Modell = "VW Kaefer" };
            Neuwagen neuwagen = new Neuwagen() { Modell = "Fiat 500" };
            
            Console.WriteLine(werkstattA.Name);
            Console.WriteLine("Kann mein Oldtimer repariert werden? " + werkstattA.BieteReparaturAn(oldtimer));
            Console.WriteLine("Was kostet die Reparatur? " + werkstattA.Reparatur(oldtimer));

            Console.WriteLine(werkstattB.Name);
            Console.WriteLine("Kann mein Oldtimer repariert werden? " + werkstattB.BieteReparaturAn(oldtimer));
            Console.WriteLine("Was kostet die Reparatur? " + werkstattB.Reparatur(oldtimer));

            Jahreswagen jahreswagen = new Jahreswagen() { Modell = "Hyundai Ioniq" };
            Console.WriteLine("Jahreswagen");
            Console.WriteLine("Kann mein Jahreswagen repariert werden? " + werkstattB.BieteReparaturAn(jahreswagen));
            Console.WriteLine("Was kostet die Reparatur? " + werkstattB.Reparatur(jahreswagen));

            Console.ReadLine();
        }
    }
}
