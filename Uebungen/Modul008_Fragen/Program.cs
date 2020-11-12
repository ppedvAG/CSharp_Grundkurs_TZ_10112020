using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul008_Fragen
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Max", "Mustermann", new DateTime(2000, 1, 15));
            Console.WriteLine(person1.Vorstellung());

            Mitarbeiter mitarbeiter1 = new Mitarbeiter("Martina", "Mustermann", new DateTime(1990, 5, 26), "Marketing Manager", 3250m);
            Console.WriteLine(mitarbeiter1.Vorstellung());
            Console.WriteLine(mitarbeiter1.Arbeitsdetails());
            mitarbeiter1.GehaltErhoehen(500m);
            Console.WriteLine(mitarbeiter1.Arbeitsdetails());

            Console.ReadLine();
        }
    }
}
