using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    internal abstract class Gerecht : IBedrag
    {
        public Gerecht(string naam, decimal prijs, BesteldGerecht.Grootte grootte, BesteldGerecht.Extras extras)
        {
            Naam = naam;
            Prijs = prijs;
            Grootte = grootte;
            Extras = extras;
        }
        public string Naam { get; set; }
        private decimal prijsValue;
        public decimal Prijs
        {
            get { return prijsValue; }
            set
            {
                if (Grootte == BesteldGerecht.Grootte.groot)
                    prijsValue = value + 3;
                else
                    prijsValue = value;
            }
        }
        public BesteldGerecht.Grootte Grootte { get; set; }
        public BesteldGerecht.Extras Extras { get; set; }
        public override string ToString()
        {
            return $"Gerecht: {Naam} ({Prijs} EUR) ({Grootte}) extra: {Extras}";
        }

        public decimal BerekenBedrag()
        {
            return Prijs;
        }
    }
}
