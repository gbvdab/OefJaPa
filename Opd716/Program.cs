using System;


namespace Opd716
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] statistiek= new int[101];
            Random willekeurig = new Random();
            for (int i = 0; i < 20000; i++)
            {
                statistiek[willekeurig.Next(1, 101)] += 1;
            }
            //ConsoleColor[] kleuren = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            //Console.BackgroundColor = kleuren[15];
            //Console.ForegroundColor = kleuren[0];

            Console.SetBufferSize(200, 200);
            Console.WindowHeight = 50;
            Console.WindowWidth = 170;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Title = "-------------------------  Verdeling van Willekeurige Getallen  -------------------------";
            Console.Clear();
            
            int som = 0;
            for (int i=1; i <= 100; i++)
            {
                string tmp = "   " + i;
                tmp = tmp.Substring(tmp.Length - 3);
                Console.Write(tmp + " ");
                Lijntje(statistiek[i]);
                som += statistiek[i];
            }
            Console.WriteLine("Som is {0}", som);
            
        }

        static void Lijntje(int aantal)
        {
            for (int i = 0; i < aantal-150; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine("= " + aantal);
        }
    }
}
