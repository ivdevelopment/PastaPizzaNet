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
        public Bestelling(int bestelNr, Klant klant, Gerecht gerecht, Drank drank, Dessert dessert, int aantal = 1)
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
        private decimal totaalBedrag;
        public decimal BerekenBedrag() 
        {
            totaalBedrag = (Gerecht.Prijs + Drank.Prijs + Dessert.Prijs) * Aantal;
            if (Gerecht.Prijs != 0 && Drank.Prijs != 0 && Dessert.Prijs != 0)
                totaalBedrag -= totaalBedrag * 0.1m;
            else return totaalBedrag;
            return totaalBedrag;
        }
        public override string ToString()
        {
            return $"Aantal: {Aantal}";
        }
        public void Wegschrijven(StreamWriter schrijver)
        {
           
            StringBuilder bestellingRegel;
            try
            {
                
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
