using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opd002
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengte = Convert.ToInt16(InvoerFn("Geef een int voor de Lengte van een rechthoek"));
            int breedte = Convert.ToInt16(InvoerFn("Geef een int voor de Breedte van een rechthoek"));
            Console.WriteLine($"De oppervlakte van de rechthoek {lengte}x{breedte} bedraagt {Convert.ToDouble (lengte * breedte)}.\n"+
                $"De omtrek is {Convert.ToDouble (2 * lengte+2*breedte)}.");

        }



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
