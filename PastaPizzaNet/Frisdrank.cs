using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    internal class Frisdrank : Drank
    {
        public Frisdrank(Dranksoorten naam)
        {
            Naam = naam;
        }
        private Dranksoorten naamValue;
        public Dranksoorten Naam
        {
            get { return naamValue; }
            set
            {
                if (value.Equals(Dranksoorten.cola) || value.Equals(Dranksoorten.water) || value.Equals(Dranksoorten.limonade))
                    naamValue = value;
            }
        }
        private decimal prijsValue;
        public decimal Prijs
        {
            get { return prijsValue = 2m; }
        }
        public override string ToString()
        {
            return $"{Naam} ({Prijs})";
        }
        public override decimal BerekenBedrag()
        {
            return Prijs;
        }
    }
}
