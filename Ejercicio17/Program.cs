double PromedioGrupo(int cantidadEstudiantes)
{
    double sumaNotas = 0;

    for (int i = 0; i < cantidadEstudiantes; i++)
    {
        Console.WriteLine("Ingrese la nota del estudiante " + (i + 1) + ": ");
        double nota = double.Parse(Console.ReadLine());
        sumaNotas += nota;
    }

    return sumaNotas / cantidadEstudiantes;
}

Console.WriteLine("Ingrese la cantidad de estudiantes: ");
int cantidadEstudiantes = int.Parse(Console.ReadLine());

Console.WriteLine("El promedio del grupo es: " + PromedioGrupo(cantidadEstudiantes));
