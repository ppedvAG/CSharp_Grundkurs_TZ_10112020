using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul012_Fragen
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonCollection personCollection = new PersonCollection();
            personCollection.Einfuegen(new Person() { Vorname = "Max", Nachname = "Mustermann", Geburtstag = new DateTime(1998, 7, 15) });
            personCollection.Einfuegen(new Person() { Vorname = "Martina", Nachname = "Musterfrau", Geburtstag = new DateTime(1976, 5, 5) });
            personCollection.Einfuegen(new Person() { Vorname = "Tom", Nachname = "Tester", Geburtstag = new DateTime(1959, 1, 28) });

            int avgGeburtsjahr = personCollection.DurchschnittGeburtsjahr();

            Console.WriteLine($"Das durchschnittliche Geburtsjahr ist {avgGeburtsjahr}");

            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public DateTime Geburtstag { get; set; }

        public Person()
        {

        }
    }

    public class PersonCollection
    {
        List<Person> personenListe;

        public PersonCollection()
        {
            personenListe = new List<Person>();
        }

        public void Einfuegen(Person person)
        {
            personenListe.Add(person);
        }

        public int DurchschnittGeburtsjahr()
        {
            double avgTicks = personenListe.Select(x => x.Geburtstag.Ticks).Average();

            return new DateTime((long)avgTicks).Year;
        }
    }
}
