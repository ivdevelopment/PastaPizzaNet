using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    internal abstract class Drank : IBedrag
    {
        public enum Dranksoorten
        {
            water, limonade, cocacola, thee, koffie
        }
        private decimal prijsValue;
        public decimal Prijs
        {
            get { return prijsValue; }
            set
            {
                if (value.Equals(Dranksoorten.cocacola) || value.Equals(Dranksoorten.water) || value.Equals(Dranksoorten.limonade))
                    prijsValue = 2m;
                else if (value.Equals(Dranksoorten.thee) || value.Equals(Dranksoorten.koffie))
                    prijsValue = 2.5m;
                else
                    prijsValue = 0m;
            }
        }

        public abstract decimal BerekenBedrag();
    }
}
