List<int> tall = new List<int> { 1, 8, 13, 19 };
tall.Add(14);

int sum = 0;
int produkt = 1;

foreach(int nummer in tall) // foreach løkke 
{
    sum += nummer;
    produkt *= nummer;
}

List<int> resultat = new List<int> { sum, produkt}; 

List<int> kombinert = new List<int>();

kombinert.AddRange(tall);
kombinert.AddRange(resultat);

Console.WriteLine("Kombinert liste: " + string.Join(", ", kombinert));

Console.WriteLine("Resultat liste: " + string.Join(", ", resultat));

for(int i = 0; i < 2; i++)
{
    kombinert.RemoveAt(kombinert.Count - 1);  
}
Console.WriteLine("Liste etter fjerning: " + string.Join(", ", kombinert));

List<string> navnListe = new List<string>();
Console.WriteLine("Skriv inn 4 navn");

for (int i = 0; i < 4; i++)
{
    string? navn = Console.ReadLine();
    navnListe.Add(navn);
}


string? mittNavn = "Albin";

if (navnListe.Contains(mittNavn))
{
    Console.WriteLine("Du husket meg!");
} else {
    Console.WriteLine("Du glemte meg :C");
}