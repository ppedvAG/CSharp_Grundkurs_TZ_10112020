using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul010_Fragen
{
    class Program
    {
        static void Main(string[] args)
        {
            Wuerfel wuerfel = new Wuerfel(15.4); 
            Console.WriteLine("Typpruefung uber GetType / typeof()");
            Console.WriteLine($"wuerfel.GetType() == typeof(Form)    : {wuerfel.GetType() == typeof(Form)}");
            Console.WriteLine($"wuerfel.GetType() == typeof(Wuerfel) : {wuerfel.GetType() == typeof(Wuerfel)}");
            Console.WriteLine($"wuerfel.GetType() == typeof(object)  : {wuerfel.GetType() == typeof(object)}");

            Console.WriteLine("Typpruefung uber is");
            Console.WriteLine($"wuerfel is Form    : {wuerfel is Form}");
            Console.WriteLine($"wuerfel is Wuerfel : {wuerfel is Wuerfel}");
            Console.WriteLine($"wuerfel is object  : {wuerfel is object}");
        }
    }
}
