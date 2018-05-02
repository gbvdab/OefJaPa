using System;
using System.Collections.Generic;
using System.Text;

namespace Opd111
{
    public class Lied
    {
        public Zanger Uitvoerder { get; set; }
        public string Titel { get; set; }
        public override string ToString()
        {
            string temp = "Lied:";
            temp += Titel+"("+Uitvoerder.Naam+"-"+Uitvoerder.Land+")";
            return temp;
        }
    }
}
