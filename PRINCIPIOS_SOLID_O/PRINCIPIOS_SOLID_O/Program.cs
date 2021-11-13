using System;

namespace PRINCIPIOS_SOLID_O
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentoContable factura = new Factura(103244);
            DocumentoContable notaCredito = new NotaCredito(7980);
            Console.WriteLine(factura.Descripcion());
            Console.WriteLine(notaCredito.Descripcion());
            Console.ReadKey();
        }
    }
}
