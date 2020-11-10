using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul003_02_Kontrollstrukturen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib den Akkustand ein:");
            int akkuStand = int.Parse(Console.ReadLine());
            string akkuStatus;
            if (akkuStand > 20 && akkuStand <= 100) //wenn Bedingung wahr sind
            {
                akkuStatus = "Akku ist in Ordnung";
            }
            else if (akkuStand > 10 && akkuStand <= 20) //wenn vorherige Bedigung falsch ist und eigene Bedingung wahr ist
            {
                akkuStatus = "Akku sollte geladen werden.";
            }
            else if (akkuStand < 10) //wenn vorherige Bedigung falsch ist und eigene Bedingung wahr ist
            {
                akkuStatus = "Akku muss dringend geladen werden!";
            }
            else if (akkuStand == 0) //wenn vorherige Bedigung falsch ist und eigene Bedingung wahr ist
            {
                akkuStatus = "Akku ist leer";
            }
            else //wenn keine Bedingung zugetroffen hat
            {
                akkuStatus = "Der Akku ist defekt!";
            }

            Console.WriteLine($"Akkustand: {akkuStand} - Status: {akkuStatus}");
            Console.ReadLine();

            Console.WriteLine("Gib einen Wochentag ein:");
            int wochentag = int.Parse(Console.ReadLine());
            string tag;
            switch (wochentag)
            {
                case 1: //wenn wochentag == 1
                    tag = "Montag";
                    break;
                case 2: //wenn wochentag == 2
                    tag = "Dienstag";
                    break;
                case 3: //usw.
                    tag = "Mittwoch";
                    break;
                case 4:
                    tag = "Donnerstag";
                    break;
                case 5:
                    tag = "Freitag";
                    break;
                case 6:
                    tag = "Samstag";
                    break;
                case 7:
                    tag = "Sontag";
                    break;
                default:
                    tag = "kein Wochentag";
                    break;
            }

            Console.WriteLine($"Wochentag: {wochentag} - Tag: {tag}");
            Console.ReadLine();

            Console.WriteLine("Gib ein Obst ein:");
            string obst = Console.ReadLine();
            string farbe;
            switch (obst)
            {
                case "Kirsche":
                    farbe = "rot";
                    break;
                case "Banane": //wenn obst == "Banane" die kommende Anweisung ausfuehren
                case "Zitrone":
                    farbe = "gelb"; //Anweisung ist fuer "Banane" und "Zitrone" gleich
                    break;
                case "Orange":
                    farbe = "orange";
                    break;
                default:
                    farbe = "unbekannt";
                    break;
            }

            Console.WriteLine($"Obst: {obst} - Farbe {farbe}");
            Console.ReadLine();
        }
    }
}
