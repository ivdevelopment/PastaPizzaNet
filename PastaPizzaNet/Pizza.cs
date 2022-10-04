using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD:CSharpTaken/PastaPizzaNet/PastaPizzaNet/Pizza.cs
namespace PastaPizzaNet
{
    internal class Pizza : Gerecht
    {
        public Pizza(string naam, decimal prijs ,List<string> onderdelen, BesteldGerecht.Grootte grootte, BesteldGerecht.Extras extras) : base(naam, prijs, grootte, extras)
        {
            Onderdelen = onderdelen;
        }

        public List<string> Onderdelen { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} {Onderdelen}";
        }
=======
namespace ClassMakenOefening
{
    internal class Pizza
    {
        public string Naam { get; set; }
        public List<String> Onderdelen { get; set; }
        public decimal Prijs { get; set; }
        public override string ToString() => $"{this.Naam}: {this.Prijs} EUR";
>>>>>>> 6e814034cff29d731e7b2005b61a7b057180a3ee:ClassMakenOefening/Pizza.cs
    }
}
