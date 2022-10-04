using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    internal class Frisdrank : Drank
    {

        private Dranksoorten naamValue;
        public Dranksoorten Naam
        {
            get { return naamValue; }
            set
            {
                if (value.Equals(Dranksoorten.cocacola) || value.Equals(Dranksoorten.water) || value.Equals(Dranksoorten.limonade))
                    naamValue = value;
            }
        }
        private decimal prijsValue;
        public decimal Prijs
        {
            get { return prijsValue; }
            set
            {
                prijsValue = 2m;
            }
        }
        public override string ToString()
        {
            return $"Drank: {Naam} ({Prijs})";
        }
        public override decimal BerekenBedrag()
        {
            return Prijs;
        }
    }
}
