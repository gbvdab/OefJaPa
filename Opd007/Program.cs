using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opd007
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een datumstring in volgens dit 'ddmmjjj' formaat:");
            DateTime datum = DateTime.ParseExact(Console.ReadLine(),"ddMMyyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None);
            int jaar = datum.Year + 1;
            DateTime nieuwJaar = new DateTime(jaar, 1, 1);
            string aantalDagen = Convert.ToString(nieuwJaar - datum);
            string[] resultaat = aantalDagen.Split(new char[] { '.' });
            Console.WriteLine($"Nog {resultaat[0]} dagen tot Nieuwjaar {jaar}!" );

        }
    }
}
