double SalarioTotal(int diasTrabajados, double pagoDiario)
{
    return diasTrabajados * pagoDiario;
}

Console.WriteLine("Ingrese la cantidad de días trabajados: ");
int diasTrabajados = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el pago diario: Q");
double pagoDiario = double.Parse(Console.ReadLine());

Console.WriteLine("El salario total del empleado es: Q" + SalarioTotal(diasTrabajados, pagoDiario));