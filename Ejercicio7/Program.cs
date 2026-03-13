double PrecioFinal(double precio, double descuento)
{
    return precio - (precio * (descuento / 100));
}
Console.WriteLine("Ingrese el precio: ");
double precio = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el descuento: %");
double descuento = double.Parse(Console.ReadLine());

Console.WriteLine("Precio final: " + PrecioFinal(precio, descuento));
