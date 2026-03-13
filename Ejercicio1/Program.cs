double Suma(double a, double b)
{
    return a + b;
}
void numero()
{
    Console.WriteLine("Ingrese un numero: ");
}

numero();
double num1 = double.Parse(Console.ReadLine());
numero();
double num2 = double.Parse(Console.ReadLine());

Console.WriteLine("La suma es: " + Suma(num1, num2));


