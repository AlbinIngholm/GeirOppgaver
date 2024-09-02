static void microsoftCounter()
{
    int microsoftMoment = 0;

    while (true)
    {
        Console.WriteLine("Har du nylig hatt en Microsoft Moment? y/n");
        string? input = Console.ReadLine();
        if (input == "y")
        {
            microsoftMoment++;
            Console.WriteLine("Tenkte meg det. Antall microsoft moment er nå: " + microsoftMoment);
        }
        else
        {
            microsoftMoment++;
            Console.WriteLine("Umulig. Antall microsoft moment er nå: " + microsoftMoment);
        }
    }
}

microsoftCounter();