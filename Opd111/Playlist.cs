using System;
using System.Collections.Generic;
using System.Text;

namespace Opd111
{
    public class Playlist
    {
        public List<Lied> Liedjes { get; set; }
        public string Naam { get; set; }


        public override string ToString()
        {
            string uitvoer = "Playlist:" + Naam + "\n";
            int tel = 0;
            foreach (Lied liedje in this.Liedjes)
            {
                tel++;
                uitvoer += tel + ">" + liedje.ToString() + "\n";
            }
            uitvoer += ">";
            return uitvoer;
        }
    }
}
