static void billett(int age, string? name) // funksjon som tar inn age og name som parametere
{
    // Kode for å hente navn og alder som input, men bruker ikke det når jeg skal teste programmet med forskjellige parametere.
    
    /*Console.WriteLine("Skriv inn navnet ditt: ");
    name = Console.ReadLine();

    Console.WriteLine("Skriv inn alderen din: ");
    age = Convert.ToInt32(Console.ReadLine());*/

    // initialiserer en billettpris variabel
    int billettpris = 0;


    // sjekker om alder matcher med spesifike kriterer, og setter billettpris til riktig verdi
    switch (age)
    {
        case <= 17:
            billettpris = 30;
            break;

        case >= 63:
            billettpris = 35;
            break;

        case > 17 and < 63:
            billettpris = 50;
            break;
    }

    // printer ut billettprisen
    Console.WriteLine($"Hei, {name}. Din billettpris er {billettpris}kr.");
}

billett(15,"Test");
billett(31, "Test");
billett(63, "Test");

