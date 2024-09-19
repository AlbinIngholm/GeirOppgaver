int input=1;
int minSum = 0;

List<int> liste = new List<int>(); // initialiserer en ny liste

while (input != 0) // når input ikke er 0
{
    Console.WriteLine("Skriv inn tall");
    input = int.Parse(Console.ReadLine()); // ber om input og konverterer til int
    
    if (input != 0) // sjekker at input ikke er null
    {
        liste.Add(input); // appender input til lista
    }
}

for(int i = 0; i < liste.Count; i++) // looper gjennom lista og skriver ut hver indeks
{
    Console.WriteLine(liste[i]);
}


for (int i = 0; i < liste.Count; i++) // looper gjennom lista og adderer til summen for hver indeks
{
    minSum += liste[i];
}
Console.WriteLine($"Sum av tall: {minSum}"); // skriver ut


int min = liste[0]; // initialiserer en variabel for minste tall, antar at første indeks er minst
for (int i = 1;i < liste.Count; i++) // looper gjennom lista
{
    if (liste[i] < min) // hvis min er større enn indeks, oppdatert min til indeksen
    {
        min = liste[i];
    }
}
Console.WriteLine($"Det minste tallet er {min}"); 

int max = 0; // initialiserer en variabel for største tall, antar at største tall er 0 til å begynne med
for (int i = 0; i < liste.Count; i++) // looper gjennom lista
{
    if (liste[i] > max) // hvis indeks er større enn max
    {
        max = liste[i]; // oppdatert max til indeks
    }
}
Console.WriteLine($"Det største tallet er {max}");