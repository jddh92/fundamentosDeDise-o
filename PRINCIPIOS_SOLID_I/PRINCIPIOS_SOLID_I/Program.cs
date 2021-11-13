using System;

namespace PRINCIPIOS_SOLID_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura factura = new Factura(57649, DateTime.Now);
            factura.CAI = "12345678";

            FacturaElectronica facturaElectronica = new FacturaElectronica(32414, DateTime.Now);
            facturaElectronica.CAE = "1032447";

            facturaElectronica.Imprimir();
            facturaElectronica.EnviarporEmail();
            factura.Imprimir();
            


            Console.ReadKey();                

        }
    }
}
