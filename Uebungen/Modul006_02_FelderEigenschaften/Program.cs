using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Modul006_02_FelderEigenschaften
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonFelder person1 = new PersonFelder();
            person1.SetVorname("Max");
            Console.WriteLine($"Hallo, mein Name ist {person1.GetVorname()}");
            //Hallo, mein Name ist Max;
            Console.WriteLine(person1.GetFeldStandardwert());
            //Ich habe einen Standardwert!

            PersonEigenschaft person2 = new PersonEigenschaft();
            person2.Vorname = "Martina";
            Console.WriteLine($"Hallo, mein Name ist {person2.Vorname}");
            //Hallo, mein Name ist Martina;

            PersonAutoEigenschaft person3 = new PersonAutoEigenschaft();
            person3.Vorname = "Moritz";
            Console.WriteLine($"Hallo, mein Name ist {person3.Vorname}");
            //Hallo, mein Name ist Moritz;
            Console.WriteLine(person3.EigenschaftStandardwert);
            //Ich habe einen Standardwert!

            Console.ReadLine();
        }
    }
}
