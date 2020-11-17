using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Modul015_03_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Werte in der Liste");
            List<string> liste = new List<string> { "Wert1", "Wert2", "Wert3" };

            //fuer eine Serilisation mithilfe des XmlSerializer muss ein 
            XmlSerializer serializer = new XmlSerializer(typeof(List<string>));
            StreamWriter sw = new StreamWriter("liste.xml");
            
            foreach (string item in liste)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("XML Serialisierung mit XmlSerializer");
            //ueber ein Objekt der Klasse XmlSerializer kann mit der Methode Serialize ein Objekt in das XML-Format konvertiert werden
            //der Methode muss ein StreamWriter uebergeben werden, welche das XML dann in einer Datei speichert
            serializer.Serialize(sw, liste);
            //der Writer muss - wenn nicht in einem using-Block - immer geschlossen werden, wenn dieser nicht mehr benoetigt wird
            sw.Close();

            StreamReader sr = new StreamReader("liste.xml");
            Console.WriteLine();
            Console.WriteLine("Liste aus XML-Datei erstellen");
            //ueber ein Objekt der Klasse XmlSerializer kann mit der Methode Deserialize aus einer Datei im XML-Format ein Objekt erzeugt werden
            //das Objekt muss dann noch in den erwarteten Datentyp gecastet werden
            List<string> neueListeXml = (List<string>)serializer.Deserialize(sr);
            foreach (string item in neueListeXml)
            {
                Console.WriteLine(item);
            }
            //der Reader muss - wenn nicht in einem using-Block - immer geschlossen werden, wenn dieser nicht mehr benoetigt wird
            sr.Close();

            Console.ReadLine();
        }
    }
}
