using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    internal class Pasta : Gerecht
    {
        public Pasta(string naam, decimal prijs, string omschrijving, BesteldGerecht.Grootte grootte, BesteldGerecht.Extras extras) : base(naam, prijs, grootte, extras)
        {
            Omschrijving = omschrijving;
        }

        public string Omschrijving { get; set; }
        public override string ToString()
        {
            return $"{base.ToString()} {Omschrijving}";
        }
        
    }
}
