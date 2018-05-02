using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefJaPa
{
    class Program
    {
        static void Main(string[] args)
        {
            string sNaam, sVoornaam, sAdres, sPlaats, sPostcode;
            string[] arrUitvoer= new string[5];
            Console.WriteLine("Geef je familienaam, voornaam, postcode en gemeente in:");

            arrUitvoer[0] = sNaam = InvoerFn("Familienaam");
            arrUitvoer[1] = sVoornaam = InvoerFn("Voornaam");
            arrUitvoer[2] = sAdres = InvoerFn("Adres");
            arrUitvoer[3] = sPostcode = InvoerFn("Postcode");  // indien postcode int zou zijn: Convert.ToInt16(InvoerFn("Postcode"));
            arrUitvoer[4] = sPlaats = InvoerFn("Gemeente");
            // Invoer is ok
            for(int i=0;i< arrUitvoer.Length;i++)
                Console.WriteLine(arrUitvoer[i]);
                                 


            Console.WriteLine("Druk [ENTER] om te verlaten");
            Console.ReadLine();
        }
        // Functies
        private static string InvoerFn(string sTekst)

        {
            string invoer;
            Console.WriteLine(sTekst + ":");
            while (string.IsNullOrEmpty(invoer = Console.ReadLine()))
            {
                Console.WriteLine(sTekst + "??:");
            }
            return invoer;
        }
        
    }
}
