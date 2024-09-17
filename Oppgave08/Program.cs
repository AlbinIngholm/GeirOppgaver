Dictionary<string, double> ordbok = new Dictionary<string, double> // arraylist som inneholder vare og pris som string og double
{
    {"melk", 14.90 },
    {"brød", 24.90 },
    {"yoghurt", 12.90 },
    {"pizza", 39.90 },
};


// skriv ut innholdet i ordboka
Console.WriteLine("Ordbokinnhold: ");
foreach(var vare in ordbok)
{
    Console.WriteLine($"{vare.Key} - kr {vare.Value:F2}"); 
}

//  leser inn to varer med navn og priser som brukeren inputter
for (int i = 0; i < 2; i++)
{
    Console.Write("Skriv inn varenavn: ");
    string   varenavn = Console.ReadLine();

    Console.Write("Skriv inn pris: ");
    if(double.TryParse(Console.ReadLine(),out double pris))
    {
        ordbok[varenavn] = pris;
    } else
    {
        Console.WriteLine("Ugyldig pris, prøv igjen");
        i--; // henter inn data igjen
    }
}

// skriver ut ordboka
Console.WriteLine("\nOppdatert ordbok:");
foreach(var vare in ordbok)
{
    Console.WriteLine($"{vare.Key} - kr {vare.Value:F2}");
}