using System;

namespace PRINCIPIOS_SOLID_S
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente();
            c.Apellido = "Delgado";
            c.Nombre = "Juan";
            Factura f = new Factura(666, c);

            Item i1 = new Item(new Producto("Lentejas", 20), 5);
            Item i2 = new Item(new Producto("Frijoles", 40), 7);
            Item i3 = new Item(new Producto("Garbanzos", 20), 3);

            f.Items.Add(i1);
            f.Items.Add(i2);
            f.Items.Add(i3);
            Console.WriteLine(f.Total());

            Console.ReadKey();
        }
    }
}
