using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul006_Fragen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##erstes Auto##");
            Fahrzeug erstesFahrzeug = new Fahrzeug();
            Console.WriteLine($"Id      : {erstesFahrzeug.Id}");
            Console.WriteLine($"Marke   : {erstesFahrzeug.Marke}");
            Console.WriteLine($"Modell  : {erstesFahrzeug.Modell}");
            Console.WriteLine($"Baujahr : {erstesFahrzeug.Baujahr}");

            Console.WriteLine();
            Console.WriteLine("##zweites Auto##");
            Fahrzeug zweitesFahrzeug = new Fahrzeug(1, "Marke2020", "Model2020");
            Console.WriteLine($"Id      : {zweitesFahrzeug.Id}");
            Console.WriteLine($"Marke   : {zweitesFahrzeug.Marke}");
            Console.WriteLine($"Modell  : {zweitesFahrzeug.Modell}");
            Console.WriteLine($"Baujahr : {zweitesFahrzeug.Baujahr}");

            Console.ReadLine();
        }
    }
}
