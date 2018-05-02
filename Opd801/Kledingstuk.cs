using System;
using System.Collections.Generic;
using System.Text;

namespace Opd801
{
    public class Kledingstuk
    {
        public double WasGraden { get; set; }
        public string Naam { get; set; }
        public override string ToString()
        {
            return "Kledingstuk: "+ Naam + " te wassen op "+ WasGraden +" graden.";
        }
    }
}
