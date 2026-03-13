void AreaCirculo()
{
    Console.WriteLine("Ingrese el radio del círculo: ");
    double radio = double.Parse(Console.ReadLine());

    double area = 3.1416 * (radio * radio);

    Console.WriteLine("El área del círculo es: " + area);
}

AreaCirculo();
