Console.WriteLine("Skriv inn temperaturen du ønsker å konvertere fra F til C: ");
double input = Convert.ToInt32(Console.ReadLine());

double celsius = FtoC(input);
Console.WriteLine("Temperatur i Celsius: " + celsius);  
static double FtoC(double F)
{
    Console.Write("\nTemperatur i Fahrenheit: "+F);
    double C = (F - 32) * 5 / 9;
    return C;
}
