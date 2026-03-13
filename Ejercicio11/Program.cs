double Libras(double kg)
{
    return kg * 2.20462;
}

void ingkg()
{
    Console.WriteLine("Ingrese el peso en kg: ");
}

ingkg();
double kg = double.Parse(Console.ReadLine());

Console.WriteLine("Libras: " + Libras(kg));
