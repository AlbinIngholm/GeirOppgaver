static int adder (int tall1, int tall2) // funksjon som tar inn tall1 og tall 2 som parameter
{
    int resultat = tall1 + tall2; // definerer en variabel med verdien tall1+tall2
    Console.WriteLine($"Sum = {resultat}"); // skriver ut resultatet
    return resultat; // returnerer resultatet
}

static int forekomster(string aTekst, char aBokstav) // funksjon som tar inn en streng og en char som parameter
{
    int forekomst = 0; // initialiserer en variabel for antall forekomster
    foreach(char c in aTekst) // for hver bokstav i strengen kjør:
    {
        if(c == aBokstav)
        {
            forekomst++; // hvis bokstaven matcher input til bruker, øk forekomst med 1.
        }
    }
    return forekomst; // returnerer forekomst
}

adder(3, 4); // kaller på funksjon
adder(17, 169);



Console.WriteLine("Skriv inn en tekststreng");
string? tekst = Console.ReadLine(); // tar inn brukerinput som stirng

Console.WriteLine("Skriv inn en bokstav");
char bokstav = Console.ReadKey().KeyChar; // tar inn brukerinput som char
Console.WriteLine(); // ny linje

int antall = forekomster (tekst, bokstav); // kaller på funksjonen  forekomster og tar inn tekst og bokstav som parameter
Console.WriteLine($"Bokstaven {bokstav} dukker opp {antall} ganger i teksten.");

