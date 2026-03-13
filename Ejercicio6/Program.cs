double Farenheit(double celsius)
{
    return (celsius * 9 / 5) + 32;
}
 void ingcelsius()
{
    Console.WriteLine("Ingrese la temperatura en grados Celsius: ");
}

ingcelsius();
double celsius = double.Parse(Console.ReadLine());

Console.WriteLine("Farenheit: " + Farenheit(celsius));
