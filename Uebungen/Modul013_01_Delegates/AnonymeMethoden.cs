using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Modul013_01_Delegates
{
    public class AnonymeMethodenBeispiel
    {
        public static Func<int, int, string> MeineFunc;

        public static void Beispiel()
        {
            //ueber delegate(Parameterliste) kann direkt ein Delegate zugewieden werden
            //da sie keinen Namen hat nennt man sie anonyme Methode
            MeineFunc = delegate (int zahl1, int zahl2)
            {
                return $"Die Summe aus {zahl1} und {zahl2} ist {zahl1 + zahl2}";
            };

            Console.WriteLine("Aufruf der Func (anonyme Methoden)");
            //Aufruf der Func (anonyme Methoden)
            Console.WriteLine(MeineFunc(10, 20));
            //Die Summe aus 10 und 20 ist 30"

            //mit einem Lamda-Ausdruck kann der Quellcode nochmals verringert werden
            MeineFunc = (int zahl1, int zahl2) => $"Die Differenz aus {zahl1} und {zahl2} ist {zahl1 - zahl2}";

            Console.WriteLine();
            Console.WriteLine("Aufruf der Func (Lambda-Ausdruck)");
            //Aufruf der Func (Lambda-Ausdruck)
            Console.WriteLine(MeineFunc(10, 20));
            //Die Differenz aus 10 und 20 ist -10"
        }
    }
}
