using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PastaPizzaNet.Drank;

namespace PastaPizzaNet
{
    internal class WarmeDranken : Drank
    {
        private Dranksoorten naamValue;
        public Dranksoorten Naam
        {
            get { return naamValue; }
            set
            {
                if (value.Equals(Dranksoorten.thee) || value.Equals(Dranksoorten.koffie))
                    naamValue = value;
            }
        }
        private decimal prijsValue;
        public decimal Prijs
        {
            get { return prijsValue; }
            set
            {
                prijsValue = 2.5m;
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
