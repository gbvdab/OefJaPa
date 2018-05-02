using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opd509
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int l = 0; l < 100; l++)
            {
                for (int i = 0, j = 0; i < 10; i++, j++)
                {
                    for (int k = 0; k < j; k++)
                    {
                        Console.Write("*");
                        //System.Threading.Thread.Sleep(1);

                    }
                    Console.WriteLine("");

                }
                for (int i = 10, j = 10; i > 0; i--, j--)
                {
                    for (int k = 0; j - k > 0; k++)
                    {
                        Console.Write("*");
                        System.Threading.Thread.Sleep(1);
                    }
                    Console.WriteLine("");

                }
            }

        }

    }
}
