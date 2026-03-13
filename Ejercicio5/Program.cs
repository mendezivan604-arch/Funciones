double AreaRectangulo(double vase, double altura)
{
    return vase * altura;
}

Console.WriteLine("Ingrese base del rectángulo: ");
double vase = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese altura del rectángulo: ");
double altura = double.Parse(Console.ReadLine());

Console.WriteLine("El área del rectángulo es: " + AreaRectangulo(vase, altura));