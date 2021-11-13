using System;

namespace PRINCIPIOS_SOLID_L
{
    class Program
    {
        static void Main(string[] args)
        {
            Impresora impresora = new Impresora();
            Remito rto = new Remito(4535, DateTime.Now, 45);
            Factura fc = new Factura(12334, DateTime.Now);
            NotaCredito nc = new NotaCredito(456, DateTime.Now);

            impresora.ImprimirRemito(rto);
            impresora.Imprimir(fc);
            impresora.Imprimir(nc);
            Console.ReadKey();
        }
    }
}
