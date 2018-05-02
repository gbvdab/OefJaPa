using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            // init opzetten scherm en spelersinfo
            Tafel Output = new Tafel();
            Output.Welkom();
            bool vlag = true;
            string spelernaam;
            do
            {
                spelernaam = Console.ReadLine();
                if (!string.IsNullOrEmpty(spelernaam))
                {
                    spelernaam = spelernaam.Substring(0, Math.Min(spelernaam.Length, 10));
                    vlag = false;
                }
                else
                {
                    Output.Welkom();

                }

            } while (vlag);
            Output.Welkom();
            Console.SetCursorPosition(1, 15);
            Console.WriteLine("                           ");
            Output.SpelerNaam(spelernaam);

            // nakijken om gegevens te laden ?
            Spelers HuidigeSpeler = new Spelers
            {
                Naam = spelernaam,
                Wins = 0,
                Loss = 0
            };
            // proberen huidige speler te laden
            HuidigeSpeler.SpelerLaden();
            House VDAB = new House
            {
                Wins = HuidigeSpeler.Loss
            };
            Output.SpelerWins(HuidigeSpeler.Wins);
            Output.ComputerWins(VDAB.Wins);

            // spel starten
            RandomCardDeck init = new RandomCardDeck();
            string[,] spelBoek = init.Cards;
            int kaart = 0;
            bool ronde = true;
            bool comp = true;
            string[,] tmpKaart;
            string keuze;
            int scoretmp;
            int scoretmp2;
            tmpKaart = new string[1, 2];

            do
            {
                //start ronde
                ronde = true;
                HuidigeSpeler.NieuweHand();
                VDAB.NieuweHand();
                if (kaart > 48)
                {
                    spelBoek = init.Cards;
                    kaart = 0;
                }
                tmpKaart[0, 0] = spelBoek[kaart, 0];
                tmpKaart[0, 1] = spelBoek[kaart, 1];
                HuidigeSpeler.AddKaart(tmpKaart);
                kaart++;
                tmpKaart[0, 0] = spelBoek[kaart, 0];
                tmpKaart[0, 1] = spelBoek[kaart, 1];
                VDAB.AddKaart(tmpKaart);
                kaart++;
                tmpKaart[0, 0] = spelBoek[kaart, 0];
                tmpKaart[0, 1] = spelBoek[kaart, 1];
                HuidigeSpeler.AddKaart(tmpKaart);
                kaart++;
                tmpKaart[0, 0] = spelBoek[kaart, 0];
                tmpKaart[0, 1] = spelBoek[kaart, 1];
                VDAB.AddKaart(tmpKaart);
                kaart++;
                Output.SpelerHand(HuidigeSpeler.Hand);
                Output.ComputerHand(VDAB.Hand);
                // iemand 21 ?
                if (VDAB.Score() == 21)
                {
                    // speler verliest dan altijd
                    ronde = false;
                    comp = false;

                }
                else
                {
                    if (HuidigeSpeler.Score() == 21)
                    {
                        // Speler is gewonnen met een blackjack te trekken
                        ronde = false;
                        comp = false;
                    }
                }

                while (ronde)
                {
                    // speler kaarten trekken tot stop
                    keuze = Output.SpelMenu("[1] Kaart Nemen /[2] Pas /[0] Stoppen");
                    switch (keuze)
                    {
                        case "1":
                            // kaart nemen
                            if (kaart > 51)
                            {
                                spelBoek = init.Cards;
                                kaart = 0;
                            }
                            tmpKaart[0, 0] = spelBoek[kaart, 0];
                            tmpKaart[0, 1] = spelBoek[kaart, 1];
                            HuidigeSpeler.AddKaart(tmpKaart);
                            kaart++;
                            Output.SpelerHand(HuidigeSpeler.Hand);
                            if (HuidigeSpeler.Score() > 21)
                            { // een kaart teveel dus nu nog computer laten spelen
                                ronde = false;
                                comp = true;
                            }
                            if (HuidigeSpeler.Score() == 21)
                            {
                                // Speler moet stoppen
                                ronde = false;
                                comp = true;
                            }
                            break;
                        case "2":
                            // passen en computer laten spelen
                            ronde = false;
                            comp = true;
                            break;
                        case "0":
                            // stoppen met spel
                            return;
                        //break;
                        default:
                            // slechte input
                            break;

                    }
                }
                // computer laten spelen tot >17
                while (comp)
                {
                    // kaart nemen ?
                    scoretmp = VDAB.Score();
                    if (scoretmp < 18)
                    {
                        if (kaart > 51)
                        {
                            spelBoek = init.Cards;
                            kaart = 0;
                        }
                        tmpKaart[0, 0] = spelBoek[kaart, 0];
                        tmpKaart[0, 1] = spelBoek[kaart, 1];
                        VDAB.AddKaart(tmpKaart);
                        kaart++;
                        Output.ComputerHand(VDAB.Hand);

                    }
                    else if ((scoretmp < 21) && (scoretmp < HuidigeSpeler.Score()) && (HuidigeSpeler.Score() < 22))
                    { // toch blijven voortspelen
                        if (kaart > 51)
                        {
                            spelBoek = init.Cards;
                            kaart = 0;
                        }
                        tmpKaart[0, 0] = spelBoek[kaart, 0];
                        tmpKaart[0, 1] = spelBoek[kaart, 1];
                        VDAB.AddKaart(tmpKaart);
                        kaart++;
                        Output.ComputerHand(VDAB.Hand);

                    }
                    else if (scoretmp == 21)
                    {
                        // computer VDAB is gewonnen !
                        comp = false;
                    }
                    else if (scoretmp > 21)
                    {
                        // computer wint niet ...
                        comp = false;

                    }
                    else
                    { // stop maar
                        comp = false;
                    }

                }
                // winnaar bepalen stand bijhouden en opslaan
                scoretmp = HuidigeSpeler.Score();
                scoretmp2 = VDAB.Score();
                if ((scoretmp > 21) && (scoretmp2 > 21))
                {
                    // gelijk spel
                    Output.SpelTekst("Einde van deze ronde");
                }
                else if ((scoretmp > 21) && (scoretmp2 < 22))
                {
                    // speler verliest
                    Output.SpelTekst(HuidigeSpeler.Naam + " verliest deze ronde");
                    HuidigeSpeler.Loss++;
                    VDAB.Wins++;
                }
                else if ((scoretmp < 22) && (scoretmp2 > 21))
                {
                    // speler wint
                    Output.SpelTekst(HuidigeSpeler.Naam + " wint deze ronde !");
                    HuidigeSpeler.Wins++;
                }
                else if ((scoretmp == 21) && (scoretmp2 == 21))
                {
                    // kan enkel in die gevallen dat de computer wint dus
                    // speler verliest
                    Output.SpelTekst(HuidigeSpeler.Naam + " verliest toch nog deze ronde");
                    HuidigeSpeler.Loss++;
                    VDAB.Wins++;
                }
                else if ((scoretmp <= scoretmp2))
                {
                    // computer wint
                    // speler verliest
                    Output.SpelTekst(HuidigeSpeler.Naam + " verliest deze ronde");
                    HuidigeSpeler.Loss++;
                    VDAB.Wins++;
                }
                else if (scoretmp == 21)
                {
                    Output.SpelTekst(HuidigeSpeler.Naam + " wint deze ronde !");
                    HuidigeSpeler.Wins++;
                }

                Output.SpelerWins(HuidigeSpeler.Wins);
                Output.ComputerWins(VDAB.Wins);
                HuidigeSpeler.SpelerOpslaan();
                do
                {
                    keuze = Output.SpelMenu("[1] Nog eens proberen /[0] Stoppen");
                    if (keuze == "1")
                    {
                        ronde = true;
                    }
                    else if (keuze == "0")
                    {
                        ronde = false;
                    }

                } while ((keuze != "1") && (keuze != "0"));
                Output.SpelTekst("");


            } while (ronde);

        }

        // einde spel keuze

    }
}
