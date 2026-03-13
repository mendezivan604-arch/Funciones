int Cubo(int a)
{
    return a * a * a;
}

void ingnumero()
{
    Console.WriteLine("Ingrese un numero: ");
}
ingnumero();
int numero = int.Parse(Console.ReadLine());

Console.WriteLine("El cubo es: " + Cubo(numero));
