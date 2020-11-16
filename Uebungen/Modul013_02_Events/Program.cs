using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modul013_02_Events
{
    class Program
    {
        //ein EventHandler wird mit dem Schluesselwort event deklariert
        //so koennen nur Methoden an- oder abgemeldet werden, der EventHandler aber nicht komplett neu initialisiert werden
        static event EventHandler OnNeueEingabe;
        static void Main(string[] args)
        {
            //ueber den "+="-Operator koennen Events bei dem EventHandler angemeldet werden
            //ueber den "-="-Operator koennen Events bei dem EventHandler abgemeldet werden
            OnNeueEingabe += Hallo;
            OnNeueEingabe += Tschuess;
            OnNeueEingabe += Hallo;

            //die erste gefundene Methode mit der Bezeichnung wird vom EventHandler abgemeldet
            OnNeueEingabe -= Hallo;

            string eingabe = "";
            while (eingabe != "ende")
            {
                eingabe = Console.ReadLine();

                //das Event wird gestartet und alle Methoden werden ausgefuehrt
                OnNeueEingabe(eingabe, EventArgs.Empty); 
            }
            Console.WriteLine("Anwendung wird geschlossen..");
            Console.ReadLine();
        }

        static void Hallo(object sender, EventArgs eventArgs)
        {
            //sender ist immer ein objekt und sollte erst auf den Datentyp den man erwartet ueberprueft werden
            if (sender is string)
            {
                if ((string)sender == "hallo")
                {
                    Console.WriteLine("Dir auch ein herzliches Hallo! :) ");
                }
            }
        }

        static void Tschuess(object sender, EventArgs eventArgs)
        {
            if (sender is string)
            {
                if ((string)sender == "tschuess")
                {
                    Console.WriteLine("Du willst schon gehen? Schade.. :( ");
                }
            }
        }
    }
}
