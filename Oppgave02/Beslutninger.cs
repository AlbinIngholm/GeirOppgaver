Console.WriteLine("Har du lyst på en brus? (ja/nei)");
string? lystPåBrus = Console.ReadLine();

switch (lystPåBrus)
{
    case "ja":
        Console.Write("Her har du en brus!");
        break;
    case "nei":
        Console.Write("Den er grei.");
        break;
    default:
        Console.WriteLine("Det forstod jeg ikke helt.");
        break;
}