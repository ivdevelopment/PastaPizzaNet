using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    internal class Klant
    {
        public Klant(int klantId, string voornaam, string familienaam)
        {
            KlantId = klantId;
            Voornaam = voornaam;
            Familienaam = familienaam;
        }
        public Klant() : this(0, "onbekend", "")
        {
        }

        public int KlantId { get; init; }
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }
        public override string ToString()
        {
            return $"Klant: {Voornaam} {Familienaam}";
        }
    }
}
