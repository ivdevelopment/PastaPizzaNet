using PastaPizzaNet;
using System.Text;

List<string> margherita = new List<string> { "tomatensaus", "mozzarella" };
List<string> napoli = new List<string> { "tomatensaus", "mozzarella", "ansjovis", "kappers", "olijven" };

Klant jan = new Klant(1, "Jan", "Janssen");
Klant piet = new Klant(2, "Piet", "Peeters");
Klant onbekend = new Klant();

var klanten = new List<Klant> { jan, piet };

// klanten wegschrijven 
foreach (Klant klant in klanten)
    klant.Wegschrijven();


Gerecht pizza1 = new Pizza("Pizza Margherita", 8m, margherita, BesteldGerecht.Grootte.klein, BesteldGerecht.Extras.look);
Gerecht pizza2 = new Pizza("Pizza Napoli", 9.5m, napoli, BesteldGerecht.Grootte.groot, BesteldGerecht.Extras.kaas);
Gerecht pasta1 = new Pasta("Lasagne", 10m, "Lasagnebladeren met bolognesesaus", BesteldGerecht.Grootte.groot, BesteldGerecht.Extras.brood);
Gerecht pasta2 = new Pasta("Pasta Carbonara", 9m, "spaghettis met kaassaus en spek", BesteldGerecht.Grootte.klein, BesteldGerecht.Extras.kaas);
Gerecht pasta3 = new Pasta("Spaghetti Bolognese", 8m, "spaghetti met bolgonesesaus", BesteldGerecht.Grootte.groot, BesteldGerecht.Extras.brood);

// gerechten wegschrijven
pizza1.Wegschrijven();
pizza2.Wegschrijven();
pasta1.Wegschrijven();
pasta2.Wegschrijven();
pasta3.Wegschrijven();

Drank water = new Frisdrank(Drank.Dranksoorten.water);
Drank cola = new Frisdrank(Drank.Dranksoorten.water);
Drank limonade = new Frisdrank(Drank.Dranksoorten.water);
Drank koffie = new Frisdrank(Drank.Dranksoorten.water);
Drank thee = new Frisdrank(Drank.Dranksoorten.water);

Dessert cake = new Dessert(Dessert.Dessertnaam.cake);
Dessert ijs = new Dessert(Dessert.Dessertnaam.ijs);
Dessert tiramisu = new Dessert(Dessert.Dessertnaam.tiramisu);


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
foreach (var gerecht in gerechtenLijst)
{
    gerecht.Afbeelden();
    Console.WriteLine($"Totaal bedrag van deze bestelling: {gerecht.BerekenBedrag()} EUR");
    Console.WriteLine($"***********************************************************************");
    // bestellingen wegschrijven
    gerecht.Wegschrijven();
}

// bestellingen wegschrijven



