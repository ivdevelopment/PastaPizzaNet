using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    internal class Bestelling : IBedrag
    {
        public Bestelling(int aantal = 1)
        {
            Aantal = aantal;
        }
        public Klant Klant { get; set; }
        public Gerecht Gerecht { get; set; }
        public Drank Drank { get; set; }
        public Dessert Dessert { get; set; }
        private int aantalValue;
        public int Aantal
        {
            get { return aantalValue; }
            set { aantalValue = value; }
        }

        public decimal BerekenBedrag() 
        {
            return (Gerecht.Prijs + Drank.Prijs + Dessert.Prijs) * Aantal;
        }
    }
}
