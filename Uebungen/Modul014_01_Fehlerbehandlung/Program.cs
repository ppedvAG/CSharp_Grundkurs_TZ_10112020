using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul014_01_Fehlerbehandlung
{
    class Program
    {
        static void Main(string[] args)
        {
            //mit einem try-catch-Block koennen Fehler (Exceptions) abgefangen und behandelt werden
            //im try-Block wird der normale Anwenungscode geschrieben
            try
            {
                //ein direktes Konvertieren von string nach int kann zu einem Fehler fuehren
                //der string (Console.ReadLone()) muss eine zahl sein, sonst gibt es eine FormatException
                int eingabe = int.Parse(Console.ReadLine());
            }
            //mit catch(FormatException e) kann genau diese Exception abgefangen und behandelt werden
            catch (FormatException e)
            {
                //in diesem Fall geben wie einen Hinweis in der Konsole aus, dass die eingabe eine Zahl sein muss
                Console.WriteLine("Bitte geben Sie eine Zahl ein!");
            }
            //mit catch(Exception e) kann man alle Excaptions abfangen, welche nicht zuvor in einem anderen catch behandelt wurden
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //jede Exception hat die Eigenschaft "Message" wo eine Beschreibung des Fehlers zu finden ist
            }
            //der finally-Block (optional) wird nach jedem try-Block ausgefuehrt, auch wenn es zu einer Exception kam
            finally
            {
                Console.WriteLine("Danke!");
            }

            Console.ReadLine();
        }
    }
}
