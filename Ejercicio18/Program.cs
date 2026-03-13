double TotalFactura(double cantidadProductos)
{
    double totalproductos = 0;
    for (int i = 0; i < cantidadProductos; i++)
    {
        Console.WriteLine("Ingrese el precio del producto " + (i + 1) + ": Q");
        double precio = double.Parse(Console.ReadLine());
        totalproductos += precio;
    }

    return totalproductos;
}
Console.WriteLine("Ingrese cantidad de productos: ");
double cantidadProductos = double.Parse(Console.ReadLine());

Console.WriteLine("Total Factura: Q" + TotalFactura(cantidadProductos));
