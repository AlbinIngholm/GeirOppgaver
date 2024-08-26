Console.Write("Programmet ber om og leser inn to datoer, angitt med heltall for dag (1-31) og måned (1-12). Programmet sjekker hvilken av" +
    " datoene som kommer først i året.");

Console.WriteLine("Skriv inn dagen i måneden (1-31)");
int dag1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Skriv inn måneden (1-12)");
int måned1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Skriv inn dagen i ny måned (1-31)");
int dag2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Skriv inn måneden (1-12)");
int måned2 = Convert.ToInt32(Console.ReadLine());

DateTime dato1 = new DateTime(1, måned1, dag1);
DateTime dato2 = new DateTime(1, måned2, dag2);

if (dato1.Equals(dato2))
{
    Console.Write("Samme dato!");
} else if (dato1 < dato2)
{
    Console.WriteLine("Riktig rekkefølge!");
} else if (dato2 < dato1)
{
    Console.WriteLine("Feil rekkefølge!");
} else
{
    Console.Write("Feil.");
}