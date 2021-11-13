using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPIOS_SOLID_L
{
    class Impresora
    {
        public void ImprimirRemito(Remito unRemito)
        {
            Console.WriteLine(unRemito.Imprimir());
        }
        public void Imprimir(Documento unaFactura)
        {   
            Console.WriteLine(unaFactura.Imprimir());
        }

    }
}
