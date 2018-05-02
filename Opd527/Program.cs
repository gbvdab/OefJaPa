using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opd527
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef grootte van het Vermenigvuldigingsvierkant <40 ?");
            int aantal = int.Parse(Console.ReadLine());
            while(Math.Abs(aantal)>40)
            {
                Console.WriteLine("Okay, 1 positief geheel getal kleiner dan 40 ?");
                aantal = int.Parse(Console.ReadLine());

            }
            aantal = Math.Abs(aantal);
            double[,] vierkant = new double[aantal, aantal];
            for (int i=0;i<aantal;i++)
            {
                vierkant[0, i] = i+1;
                vierkant[i, 0] = i+1;
            }
            for (int i=1;i<aantal;i++)
            {
                for (int j=0;j<aantal-1;j++)
                {
                    vierkant[i, j + 1] = vierkant[0, j + 1] * vierkant[i, 0];
                }
            }
            string temp = "";
           for (int i=0;i<aantal;i++)
            {
                for (int j = 0; j < aantal; j++)
                {
                    temp = "     " + vierkant[i, j];
                    temp = temp.Substring(temp.Length - 5);
                    Console.Write(temp);
                }
                Console.WriteLine("");
            }

            for (int i = 0; i < aantal; i++)
            {
                for (int j = 0; j < aantal; j++)
                {
                    temp = "     " + ((i+1)*(j+1));
                    temp = temp.Substring(temp.Length - 5);
                    Console.Write(temp);
                }
                Console.WriteLine("");
            }


        }
    }
}
