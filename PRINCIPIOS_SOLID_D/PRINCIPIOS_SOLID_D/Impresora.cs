using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPIOS_SOLID_D
{
    class Impresora
    {
        public void Imprimir(IImprimible imprimible)
        {
            imprimible.Imprimir();
        }     
    }
}
