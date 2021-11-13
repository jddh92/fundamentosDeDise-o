using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPIOS_SOLID_D
{
    public class FacturaLuz : Impuesto
    {
        public FacturaLuz(double importe, string codigoPago) : base(importe)
        {
            CodigoPago = codigoPago;
        }

        public string CodigoPago { get;  set; }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo factura de luz con código:  {CodigoPago} ");
        }
    }
}
