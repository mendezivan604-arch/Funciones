int Cuadrado(int a)
{
    return a * a;
}
void ingnumero()
{
    Console.WriteLine("Ingrese un numero: ");
}

ingnumero();
int numero = int.Parse(Console.ReadLine());

Console.WriteLine("El cuadrado es: " + Cuadrado(numero));
