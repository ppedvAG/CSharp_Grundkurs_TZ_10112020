using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul007_Fragen
{
    class Program
    {
        static void Main(string[] args)
        {
            Fahrzeug unserFahrzeug = new Fahrzeug();
            Console.WriteLine($"Motor ist an: {unserFahrzeug.MotorLaeuft}");

            unserFahrzeug.StarteMotor();
            Console.WriteLine($"Motor ist an: {unserFahrzeug.MotorLaeuft}");

            for (int i = 0; i < 10; i++)
            {
                unserFahrzeug.Beschleunigen(i * 3);
            }

            Console.ReadLine();
        }
    }
}
