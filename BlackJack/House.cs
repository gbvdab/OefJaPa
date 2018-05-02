using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class House
    {
        public int Wins { get; set; }
        public string[,] Hand { get; private set; }
        public int Score()
        {
            int som = 0;
            int aas = 0;
            for (int i = 0; i < 13; i++)
            {
                if (this.Hand[i, 1] != "")
                {
                    som += Int32.Parse(this.Hand[i, 1]);
                    if (Int32.Parse(this.Hand[i, 1]) == 1) aas++;
                }
            }
            for (int i = aas; i > 0; i--)
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
    }
}
