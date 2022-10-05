using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PastaPizzaNet.BesteldGerecht;

namespace PastaPizzaNet
{
    internal class Bestelling : IBedrag
    {
        public Bestelling(int bestelNr, Klant klant, Gerecht gerecht, Drank drank, Dessert dessert, int aantal)
        {
            BestelNr = bestelNr;
            Klant = klant;
            Gerecht = gerecht;
            Drank = drank;
            Dessert = dessert;
            Aantal = aantal;
        }
        public int BestelNr { get; init; }
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
        public override string ToString()
        {
            return $"Aantal: {Aantal}";
        }
        public void Wegschrijven()
        {
            string locatie = @"C:\data\";
            StringBuilder bestellingRegel;
            try
            {
                using var schrijver = new StreamWriter(locatie + "bestellingen.txt");
                bestellingRegel = new StringBuilder();
                bestellingRegel.Append($"{Klant.KlantId}#");
                bestellingRegel.Append($"{Gerecht.Naam}-");
                bestellingRegel.Append($"{Gerecht.Grootte}-");
                bestellingRegel.Append($"{Gerecht.Extras}#");
                bestellingRegel.Append($"{Drank.Dranken}#");
                bestellingRegel.Append($"{Dessert.Naam}#");
                bestellingRegel.Append($"{Dessert.Prijs}#");
                schrijver.WriteLine(bestellingRegel);
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

        public void Afbeelden()
        {
            Console.WriteLine($"Bestelling {BestelNr}:");
            Console.WriteLine($"Klant: {Klant}");
            Console.WriteLine($"Gerecht: {Gerecht}");
            Console.WriteLine($"Drank: {Drank}");
            Console.WriteLine($"Dessert: {Dessert}");
            Console.WriteLine($"Aantal: {Aantal}");
        }
    }
}
