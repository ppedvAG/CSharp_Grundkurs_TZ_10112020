using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul001_02_DemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Tell3FactsAboutYourself();

            #region WriteLine()
            Console.WriteLine("### WriteLine() ###");
            int alter = 25;
            string name = "Benedikt";
            Console.WriteLine("mein Text fuer die Konsole");
            Console.WriteLine(alter);
            Console.WriteLine(name);
            #endregion

            #region WriteLine(string, arg0, arg1)
            Console.WriteLine("### WriteLine(string, arg0, arg1) ###");
            Console.WriteLine("Ich heisse {0} und bin {1} Jahre alt.", name, alter);
            #endregion

            #region Write()
            Console.WriteLine("### Write() ###");
            Console.Write("Text fuer Write()");
            #endregion

            #region OutputEncoding
            Console.WriteLine("### OutputEncoding ###");
            Console.WriteLine("Eurozeichen: €");
            Console.WriteLine("Default OutputEncoding: {0}", Console.InputEncoding.EncodingName); // Westeuropaeisch (DOS)
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Eurozeichen: €");
            #endregion

            #region ReadLine()
            Console.WriteLine("### ReadLine() ###");
            Console.WriteLine("Wie teuer darf das Hotelzimmer sein?");
            Console.InputEncoding = Encoding.Unicode;
            string zimmerPreis = Console.ReadLine();
            Console.WriteLine("Sie haben eingegeben: {0}", zimmerPreis);
            #endregion ReadLine()

            #region ReadKey()
            Console.WriteLine("### ReadKey() ###");
            Console.ReadKey();
            #endregion

        }

        static void Tell3FactsAboutYourself()
        {
            Console.WriteLine("\n #1");
            Console.WriteLine("\n #2");
            Console.WriteLine("\n #3");
        }
    }
}
