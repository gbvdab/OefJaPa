using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opd003
{
    class Program
    {
        static void Main(string[] args)
        {
            Appels appels = new Appels();
            Peren peren = new Peren();
            Aardappelen aardappelen = new Aardappelen();
            Aardbeien aardbeien = new Aardbeien();
            appels.Hoeveelheid = 2m;
            appels.Eenheid = "kg";
            appels.Prijs = 2.4m;
            aardappelen.Hoeveelheid = 5m;
            aardappelen.Eenheid = "kg";
            aardappelen.Prijs = 0.75m;
            peren.Hoeveelheid = 3.5m;
            peren.Eenheid = "kg";
            peren.Prijs = 1.8m;
            aardbeien.Hoeveelheid = 1m;
            aardbeien.Eenheid = "bakje";
            aardbeien.Prijs = 2.84m;

            Console.WriteLine(appels.ToString());
            Console.WriteLine(aardappelen.ToString());
            Console.WriteLine(peren.ToString());
            Console.WriteLine(aardbeien.ToString());
            Decimal Totaal = 0;
            Totaal += appels.Hoeveelheid * appels.Prijs;
            Totaal += aardappelen.Hoeveelheid * aardappelen.Prijs;
            Totaal += peren.Hoeveelheid * peren.Prijs;
            Totaal += aardbeien.Hoeveelheid * aardbeien.Prijs;
            Console.WriteLine($"\nJantje heeft in totaal {String.Format("{0:#,0.000}", Totaal)} euro betaald!\n\n");



        }

        public class Goederen
        {

            public Decimal Hoeveelheid { get; set; }
            public String Eenheid { get; set; }
            public Decimal Prijs { get; set; }
            public override string ToString()
            {
                return $"\nGekochte goederen: {this.GetType().Name}:\nHoeveelheid:\t{this.Hoeveelheid} {this.Eenheid}\nKost:\t\t{this.Prijs} euro per {this.Eenheid}\nTotaal:\t\t{String.Format("{0:#,0.000}", (this.Hoeveelheid*this.Prijs))} euro.";
            }

        }

        public class Appels:Goederen
        { }
        public class Peren:Goederen
        { }
        public class Aardappelen:Goederen
        { }
        public class Aardbeien:Goederen
        { }
    }
}
