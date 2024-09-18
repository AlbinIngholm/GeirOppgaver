Dictionary<string, List<string>> måltider = new Dictionary<string, List<string>>
{
    {"Kari",new List<string> {"Egg og bacon","Salat","Fisk"} },
    {"Per", new List<string> {"Frokostblanding","Brødskive med gulost","Kylling" } },
    {"Kjell", new List<string> {"Yoghurt","Smoothie","Biff" } },
    {"Arne", new List<string> {"Banan","Kyllingsalat","Pizza" } },

};

skrivUt(måltider);

static void skrivUt(Dictionary<string, List<string>> måltider)
{
    Console.Write("Beboere:\n");
    foreach(var person in måltider.Keys)
    {
        Console.WriteLine(person);
    }

    Console.WriteLine("\nSkriv inn navnet på beboeren du ønsker å hente matplan for: ");
    string? beboerInput = Console.ReadLine();

    if (måltider.ContainsKey(beboerInput))
    {
        List<string> dagsmåltid = måltider[beboerInput];
        Console.WriteLine($"\nFrokost: {dagsmåltid[0]}");
        Console.WriteLine($"Lunsj: {dagsmåltid[1]}");
        Console.WriteLine($"Middag: {dagsmåltid[2]}");
    } else
    {
        Console.WriteLine("Feil! Finner ikke beboer i systemet.");
    }
}
