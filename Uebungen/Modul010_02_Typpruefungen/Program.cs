using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul010_02_Typpruefungen
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetType() gibt eine Typen-Instanz des Objektes wieder
            MeineBasisKlasse basisKlasse = new MeineBasisKlasse();
            MeineAbgeleiteteKlasse abgeleiteteKlasse = new MeineAbgeleiteteKlasse();

            Type basisKlassenTyp = basisKlasse.GetType();

            //typeof() gibt eine Typen-Instanz einer angegebenen Klasse wieder
            Type abgeleiteteKlassenTyp = typeof(MeineAbgeleiteteKlasse);

            Console.WriteLine("Typpruefung mit GetType() und typeof()");
            //bei einem Vergleich ueber == muessen die Typen identisch schein
            Console.WriteLine($"basisKlasse.GetType()       == typeof(MeineBasisKlasse)       : {basisKlasse.GetType() == typeof(MeineBasisKlasse)}");
            //basisKlasse.GetType() == typeof(MeineBasisKlasse)     : True
            Console.WriteLine($"basisKlasse.GetType()       == typeof(MeineAbgeleiteteKlasse) : {basisKlasse.GetType() == typeof(MeineAbgeleiteteKlasse)}");
            //basisKlasse.GetType() == typeof(MeineAbgeleiteteKlasse)   : False
            Console.WriteLine($"abgeleiteteKlasse.GetType() == typeof(MeineBasisKlasse)       : {abgeleiteteKlasse.GetType() == typeof(MeineBasisKlasse)}");
            //abgeleiteteKlasse.GetType() == typeof(MeineBasisKlasse)   : False
            Console.WriteLine($"abgeleiteteKlasse.GetType() == typeof(MeineAbgeleiteteKlasse) : {abgeleiteteKlasse.GetType() == typeof(MeineAbgeleiteteKlasse)}");
            //abgeleiteteKlasse.GetType() == typeof(MeineAbgeleiteteKlasse) : True

            //mit dem Schluesselwort is kann geprueft werden ob ein Object eines Typen 

            Console.WriteLine();
            Console.WriteLine("Typpruefung mit Schluesselwort is");
            //bei einem Vergleich ueber == muessen die Typen identisch schein
            Console.WriteLine($"basisKlasse       is MeineBasisKlasse       : {basisKlasse is MeineBasisKlasse}");
            //basisKlasse is MeineBasisKlasse : True
            Console.WriteLine($"basisKlasse       is MeineAbgeleiteteKlasse : {basisKlasse is MeineAbgeleiteteKlasse}");
            //basisKlasse is MeineAbgeleiteteKlasse : False
            Console.WriteLine($"abgeleiteteKlasse is MeineBasisKlasse       : {abgeleiteteKlasse is MeineBasisKlasse}");
            //abgeleiteteKlasse is MeineBasisKlasse : True
            Console.WriteLine($"abgeleiteteKlasse is MeineAbgeleiteteKlasse : {abgeleiteteKlasse is MeineAbgeleiteteKlasse}");
            //abgeleiteteKlasse is MeineAbgeleiteteKlasse : True
            Console.WriteLine($"abgeleiteteKlasse is object                 : {abgeleiteteKlasse is object}");
            //abgeleiteteKlasse is object : True

            Console.ReadLine();
        }
    }

    class MeineBasisKlasse
    {

    }

    class MeineAbgeleiteteKlasse : MeineBasisKlasse
    {

    }
}
