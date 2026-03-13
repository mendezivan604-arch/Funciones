void ingnumero()
{
    Console.WriteLine("Ingrese un numero: ");
}
ingnumero();
int numero = int.Parse(Console.ReadLine());
ingnumero();
int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine("La suma es: " + (numero + numero2));
