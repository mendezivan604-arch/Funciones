double Velocidad(double distancia, double tiempo)
{
    return distancia / tiempo;
}
Console.WriteLine("Ingrese distancia recorrida: ");
double distancia = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese tiempo empleado: ");
double tiempo = double.Parse(Console.ReadLine());

Console.WriteLine("Velocidad: " + Velocidad(distancia, tiempo));
