using PastaPizzaNet;
using System.Text;

// Onderdelen toevoegen
List<string> margherita = new() { "tomatensaus", "mozzarella" };
List<string> napoli = new() { "tomatensaus", "mozzarella", "ansjovis", "kappers", "olijven" };


// Klanten aanmaken
Klant jan = new(1, "Jan", "Janssen");
Klant piet = new(2, "Piet", "Peeters");
Klant onbekend = new();

// Klanten in een lijst steken
var klanten = new List<Klant> { jan, piet };

// Streamwriter voor klanten aanmaken
using var schrijverKlant = new StreamWriter(@"C:\data\klanten.txt");
foreach (var klant in klanten)
    // klanten wegschrijven 
    klant.Wegschrijven(schrijverKlant);

// Klanten inlezen vanuit bestand
/*var lezerKlant = new StreamReader(@"C:\data\klanten.txt");
foreach (var klant in klanten)
    klant.Inlezen(lezerKlant);*/

// Gerechten aanmaken
Gerecht pizza1 = new Pizza("Pizza Margherita", 8m, margherita, BesteldGerecht.Grootte.klein, BesteldGerecht.Extras.look);
Gerecht pizza2 = new Pizza("Pizza Napoli", 9.5m, napoli, BesteldGerecht.Grootte.groot, BesteldGerecht.Extras.kaas);
Gerecht pasta1 = new Pasta("Lasagne", 10m, "Lasagnebladeren met bolognesesaus", BesteldGerecht.Grootte.groot, BesteldGerecht.Extras.brood);
Gerecht pasta2 = new Pasta("Pasta Carbonara", 9m, "spaghettis met kaassaus en spek", BesteldGerecht.Grootte.klein, BesteldGerecht.Extras.kaas);
Gerecht pasta3 = new Pasta("Spaghetti Bolognese", 8m, "spaghetti met bolgonesesaus", BesteldGerecht.Grootte.groot, BesteldGerecht.Extras.brood);

// Gerechten in een lijst steken
var gerechten = new List<Gerecht> { pizza1, pizza2, pasta1, pasta2, pasta3 };



// streamwriter voor gerechten aanmaken
using var schrijverGerecht = new StreamWriter(@"C:\data\gerechten.txt");
foreach (var gerecht in gerechten)
    // gerechten wegschrijven
    gerecht.Wegschrijven(schrijverGerecht);

// gerechten inlezen
/*using var lezerGerecht = new StreamReader(@"C:\data\gerechten.txt");
foreach (var gerecht in gerechten)
    gerecht.Inlezen(lezerGerecht);*/


// Dranken aanmaken
Drank water = new Frisdrank(Drank.Dranksoorten.water);
Drank cola = new Frisdrank(Drank.Dranksoorten.cola);
Drank limonade = new Frisdrank(Drank.Dranksoorten.limonade);
Drank koffie = new Frisdrank(Drank.Dranksoorten.koffie);
Drank thee = new Frisdrank(Drank.Dranksoorten.thee);

Dessert cake = new(Dessert.Dessertnaam.cake);
Dessert ijs = new(Dessert.Dessertnaam.ijs);
Dessert tiramisu = new(Dessert.Dessertnaam.tiramisu);

// Gerechtenlijst aanmaken
var gerechtenLijst = new List<Bestelling>
{
    new Bestelling(1, jan, pizza1, water, cake, 1),
    new Bestelling(2, piet, pizza2, cola, ijs, 2),
    new Bestelling(3, onbekend, pasta1, koffie, tiramisu, 1),
    new Bestelling(4, jan, pasta2, thee, ijs, 3),
    new Bestelling(5, onbekend, pasta3, limonade, cake, 1),
    new Bestelling(6, piet, pizza2, water, tiramisu, 1),
    new Bestelling(7, jan, pasta2, cola, ijs, 2)
};


// streamwriter aanmaken
using var schrijverBestelling = new StreamWriter(@"C:\data\bestellingen.txt");

// streamreader aanmaken
/*using var lezerBestelling = new StreamReader(@"C:\data\bestellingen.txt");*/

foreach (var gerecht in gerechtenLijst)
{
    gerecht.Afbeelden();
    Console.WriteLine($"Totaal bedrag van deze bestelling: {gerecht.BerekenBedrag()} EUR");
    Console.WriteLine($"***********************************************************************");
    // bestellingen wegschrijven
    gerecht.Wegschrijven(schrijverBestelling);
    // gerechten inlezen
/*    gerecht.Inlezen(lezerBestelling);*/

}


// Enkel de bestellingen van Jan
var bestellingen = gerechtenLijst.Where(bestelling => bestelling.Klant == jan);
Console.WriteLine("Enkel de bestellingen van Jan Janssen:");
foreach (var bestelling in bestellingen)
{
    bestelling.Afbeelden();
    Console.WriteLine($"Totaal bedrag van deze bestelling: {bestelling.BerekenBedrag()} EUR");
    Console.WriteLine();
}


// Alle bestellingen, gegroepeerd per klant
/*var alleBestellingen = gerechtenLijst.GroupBy(bestelling => bestelling.Klant);
Console.WriteLine("Alle bestellingen, gegroepeerd per klant:");
foreach (var bestelling in alleBestellingen)
{
    bestelling.ToString();
    Console.WriteLine($"Totaal bedrag van deze bestelling: {bestelling} EUR");
    Console.WriteLine();
}*/


