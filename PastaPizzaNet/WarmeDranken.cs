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
        public WarmeDranken(Dranksoorten naam)
        {
            Naam = naam;
        }
        private Dranksoorten naamValue;
        public Dranksoorten Naam
        {
            get { return naamValue; }
            set
            {
                    naamValue = value;
            }
        }
        private decimal prijsValue;
        public new decimal Prijs
        {
            get { return prijsValue = 2.5m; }
        }
        
        public override string ToString()
        {
            return $"{Naam} ({Prijs} EUR)";
        }
        public override decimal BerekenBedrag()
        {
            return prijsValue;
        }
    }
}
