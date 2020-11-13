using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul010_01_PolymorphismusAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //es koennen keine Objekte von abstrakten Klassen erstellt werden
            //Fahrzeug fahrzeug = new Fahrzeug();

            Fahrrad fahrrad = new Fahrrad();
            Console.WriteLine($"Das Fahrrad ist fahrbereit: {fahrrad.IstFahrbereit}");

            Console.WriteLine(fahrrad.Info());
        }
    }
    //wenn ein Member abstract ist, muss die komplette Klasse als abstract gekennzeichnet werden
    public abstract class Fahrzeug
    {
        //abstrakte Member werden nur deklariert
        public abstract bool IstFahrbereit { get; }
        public abstract void FahrbereitMachen();
        //abstrakte Klassen koennen auch nicht-abstrakte Member haben
        public virtual string Info()
        {
            return "Ich bin ein Fahrzeug";
        }
    }

    public class Fahrrad : Fahrzeug
    {
        public int Luft { get; set; }

        public override bool IstFahrbereit
        {
            get { return Luft > 0; }
        }

        public override void FahrbereitMachen()
        {
            Luft = 100;
        }
    }
}
