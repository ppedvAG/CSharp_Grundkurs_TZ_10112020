using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Modul015_01_Dateien_Verzeichnisse
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnErzeugen.IsEnabled = false;
            btnOeffnen.IsEnabled = false;
            btnEinlesen.IsEnabled = false;

            tbPfadOeffnen.IsEnabled = false;
            tbPfadSpeichern.IsEnabled = false;
        }

        private void btnSpeichern_Click(object sender, RoutedEventArgs e)
        {
            //benoetigt den Naespace System.Windows.Forms (muss ueber Verweis hinzugefuegt werden)
            SaveFileDialog sfd = new SaveFileDialog();

            //ueber die Methode ShowDialog kann der Dialog geoeffnet werden
            sfd.ShowDialog();

            //ueber die Eigenschaft FileName bekammt man den ausgefaehlten Pfad inkl. Dateiname 
            tbPfadSpeichern.Text = sfd.FileName;

            btnErzeugen.IsEnabled = true; 
        }

        private void btnErzeugen_Click(object sender, RoutedEventArgs e)
        {
            //mit einem StreamWriter können Dateien erzeug und Inhalt in diese geschrieben werden
            using (StreamWriter sw = new StreamWriter(tbPfadSpeichern.Text))
            {
                for (int i = 0; i < 100; i++)
                {
                    //mit der Methode WriteLine kann eine Zeile dem StreamWriter hinzugefuegt werden
                    sw.WriteLine($"Zeile {i}");
                }
            }
            //am Ende des usings wird die Methode Close des StreamWriters ausgefuehrt
            //erst durch diesen Aufruf wird die Datei tatsaechlich erstellt

            btnOeffnen.IsEnabled = true; 
        }

        private void btnOeffnen_Click(object sender, RoutedEventArgs e)
        {
            //benoetigt den Naespace System.Windows.Forms (muss ueber Verweis hinzugefuegt werden)
            OpenFileDialog ofd = new OpenFileDialog();

            //ueber die Eigenschaft Filter kann nach Dateiendungen gefilter werden
            ofd.Filter = "Textdatei|*.txt";

            //ueber die Eigenschaft FileName kann ein vorausgewaehlter Pfad angegeben werden
            ofd.FileName = tbPfadSpeichern.Text;

            ofd.ShowDialog();

            tbPfadOeffnen.Text = ofd.FileName;
            btnEinlesen.IsEnabled = true;
        }


        private void btnEinlesen_Click(object sender, RoutedEventArgs e)
        {
            tbInhalt.Text = "";
            using (StreamReader sr = new StreamReader(tbPfadOeffnen.Text))
            {
                //mit der Eigenschaft EndOfStream kann geprueft werden ob noch weiterer Inhalt im Stream vorhanden ist
                while (!sr.EndOfStream)
                {
                    //durch jeden Aufruf der Methode ReadLine wird eine neue Zeile der Datei gelesen
                    tbInhalt.Text += sr.ReadLine() + Environment.NewLine; 
                }
            }
        }

 
    }
}
