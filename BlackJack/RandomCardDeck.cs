using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BlackJack
{
    public class RandomCardDeck
    {
        public string[,] Cards
        {
            get
            {
                string[] soort = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "T", "B", "V", "H" };
                string[,] boek = new string[52, 2];
                string[,] geschud = new string[52, 2];
                string kleur = "R";
                int id = 0;
                for (int i = 0; i < 13; i++)
                {
                    id = 0+i;
                    boek[id, 0] = kleur + soort[i];
                    if (i > 9)
                    {
                        boek[id, 1] = "10";

                    }
                    else
                    {
                        boek[id, 1] = Convert.ToString(i + 1);
                    }
                }
                kleur = "H";
                for (int i = 0; i < 13; i++)
                {
                    id = 13+i;
                    boek[id, 0] = kleur + soort[i];
                    if (i > 9)
                    {
                        boek[id, 1] = "10";

                    }
                    else
                    {
                        boek[id, 1] = Convert.ToString(i + 1);
                    }
                }
                kleur = "S";
                for (int i = 0; i < 13; i++)
                {
                    id = 26+i;
                    boek[id, 0] = kleur + soort[i];
                    if (i > 9)
                    {
                        boek[id, 1] = "10";

                    }
                    else
                    {
                        boek[id, 1] = Convert.ToString(i + 1);
                    }
                }
                kleur = "K";
                for (int i = 0; i < 13; i++)
                {
                    id = 39+i;
                    boek[id, 0] = kleur + soort[i];
                    if (i > 9)
                    {
                        boek[id, 1] = "10";

                    }
                    else
                    {
                        boek[id, 1] = Convert.ToString(i + 1);
                    }
                }
                int[] numbers = Enumerable.Range(0,52).ToArray();
                Random rand = new Random();
                int temp;
                for (int i = 51; i > 0; i--)
                {
                    int swpIndex = rand.Next(i + 1);
                    temp = numbers[i];
                    numbers[i] = numbers[swpIndex];
                    numbers[swpIndex] = temp;
                }
                for (int i = 0; i < 52; i++)
                {
                    geschud[i, 0] = boek[numbers[i], 0];
                    geschud[i, 1] = boek[numbers[i], 1];
                }
                return geschud;
            }


        }
    }
}

