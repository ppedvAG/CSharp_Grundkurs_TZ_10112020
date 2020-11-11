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

        //partielle Methode wird nur deklariert
        //kann keinen Rueckgabewert haben (void)
        //kann nur pivate sein (implizit => ohne Angabe des Zugriffsmodifizierers))
        static partial void MeinePartielleMethode();


        //nicht jede Methode muss partial sein
        public static void MeineMethode()
        {
            //Kann in Teilklasse aufgerufen werden ohne dass sie initialisiert ist
            MeinePartielleMethode(); 
        }
    }
}
