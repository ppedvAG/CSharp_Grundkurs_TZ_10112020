using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul004_01_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //Deklarieren und initialisieren von Arrays
            int[] zahlen = new int[5]; //eine int-Array mit einer Laenge von 5
            string[] woerter = new string[] { "ppedv", "CSharp", "Grundkurs" }; //eine string-Array mit einer Laenge von drei
            double[] gleitkommzahlen = new double[] { 6.29, 1.58, 4.97, 2.67, 45.8, 3.57 };

            //Werte ueber den Index zuweisen
            zahlen[0] = 1; //der Index ist null-basierte und faengt somit immer bei 0 an
            zahlen[4] = 5; //der Index 4 ist der hoechste Index dieser Array (0,1,2,3,4 => 5 Elemente)

            //auf Werte ueber den Index zugreifen
            string wort1 = woerter[0]; // wort1 => "ppedv"


            //Funktionen und Eigenschaften von Arrays
            int laenge = zahlen.Length; // 5
            bool enthaelt = woerter.Contains("CSharp"); //true; 

            double kleinsteZahl = gleitkommzahlen.Min(); // 1.58
            double groessteZahl = gleitkommzahlen.Max(); // 45.8

            int ersteZahl = zahlen.First(); // 1
            int letzeZahl = zahlen.Last(); // 5

            double summe = gleitkommzahlen.Sum(); //64.88


            //-------------------------------------------------------------

            //Deklaration einer mehrdimensionalen Array
            int[,] zweiDimensionen;

            //zweidimensionale Array mit zwei Zeilen und fuenf Spalten initialisieren
            zweiDimensionen = new int[,] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 } };

            //zweidimensionale Array mit vier Zeilen und drei Spalten
            zweiDimensionen = new int[4, 3];

            //Zugriff ueber den Index
            int wert = zweiDimensionen[1, 2];

            //Zuweisung ueber den Index
            zweiDimensionen[2, 1] = 5;

            int[,,] array3D = new int[2, 3, 2] { { { 1, 2 }, { 3, 4 }, { 5, 6 } }, { { 7, 8 }, { 9, 10 }, { 11, 12 } } };

            //Anzahl der Dimensionen
            int dimensionen = array3D.Rank;//3

            //Anzahl aller Elemente
            int laenge3D = array3D.Length;//12

            //Laenge der einzelnen Dimensionen
            int laenge1 = array3D.GetLength(0);//2
            int laenge2 = array3D.GetLength(1);//3
            int laenge3 = array3D.GetLength(2);//2

            //-------------------------------------------------------------

            //Initialisierung durch setzen der Laenge
            int[][] verzweigteArray = new int[4][];

            //Initialisierung durch direkte Zuweisung der Elemente
            verzweigteArray = new int[][] { new int[] { 1, 2, 3 }, new int[] { 1, 2 } };

            //Zugriff ueber Index
            int jaggedWert = verzweigteArray[0][2];// 3

            //Zuweisung ueber Index
            verzweigteArray[1][1] = 5;

            Console.ReadLine(); 
        }
    }
}
