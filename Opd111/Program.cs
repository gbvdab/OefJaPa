using System;
using System.Collections.Generic;
using System.Text;

namespace Opd111
{
    class Program
    {
        static void Main(string[] args)
        {
            // Playlisten hard gecodeerd samenstellen
            Zanger[] zangers = new Zanger[6];
            zangers[0] = new Zanger { Naam = "Zanger 1", Land = "Land 1" };
            zangers[1] = new Zanger { Naam = "Zanger 2", Land = "Land 2" };
            zangers[2] = new Zanger { Naam = "Zanger 3", Land = "Land 1" };
            zangers[3] = new Zanger { Naam = "Zanger 4", Land = "Land 1" };
            zangers[4] = new Zanger { Naam = "Zanger 5", Land = "Land 2" };
            Lied[] liedjes = new Lied[10];
            liedjes[0] = new Lied { Titel = "Liedje 1", Uitvoerder = zangers[0] };
            liedjes[1] = new Lied { Titel = "Liedje 2", Uitvoerder = zangers[0] };
            liedjes[2] = new Lied { Titel = "Liedje 3", Uitvoerder = zangers[0] };
            liedjes[3] = new Lied { Titel = "Liedje 4", Uitvoerder = zangers[1] };
            liedjes[4] = new Lied { Titel = "Liedje 5", Uitvoerder = zangers[2] };
            liedjes[5] = new Lied { Titel = "Liedje 6", Uitvoerder = zangers[3] };
            liedjes[6] = new Lied { Titel = "Liedje 7", Uitvoerder = zangers[4] };
            liedjes[7] = new Lied { Titel = "Liedje 8", Uitvoerder = zangers[1] };
            liedjes[8] = new Lied { Titel = "Liedje 9", Uitvoerder = zangers[4] };
            Playlist plist1 = new Playlist { Naam = "plist1" };
            plist1.Liedjes = new List<Lied>{  liedjes[0] ,  liedjes[1] ,  liedjes[2]  }  ;
            Playlist plist2 = new Playlist { Naam = "plist2" };
            plist2.Liedjes = new List<Lied> { liedjes[3], liedjes[4], liedjes[5] };
            Playlist plist3 = new Playlist { Naam = "plist3" };
            plist3.Liedjes = new List<Lied> { liedjes[6], liedjes[7], liedjes[8] };

            // Gebruiker liedje toevoegen aan plist2
            Console.WriteLine("Voeg een nieuw liedje toe aan deze playlist !");
            Console.WriteLine(plist2.ToString());
            string titel;
            do
            {
                Console.WriteLine("Voer titel van nieuw liedje in:");
                titel = Console.ReadLine();
            } while (String.IsNullOrEmpty(titel));
            string zanger;
            do
            {
                Console.WriteLine("Voer naam van de zanger in:");
                zanger = Console.ReadLine();
            } while (String.IsNullOrEmpty(zanger));
            string land;
            do
            {
                Console.WriteLine("Geef herkomst land van zanger in:");
                land = Console.ReadLine();
            } while (String.IsNullOrEmpty(land));
            zangers[5] = new Zanger { Naam = zanger, Land = land };
            liedjes[9] = new Lied { Titel = titel, Uitvoerder = zangers[5] };
            plist2.Liedjes.Add(liedjes[9]);
            Console.WriteLine("\n\nKies nu een liedje(positie) uit deze playlist om af te spelen!");
            Console.WriteLine(plist2.ToString());
            int positie;
            do
            {
                Console.WriteLine("Voer positie nummer in:");
                positie = int.Parse(Console.ReadLine());
            } while (positie>4 || positie<1);
            Console.WriteLine(">NOW PLAYING<");
            Console.WriteLine(plist2.Liedjes[positie-1]);
            Console.WriteLine("\n\nZanger zoeken!");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(zangers[i].ToString());
            }
            bool gevonden = true;
            string zoekzanger;
            do
            {
                
                Console.WriteLine("Geef een zanger (naam) in:");
                zoekzanger = Console.ReadLine();
                for (int i=0; i < 5; i++)
                {
                    if (zangers[i].Naam == zoekzanger)
                    {
                        Console.WriteLine("Zanger:("+zoekzanger+") gevonden!");
                        gevonden = false;
                    }
                }
                

            } while (gevonden);

            Console.WriteLine("\n\nvan " + zoekzanger + " zijn volgende liedjes gekend:");
            for (int i = 0; i < 9; i++)
            {
                if (liedjes[i].Uitvoerder.Naam == zoekzanger)
                { Console.WriteLine(liedjes[i].Titel); }
            }

            Console.WriteLine("Een liedje verwijderen !");
            Console.WriteLine("Geef playlist en positie op:");
            Console.WriteLine(plist1.ToString());
            Console.WriteLine(plist2.ToString());
            Console.WriteLine(plist3.ToString());
        }
    }
}
