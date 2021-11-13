using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPIOS_SOLID_O
{
    class NotaCredito : DocumentoContable
    {
        public NotaCredito(int numero) : base(numero)
        { 
        }

        public override string Descripcion()
        {
            return $"NC - {Numero}";
        }
    }
}
