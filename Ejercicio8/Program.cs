double Promedio(double num1, double num2, double num3)
{
    return (num1 + num2 + num3) / 3;
}
void numero()
{
    Console.WriteLine("Ingrese un numero: ");
}

numero();
double num1 = double.Parse(Console.ReadLine());
numero();
double num2 = double.Parse(Console.ReadLine());
numero();
double num3 = double.Parse(Console.ReadLine());

Console.WriteLine("Promedio: " + Promedio(num1, num2, num3));

