using System;

namespace Opd801
{
    class Program
    {
        static void Main(string[] args)
        {
            Kledingstuk hemd = new Kledingstuk { Naam = "hemd", WasGraden = 40 };
            Kledingstuk rok = new Kledingstuk { Naam = "rok", WasGraden = 30 };
            Console.WriteLine(hemd.ToString());
            Console.WriteLine(rok.ToString());

        }
    }
}
