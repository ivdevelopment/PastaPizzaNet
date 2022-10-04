using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    internal class Dessert : IBedrag
    {
        public enum Dessertnaam
        {
            tiramisu, ijs, cake
        }
        private decimal prijsValue;
        public decimal Prijs
        {
            get { return prijsValue; }
            set
            {
                if (value.Equals(Dessertnaam.tiramisu) || value.Equals(Dessertnaam.ijs))
                    prijsValue = 3m;
                else
                    prijsValue = 2m;
            }
        }

        public decimal BerekenBedrag()
        {
            return Prijs;
        }
    }
}
