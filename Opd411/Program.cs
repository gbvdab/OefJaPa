using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opd411
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een getal van 1 tem 7 in !");
            int Invoer = int.Parse(Console.ReadLine());
            while (Invoer < 1 || Invoer > 7)
            {
                Console.WriteLine("een getal van 1 tem 7 ??:");
                Invoer = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.DayNames[Invoer - 1]);
            string dag = "";
            switch (Invoer)
            {
                case 1:
                    dag = "Zondag";
                    break;
                case 2:
                    dag = "Maandag";
                    break;
                case 3:
                    dag = "Dinsdag";
                    break;
                case 4:
                    dag = "Woensdag";
                    break;
                case 5:
                    dag = "Donderdag";
                    break;
                case 6:
                    dag = "Vrijdag";
                    break;
                case 7:
                    dag = "Zaterdag";
                    break;
            }
            Console.WriteLine("Oftewel in NL:" + dag);

        }

    }
}

