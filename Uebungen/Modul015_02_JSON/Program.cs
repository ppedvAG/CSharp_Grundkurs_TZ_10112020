using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Modul015_02_JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Werte in der Liste");
            List<string> liste = new List<string> { "Wert1", "Wert2", "Wert3" };
            foreach (string item in liste)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("JSON Serialisierung mit Newtonsoft.Json (NuGet-Package)");
            //ueber die Klasse JsonConvert mit der Methode SerializeObject kann ein Objekt in einen JSON-string konvertiert werden
            string newtonsoftJson = Newtonsoft.Json.JsonConvert.SerializeObject(liste);
            Console.WriteLine(newtonsoftJson);


            Console.WriteLine();
            Console.WriteLine("Liste aus JSON-string erstellt");
            //ueber die Klasse JsonConvert mit der Methode DeserializeObject kann aus einem JSON-string in ein neues Objekt des Typs T (hier List<string>) konvertiert werden
            List<string> neueListeNewtonsoft = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(newtonsoftJson);
            foreach (string item in neueListeNewtonsoft)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("JSON Serialisierung mit System.Text.Json (ab .NET Core 3.0)");
            //ueber die Klasse JsonSerializer mit der Methode Serialize kann ein Objekt in einen JSON-string konvertiert werden
            string dotNetJson = System.Text.Json.JsonSerializer.Serialize(liste);
            Console.WriteLine(dotNetJson);


            Console.WriteLine();
            Console.WriteLine("Liste aus JSON-string erstellt");
            //ueber die Klasse JsonSerializer mit der Methode Deserialize kann aus einem JSON-string in ein neues Objekt des Typs T (hier List<string>) konvertiert werden
            List<string> neueListeDotNet = System.Text.Json.JsonSerializer.Deserialize<List<string>>(dotNetJson);
            foreach (string item in neueListeDotNet)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine(); 
        }
    }
}
