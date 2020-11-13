using System;

namespace Modul011_02_InterfaceCSharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //greift auf den statischen string des Interfaces zu
            Console.WriteLine(IFahrzeug.Test);
            //Ein String!

            //wirft einen Fehler aus, da sie nicht initialisiert wurde
            Auto meinAuto = new Auto("Beispielauto");
            //meinAuto.Info();

            //ruft die Standardinitialisierung des Interfaces auf
            IFahrzeug autoAlsFahrzeug = (IFahrzeug)meinAuto;
            autoAlsFahrzeug.Info(); 
            //Ich bin ein Beispielauto;
        }
    }

    interface IFahrzeug
    {
        //es koennen statische Member definiert werden
        public static string Test = "Ein String!";

        string Bezeichnung { get; set; }

        //Member koennen eine Standardimplementierung erhalten
        //sie sind nur ueber das Interface aufrufbar
        public string Info()
        {
            return "Ich bin ein " + Bezeichnung;
        }
    }

    class Auto : IFahrzeug
    {
        //es muessen nur die Member initialisiert werden, welche keine Standardinitialisierung haben
        public string Bezeichnung { get; set; }

        public Auto(string bezeichnung)
        {
            this.Bezeichnung = bezeichnung;
        }
    }
}
