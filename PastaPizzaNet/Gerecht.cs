using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    internal abstract class Gerecht : IBedrag
    {
        public Gerecht(string naam, decimal prijs, BesteldGerecht.Grootte grootte, BesteldGerecht.Extras extras)
        {
            Naam = naam;
            Prijs = prijs;
            Grootte = grootte;
            Extras = extras;
        }
        public string Naam { get; set; }
        private decimal prijsValue;
        public BesteldGerecht.Grootte Grootte { get; set; }
        public BesteldGerecht.Extras Extras { get; set; }
        public decimal Prijs
        {
            get { return prijsValue; }
            set
            {
                prijsValue = value;
                if (Grootte.ToString().Equals(BesteldGerecht.Grootte.groot.ToString()))
                    prijsValue = value + 3m;
                /*if (Extras)
                    prijsValue = value;*/
            }
        }
        public override string ToString()
        {
            return $"Gerecht: {Naam} ({Prijs} EUR) ({Grootte}) extra: {Extras}";
        }

        public decimal BerekenBedrag()
        {
            return Prijs;
        }
        public void Wegschrijven()
        {
            string locatie = @"C:\data\";
            StringBuilder gerechtRegel;
            try
            {
                using var schrijver = new StreamWriter(locatie + "gerechten.txt");
                gerechtRegel = new StringBuilder();
                gerechtRegel.Append($"{Naam}#");
                gerechtRegel.Append($"{Prijs}#");
                gerechtRegel.Append($"{Grootte}#");
                gerechtRegel.Append($"{Extras}#");
                schrijver.WriteLine(gerechtRegel);
            }
            catch (IOException)
            {
                Console.WriteLine("Fout bij het inlezen van het bestand!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
