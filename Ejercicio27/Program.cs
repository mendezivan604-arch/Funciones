void PrecioConDescuento()
{
    Console.WriteLine("Ingrese el precio del producto: Q");
    double precio = double.Parse(Console.ReadLine());

    double descuento = precio * 0.10;
    double precioFinal = precio - descuento;

    Console.WriteLine("El precio con descuento del 10% es: Q" + precioFinal);
}

PrecioConDescuento();
