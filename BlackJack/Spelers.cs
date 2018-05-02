using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;

namespace BlackJack
{
    [Serializable]
    public class Spelers
    {
        public string Naam { get; set; }
        public int Wins { get; set; }
        public int Loss { get; set; }
        public string[,] Hand { get; private set; }
        public int Score()
        {
            int som = 0;
            int aas = 0;
            for (int i=0;i<13;i++)
            {
                if (this.Hand[i, 1] != "")
                {
                    som += Int32.Parse(this.Hand[i, 1]);
                    if (Int32.Parse(this.Hand[i, 1]) == 1) aas++;
                }
            }
            for (int i=aas;i>0;i--)
            {
                if (som < 12) som += 10;
            }
            return som;
        }
        public void AddKaart(string[,] kaart)
        {
            bool aanvullen = true;
            int i = 0;
            do
            {
                if (Hand[i, 0] == "")
                {
                    Hand[i, 0] = kaart[0, 0];
                    Hand[i, 1] = kaart[0, 1];
                    aanvullen = false;
                }
                i++;
            } while (aanvullen);
                
        }

        public void NieuweHand()
        {
            this.Hand = new string[13, 2];
            for (int i = 0; i < 13; i++) // max 11 kaarten tot 21
            {
                this.Hand[i, 0] = "";
                this.Hand[i, 1] = "";
            }

        }
        public void SpelerOpslaan()
        {
            //string directoryName = Directory.GetCurrentDirectory() + "\blackjack.dat";
            string opslag = @"D:\DEV\EDUC\VDAB\20180416_PF\OefJaPa\BlackJack\blackjack.dat";
            string lijn = this.Naam + ":" + this.Wins + ":" + this.Loss;
            string gevondenlijn;
            string tmpLijn;
            List<string> data = new List<string>();
            if (File.Exists(opslag))
            {
                try
                {
                    using (var lezer = new StreamReader(opslag))
                    {
                        while ((tmpLijn = lezer.ReadLine()) != null)
                        {
                            data.Add(tmpLijn);
                        }
                    }
                }
                catch (IOException)
                {
                    Console.WriteLine("LeesFout bij SpelerOpslaan");
                }
                // na inlezen wissen en dan speler updaten/aanvullen
                File.Delete(opslag);
                gevondenlijn = "";
                foreach (string datalijn in data)
                {
                    string[] splitlijn = datalijn.Split(new char[] { ':' });
                    if (splitlijn[0] == this.Naam)
                        gevondenlijn = datalijn;
                }
                if (gevondenlijn != "")
                {
                    data.Remove(gevondenlijn);
                }
                data.Add(lijn);
                try
                {
                    using (var schrijver = new StreamWriter(opslag))
                    {
                        foreach (string datalijn in data)
                        {
                            schrijver.WriteLine(datalijn);
                        }

                    }
                }
                catch (IOException)
                {
                    Console.WriteLine("Fout bij updaten van het bestand");
                }
            } else
            {
                // bestand bestaat nog niet
                try
                {
                    using (var schrijver = new StreamWriter(opslag))
                    {
                        schrijver.WriteLine(lijn);
                    }
                }
                catch (IOException)
                {
                    Console.WriteLine("Fout bij het schrijven van een nieuw bestand");
                }
            }
                
            
                
            




        }
        public void SpelerLaden()
        {
            //string directoryName = Directory.GetCurrentDirectory();
            string opslag = @"D:\DEV\EDUC\VDAB\20180416_PF\OefJaPa\BlackJack\blackjack.dat";
            string lijn;
            if (File.Exists(opslag))
            {

                try
                {
                    using (var lezer = new StreamReader(opslag))
                    {
                        while ((lijn = lezer.ReadLine()) != null)
                        {
                            string[] gegevens = lijn.Split(new char[] { ':' });
                            if (gegevens[0] == this.Naam)
                            {
                                this.Wins = Int32.Parse(gegevens[1]);
                                this.Loss = Int32.Parse(gegevens[2]);
                            }
                        }
                    }
                }
                catch (IOException)
                {
                    Console.WriteLine("Fout bij Spelerladen");
                }
            }

        }

    }
}
