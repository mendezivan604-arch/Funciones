void AreaRectangulo()
{
    Console.WriteLine("Ingrese la base del rectángulo: ");
    double baseRectangulo = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese la altura del rectángulo: ");
    double altura = double.Parse(Console.ReadLine());

    double area = baseRectangulo * altura;

    Console.WriteLine("El área del rectángulo es: " + area);
}

AreaRectangulo();
