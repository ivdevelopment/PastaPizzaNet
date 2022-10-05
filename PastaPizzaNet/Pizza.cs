using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    internal class Pizza : Gerecht
    {
        public Pizza(string naam, decimal prijs, List<string> onderdelen, BesteldGerecht.Grootte grootte, BesteldGerecht.Extras extras) : base(naam, prijs, grootte, extras)
        {
            Onderdelen = onderdelen;
        }

        public List<string> Onderdelen { get; set; }

        public override string ToString()
        {
            var items = "";
            var onderdelen = Onderdelen;
            foreach (var item in onderdelen)
            {
                items += item + " ";
            }
            return $"{base.ToString()} - {items}";
        }
    }
}
