using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul008_01_Vererbungen
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensch meinMensch = new Mensch(34, "Leipzig");
            
            //Das Objekt Mensch hat auch Zugriff auf die oeffentlichen Member der geerbten Klasse Lebewesen
            Console.WriteLine($"Ich bin {meinMensch.Alter} Jahre alt und wohne in {meinMensch.Wohnort}.");
            //Ich bin 34 Jahre alt und wohne in Leipzig.
        }
    }

    class Lebewesen
    {
        public int Alter { get; set; }
        public Lebewesen(int alter)
        {
            this.Alter = alter;
        }
    }

    class Mensch : Lebewesen
    {
        public string Wohnort { get; set; }

        public Mensch(int alter, string wohnort) : base(alter)
        {
            this.Wohnort = wohnort;
        }
    }
}
