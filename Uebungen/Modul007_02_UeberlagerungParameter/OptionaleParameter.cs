using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul007_02_UeberlagerungParameter
{
    public class OptionaleParameter
    {

        //optionale Parameter am Ende der Parameterliste
        //direkte Initialisieung innerhalb der Parameterliste
        public static string StringsVerbinden(string[] strings, char trenner = '/')
        { 
            string resultString = strings[0];
            for (int i = 1; i < strings.Length; i++)
            {
                resultString += (trenner + strings[i]);
            }
            return resultString;
        }
    }
}
