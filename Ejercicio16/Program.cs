double Horas(double minutos)
{
    return minutos / 60;
}
Console.WriteLine("Ingrese minutos: ");
double minutos = double.Parse(Console.ReadLine());

Console.WriteLine("Horas: " + Horas(minutos));
