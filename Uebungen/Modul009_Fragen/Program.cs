using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul009_Fragen
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form(5.4, 9.7);
            Kreis kreis = new Kreis(5);
            Zylinder zylinder = new Zylinder(6.9, 2.4);
            Kugel kugel = new Kugel(7);

            Form[] formen = new Form[] { form, kreis, zylinder, kugel };

            foreach (var item in formen)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
        }
    }
}
