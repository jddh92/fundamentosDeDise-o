using System;

namespace PRINCIPIOS_SOLID_D
{
    class Program
    {
        static void Main(string[] args)
        {
            Impresora impresora = new Impresora();

            IImprimible factura = new Factura(1234, DateTime.Now, 303);
            IImprimible notaCredito = new NotaCredito(564, DateTime.Now, 9879);
            IImprimible remito = new Remito(55567, DateTime.Now, 6);
            IImprimible facturaLuz = new FacturaLuz(556, "76543");
            Municipal municipal = new Municipal(9866, "56342346");

            impresora.Imprimir(factura);
            impresora.Imprimir(notaCredito);
            impresora.Imprimir(remito);
            impresora.Imprimir(facturaLuz);
            impresora.Imprimir(municipal);

            Console.ReadKey();
        }
    }
}
