int Mensaje(int edad)
{
    Console.WriteLine("Tiene " + edad + " años");
    return edad;
}

Console.WriteLine("Ingrese su edad: ");
int edad = int.Parse(Console.ReadLine());
Mensaje(edad);