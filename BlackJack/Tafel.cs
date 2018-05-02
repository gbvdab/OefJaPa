using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Tafel
    {
        public void SpelerNaam(string naam)
        {
            Console.SetCursorPosition(1, 1);
            Console.Write("SPELER: ");
            Console.Write(naam);
            Console.SetCursorPosition(1, 15);

        }
        public void SpelerWins(int wins)
        {
            Console.SetCursorPosition(1, 2);
            Console.Write(wins+" x gewonnen    ");
            Console.SetCursorPosition(1, 15);
        }
        public void ComputerWins(int wins)
        {
            Console.SetCursorPosition(60, 2);
            Console.Write(wins+" x gewonnen    ");
            Console.SetCursorPosition(1, 15);
        }
        public void SpelerHand(string[,] hand)
        {
            for (int i = 0; i < 13; i++)
            {
                Console.SetCursorPosition(1 + i * 3, 4);
                if (hand[i, 0] != "")
                    { Console.Write(hand[i, 0]); }
                    else { Console.Write("  "); }
            }
            

        }
        public void ComputerHand(string[,] hand)
        {
            for (int i = 0; i < 13; i++)
            {
                Console.SetCursorPosition(60 + i * 3, 4);
                if (hand[i, 0] != "")
                { Console.Write(hand[i, 0]); }
                else { Console.Write("  "); }
            }
        }
        public void SpelTekst(string tekst)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(20, 13);
            Console.Write("                                                              ");
            Console.SetCursorPosition(20, 13);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(tekst);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(1, 15);

        }
        public string SpelMenu(string vraag)
        {
            string respons;
            respons = "";
            bool input = true;
            while (input)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition(1, 14);
                Console.Write(vraag + " ");
                respons=Console.ReadLine();
                if (!String.IsNullOrEmpty(respons)) input = false;
            }
            Console.SetCursorPosition(1, 14);
            Console.Write("                                                                    ");
            return respons;
        }
        public void Welkom()
        {
            Console.SetBufferSize(200, 200);
            Console.WindowHeight = 20;
            Console.WindowWidth = 140;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Title = "-------------------------  B L A C K J A C K  -------------------------";
            Console.Clear();
            Console.SetCursorPosition(1, 1);
            Console.Write("SPELER:");
            Console.SetCursorPosition(30, 0);
            Console.Write("WELKOM!");
            Console.SetCursorPosition(60, 1);
            Console.Write("COMPUTER: VDAB");
            Console.SetCursorPosition(1, 15);
            Console.Write("Speler, geef uw naam in !");
        }
    }
}
