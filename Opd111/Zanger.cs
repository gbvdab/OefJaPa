using System;
using System.Collections.Generic;
using System.Text;

namespace Opd111
{
    public class Zanger
    {
        public string Naam { get; set; }
        public string Land { get; set; }
        public override string ToString()
        {

            return "Zanger:"+Naam+" uit "+Land;
        }
    }
}
