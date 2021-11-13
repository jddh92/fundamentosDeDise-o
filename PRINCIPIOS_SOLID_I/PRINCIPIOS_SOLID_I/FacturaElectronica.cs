using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPIOS_SOLID_I
{
    class FacturaElectronica : Documento, IEmailveable
    {
        public FacturaElectronica(int numero, DateTime fecha) : base(numero, fecha)
        { 
        }
        public string CAE { get; set; }

        public void EnviarporEmail()
        {
            Console.WriteLine($"Enviando por Email la factura electrónica {Numero} del día {Fecha.ToShortDateString()}");
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo la factura electrónica {Numero} del día {Fecha.ToShortDateString()}"); 
        }
    }
}
