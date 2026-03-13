double AreaCirculo(double radio)
{
    return 3.1416 * (radio * radio);
}
void ingradio()
{
    Console.WriteLine("Ingrese el radio del circulo: ");
}

ingradio();
double radio = double.Parse(Console.ReadLine());

Console.WriteLine("El área del circulo es: " + AreaCirculo(radio));

