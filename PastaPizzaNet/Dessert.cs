using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    internal class Dessert : IBedrag
    {
        public Dessert(Dessertnaam naam)
        {
            Naam = naam;
        }
        public enum Dessertnaam
        {
            tiramisu, ijs, cake
        }
        public Dessertnaam Naam { get; set; }
        private decimal prijsValue;
        public decimal Prijs
        {
            get
            {
                if (Naam.ToString() == "cake")
                    return prijsValue = 2m;
                if (Naam.ToString() == "tiramisu" || Naam.ToString() == "ijs")
                    return prijsValue = 3m;
                return prijsValue;
            }
/*            set
            {
                if (Naam.ToString().Contains("cake"))
                    prijsValue = 2m;
                else if (Naam.ToString() == "tiramisu" || Naam.ToString() == "ijs")
                    prijsValue = 3m;
                else
                    prijsValue = 0m;

            }*/
        }

        public override string ToString()
        {
            return $"{Naam}";
        }

        public decimal BerekenBedrag()
        {
            return Prijs;
        }
    }
}
