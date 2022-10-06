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
        public BesteldGerecht.Grootte Grootte { get; set; }
        public BesteldGerecht.GroottePrijs GroottePrijs { get; set; }
        public BesteldGerecht.Extras Extras { get; set; }
        private decimal prijsValue;
        public decimal Prijs
        {
            get
            {
                if (Grootte == BesteldGerecht.Grootte.groot)
                    prijsValue += 3m;
                return prijsValue;
            }
            set
            {
                prijsValue = value;
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
        public void Wegschrijven(StreamWriter schrijver)
        {
            StringBuilder gerechtRegel;
            try
            {
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
        public static void Inlezen(StreamReader lezer)
        {
            try
            {
                string regel;
                while ((regel = lezer.ReadLine()) != null)
                    Console.WriteLine(regel);
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
