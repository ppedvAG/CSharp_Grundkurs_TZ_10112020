using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul004_02_Enumeratoren
{
    class Program
    {
        //Enumerator mit eigenen zugewiesenen Werten
        enum Wochentag { Mo = 1, Di = 2, Mi = 3, Do = 4, Fr = 5, Sa = 6, So = 7 }

        //Enumerator mit automatisch zugewiesenen Werten (beginnt bei 0)
        enum WochentagAutomatisch { Mo, Di, Mi, Do, Fr, Sa, So }

        //Enumerator als BitFlag
        [Flags]
        enum Fruechte
        {
            Keins = 0,
            Orange = 1,
            Kirsche = 2,
            Banane = 4,
            Apfel = 8,
            Pflaume = 16,
            Birne = 32
        }

        static void Main(string[] args)
        {
            //Enum in einer Variablen verwenden und initialisieren
            Wochentag tag = Wochentag.Fr;
            WochentagAutomatisch freitag = WochentagAutomatisch.Fr;

            //einen Enum in den zugewiesenen Zahlenwert konvertieren
            int wochentag = (int)tag; // 5
            int wochentagAuto = (int)freitag; //4, da die automatische Zuweisung bei 0 beginnt

            //einen Zahlenwert in den zugewiesenen Enum konvertieren
            Wochentag tag3 = (Wochentag)3; //Mi
            Wochentag tag8 = (Wochentag)8; //8, da dem Zahlenwert 8 kein Enumerationsmembers zugewiesen wurde

            //mehrere Enums (mit Flags) einer Variable zuweisen
            Fruechte fruchtkorb = Fruechte.Banane | Fruechte.Kirsche | Fruechte.Apfel | Fruechte.Pflaume;
            Fruechte lieblingsFruechte = Fruechte.Birne | Fruechte.Orange | Fruechte.Kirsche | Fruechte.Banane;

            //die Schnittmengen von zwei Auswahlmoeglichkeiten kombinieren 
            Console.WriteLine($"Im Fruchtkorb sind meine lieblings Fruechte {fruchtkorb & lieblingsFruechte}");
            //"Im Fruchtkorb sind meine lieblings Fruechte Kirsche, Banane"

            //auf einzelne Enumerationsmember pruefen
            bool istOrangeImFruchtkorb = (fruchtkorb & Fruechte.Orange) == Fruechte.Orange;
            Console.WriteLine($"Gibt es im Fruchtkorb Orangen: {istOrangeImFruchtkorb}");
            //"Gibt es im Fruchtkorb Orangen: False"

            //Enum ueber eine switch-Anweisung ueberpruefen lassen
            string hinweis;
            switch (tag)
            {
                case Wochentag.Mo:
                case Wochentag.Di:
                case Wochentag.Mi:
                case Wochentag.Do:
                case Wochentag.Fr:
                    hinweis = "Leider ist noch kein Wochenende..";
                    break;
                case Wochentag.Sa:
                case Wochentag.So:
                    hinweis = "Wuhu! Endlich Wochenende!";
                    break;
                default:
                    break;
            }
        }
    }
}
