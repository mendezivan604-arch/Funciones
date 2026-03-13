double AreaTriangulo(double baseTriangulo, double altura)
{
    return (baseTriangulo * altura) / 2;
}
Console.WriteLine("Ingrese base del triángulo: ");
double baseTriangulo = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese altura del triángulo: ");
double altura = double.Parse(Console.ReadLine());

Console.WriteLine("Área del triángulo: " + AreaTriangulo(baseTriangulo, altura));