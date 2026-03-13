double PromedioFinal(string nombre, double nota1, double nota2, double nota3)
{
    return (nota1 + nota2 + nota3) / 3;
}

Console.WriteLine("Ingrese el nombre del estudiante: ");
string nombre = Console.ReadLine();

Console.WriteLine("Ingrese la primera calificación: ");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la segunda calificación: ");
double nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la tercera calificación: ");
double nota3 = double.Parse(Console.ReadLine());

Console.WriteLine("El promedio final de " + nombre + " es: " + PromedioFinal(nombre, nota1, nota2, nota3));
