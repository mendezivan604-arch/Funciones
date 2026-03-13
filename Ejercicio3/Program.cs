int Doble (int a)
{
    return a * 2;
}
void ingnumero()
{
    Console.WriteLine("Ingrese un numero: ");
}

ingnumero();
int numero = int.Parse(Console.ReadLine());

Console.WriteLine("El doble es: " + Doble(numero));
