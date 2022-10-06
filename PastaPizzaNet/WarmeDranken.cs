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
                if (value.Equals(Dranksoorten.koffie) || value.Equals(Dranksoorten.thee))
                    naamValue = value;
            }
        }
        public override decimal Prijs
        {
            get { return 2.5m; }
        }
        
        public override string ToString()
        {
            return $"{Naam} ({Prijs} EUR)";
        }
        public override decimal BerekenBedrag()
        {
            return Prijs;
        }
    }
}
