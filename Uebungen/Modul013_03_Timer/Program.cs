using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Modul013_03_Timer
{
    class Program
    {
        static int countdownNumber = 10;
        static Timer timer = new Timer(); 

        static void Main(string[] args)
        {
            //ueber die Eigenschaft Elapsed koennen Methoden an- und abgemeldet werden 
            //die Methoden werden ausgefuehrt, wenn die Zeit des Intervals abgelaufen ist
            timer.Elapsed += new ElapsedEventHandler(Countdown);

            //ueber die Eigenschaft Interval kann die Zeit in ms zweischen den Methodenaufrufen gesteuert werden
            timer.Interval = 500;

            //mit der Methode Start() kann der Timer gestartet werden
            timer.Start();

            Console.ReadLine();
        }

        static void Countdown(Object sender, ElapsedEventArgs args)
        {
            countdownNumber--;
            Console.WriteLine(countdownNumber);
            if (countdownNumber <= 0)
            {
                timer.Stop();
            }
        }
    }
}
