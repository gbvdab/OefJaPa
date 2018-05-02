using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opd004
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Kostprijsberekening schilderen van deuren");
            Console.WriteLine("=========================================");
            Console.WriteLine("Gebruikersnaam ?:");
            string sGebruiker=Console.ReadLine();
            Console.WriteLine("Aantal deuren ?:");
            int nDeuren = int.Parse(Console.ReadLine());
            Console.WriteLine("Afmeting van de deuren ?:");
            Console.WriteLine("Breedte deuren (cm)?:");
            Decimal nBreedte = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Hoogte deuren (cm)?:");
            Decimal nHoogte = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Aantal verflagen [1/2] ?:");
            int nLagen = int.Parse(Console.ReadLine());
            Console.WriteLine($"Deurtype [1=BASIC/2=MODERN] ?:");
            int nType = int.Parse(Console.ReadLine());
            Decimal nOppervlakte = nBreedte * nLagen;
            Decimal nPrijsD1L1 = 0.3m;
            Decimal nPrijsD1L2 = 0.5m;
            Decimal nPrijsD2L1 = 0.4m;
            Decimal nPrijsD2L2 = 0.7m;
            Decimal nTotaalPrijs;
            if (nLagen==1)
            {
                if (nType==1)
                {
                    nTotaalPrijs = nOppervlakte * nDeuren * nPrijsD1L1;
                } else
                {
                    nTotaalPrijs = nOppervlakte * nDeuren * nPrijsD2L1;
                }
            } else
            {
                if (nType == 1)
                {
                    nTotaalPrijs = nOppervlakte * nDeuren * nPrijsD1L2;
                }
                else
                {
                    nTotaalPrijs = nOppervlakte * nDeuren * nPrijsD2L2;
                }
            }
            Console.WriteLine($"Totale oppervlakte:\t{nOppervlakte} cm"+"\xB2");
            Console.WriteLine($"Totale kostprijs:\t{nTotaalPrijs} euro");



        }
    }
}
