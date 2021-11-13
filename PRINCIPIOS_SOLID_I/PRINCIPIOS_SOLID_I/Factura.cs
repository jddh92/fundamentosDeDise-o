using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPIOS_SOLID_I
{
    class Factura : Documento
    {
        public Factura(int numero, DateTime fecha) : base(numero, fecha) 
        {

        }
        public string CAI { get; set; }
        
        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo por email la factura {Numero} del día {Fecha.ToShortDateString()}");
        }
    }
}
