using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul006_03_partielleKlassenMethoden
{
    //eine partielle Klasse (Teilklasse)
    partial class MeinePartielleKlasse
    {
        //partielle Methode wird initialisiert
        static partial void MeinePartielleMethode()
        {
            Console.WriteLine("eine partielle Methode wurde aufgerufen!");
        }
    }
}
