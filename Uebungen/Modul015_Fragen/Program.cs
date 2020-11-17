using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul015_Fragen
{
    class Program
    {
        static void Main(string[] args)
        {
            string pfad = "zahl.txt";
            Console.WriteLine("#####Datei schreiben#####");
            using (StreamWriter sw = new StreamWriter(pfad))
            {
                for (int i = 0; i < 100; i++)
                {
                    sw.WriteLine(i);
                }
            }
            Console.WriteLine("#####Datei fertig geschrieben#####");

            Console.WriteLine("#####Datei lesen#####");
            using (StreamReader sr = new StreamReader(pfad))
            {
                int summe = 0;
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    int lineZahl = 0;
                    int.TryParse(line, out lineZahl);

                    summe += lineZahl;

                    Console.WriteLine("Zeile: " + line);
                }
                Console.WriteLine("Summe:" + summe);
            }
            Console.ReadLine();
        }
    }
}
