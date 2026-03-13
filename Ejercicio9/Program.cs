double SalarioTotal(double salario, double horas)
{
    return salario * horas;
}

Console.WriteLine("Ingrese el salario por hora: Q");
double salario = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese las horas trabajadas: ");
double horas = double.Parse(Console.ReadLine());

Console.WriteLine("Salario total: Q" + SalarioTotal(salario, horas));
