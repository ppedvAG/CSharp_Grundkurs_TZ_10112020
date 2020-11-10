using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul002_Fragen
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance;
            float hour, min, sec;

            float timeSec;
            float mps;
            float kph, mph;

            Console.Write("Input distance(meters):");
            distance = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(hour):");
            hour = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(minutes):");
            min = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(seconds):");
            sec = Convert.ToSingle(Console.ReadLine());

            timeSec = (hour * 3600) + (min * 60) + sec;
            mps = distance / timeSec;
            kph = (distance / 1000.0f) / (timeSec / 3600.0f);
            mph = kph / 1.609f;

            Console.WriteLine($"Your speed in meters/sec is: {mps}");
            Console.WriteLine($"Your speed in km/h is: {kph}");
            Console.WriteLine($"Your speed in miles/h is: {mph}");
            
            Console.ReadLine();
        }
    }
}
