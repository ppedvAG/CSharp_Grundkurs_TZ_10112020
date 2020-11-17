using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modul014_02_UnitTest_Funktionen;

namespace Modul014_02_UnitTest_Test
{
    //mit dem Attribut [TestClass] wird VisualStudio gesagt, dass es sich um einen UnitTest handelt
    [TestClass]
    public class UnitTest1
    {
        //jede Methode die getestet werden soll bekommt eine eigene Methode mit dem Attribut [TestMethod]
        //der Name der Methode sollte Aufschluss ueber die Methode die getestet wird geben, kann aber frei gewaehlt werden
        [TestMethod]
        public void UnitTestKlasseVerdoppeln()
        {
            UnitTestKlasse unitTestKlasse = new UnitTestKlasse();
            int verdoppelt = unitTestKlasse.Verdoppeln(20);

            //ueber die Klasse Assert koennen unterschiedliche Methoden zum Vergleichen von Ist/Soll Werten ausgefuehrt werden
            //wenn eine Assert Methode fehlschlaegt, gilt der UnitTest als nicht bestanden
            Assert.AreEqual(40, verdoppelt); 
        }

        [TestMethod]
        public void UnitTestKlasseHalbieren()
        {
            UnitTestKlasse unitTestKlasse = new UnitTestKlasse();
            for (int i = 0; i < 100; i++)
            {
                int halbiert = unitTestKlasse.Halbieren(i);
                Assert.AreEqual(i / 2, halbiert);
            }
        }
    }
}
