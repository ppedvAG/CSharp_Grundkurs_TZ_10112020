using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul006_01_NamespaceKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            //ein Klassennamen muss in einem Namespace einmalig sein
            //Klassennamen koennen aber in unterschiedlichen Namespaces mehrfach vorkommen

            Console.WriteLine(ErsterNamespace.MeineKlasse.TestMethode());
            //Ich komme aus dem ersten Namespace!
            Console.WriteLine(ZweiterNamespace.MeineKlasse.TestMethode());
            //Ich komme aus dem zweiten Namespace!

            Console.ReadLine();


        }
    }
    //es koennen mehrere Klassen in einer Quelldatei definiert werden
    //eine Klasse besteht aus Feldern, Eigenschaften und Methoden
    class MeineKlasse
    {
        private int feld;

        public int Eigenschaft { get; set; }

        public void Methode()
        {
        }

        //ein Konstruktor
        public MeineKlasse()
        {
            feld = 0;
        }

        //ein Destruktor (Finalizer)
        ~MeineKlasse()
        {
        }
    }
}
