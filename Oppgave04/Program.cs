static void SkrivUt()
{
    Console.Write("Skriv inn navn: ");
    string? name = Console.ReadLine();
    Console.Write("Hvor kommer du fra?: ");
    string? origin = Console.ReadLine();

    string message = $"Hei, {name}! Du er fra {origin}";
    Console.WriteLine(message);

}

SkrivUt();
SkrivUt();
SkrivUt();