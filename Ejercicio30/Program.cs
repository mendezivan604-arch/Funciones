void ReporteEstudiante()
{
    Console.WriteLine("Ingrese el nombre del estudiante: ");
    string nombre = Console.ReadLine();

    Console.WriteLine("Ingrese el curso: ");
    string curso = Console.ReadLine();

    Console.WriteLine("Ingrese la primera calificación: ");
    double nota1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese la segunda calificación: ");
    double nota2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese la tercera calificación: ");
    double nota3 = double.Parse(Console.ReadLine());

    Console.WriteLine("REPORTE DEL ESTUDIANTE");
    Console.WriteLine("Nombre: " + nombre);
    Console.WriteLine("Curso: " + curso);
    Console.WriteLine("Calificación 1: " + nota1);
    Console.WriteLine("Calificación 2: " + nota2);
    Console.WriteLine("Calificación 3: " + nota3);
}

ReporteEstudiante();
