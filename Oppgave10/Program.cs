// Ordbok med beboere som key, og måltider som value
Dictionary<string, List<string>> måltider = new Dictionary<string, List<string>>
{
    {"Kari",new List<string> {"Egg og bacon","Salat","Fisk"} },
    {"Per", new List<string> {"Frokostblanding","Brødskive med gulost","Kylling" } },
    {"Kjell", new List<string> {"Yoghurt","Smoothie","Biff" } },
    {"Arne", new List<string> {"Banan","Kyllingsalat","Pizza" } },

};

skrivUt(måltider); // kaller på funksjonen for skrive ut og hente måltider

static void skrivUt(Dictionary<string, List<string>> måltider) // funksjon som tar inn måltider som parameter
{
    Console.Write("Beboere:\n");
    foreach(var person in måltider.Keys) // looper gjennom for hver key i ordboka. 
    {
        Console.WriteLine(person); // skriver ut key
    }

    Console.WriteLine("\nSkriv inn navnet på beboeren du ønsker å hente matplan for: ");
    string? beboerInput = Console.ReadLine(); // catcher brukerinput

    if (måltider.ContainsKey(beboerInput)) // sjekker om ordboka inneholder brukerinput
    {
        List<string> dagsmåltid = måltider[beboerInput]; // liste som henter value fra ordboka, med brukerinput som key
        Console.WriteLine($"\nFrokost: {dagsmåltid[0]}"); // skriver ut index 0 av key
        Console.WriteLine($"Lunsj: {dagsmåltid[1]}");
        Console.WriteLine($"Middag: {dagsmåltid[2]}");
    } else
    {
        Console.WriteLine("Feil! Finner ikke beboer i systemet.");
    }
}
