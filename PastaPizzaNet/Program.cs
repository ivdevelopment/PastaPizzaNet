using PastaPizzaNet;

List<string> margherita = new List<string> { "Tomatensaus", "Mozzarella" };
List<string> napoli = new List<string> { "Tomatensaus", "Mozzarella", "ansjovis", "kappers", "olijven" };

Klant jan = new Klant(1, "Jan", "Janssen");
Klant piet = new Klant(2, "Piet", "Peeters");
Klant onbekend = new Klant();

Gerecht gerecht1 = new Pizza("Pizza Margherita", 8m, margherita, BesteldGerecht.Grootte.klein, BesteldGerecht.Extras.look);


Console.WriteLine(gerecht1);

    
