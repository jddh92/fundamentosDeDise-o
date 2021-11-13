using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPIOS_SOLID_I
{
    public abstract class Documento : IImprimible
    {
        public Documento(int numero, DateTime fecha)
        {
            Numero = numero;
            Fecha = fecha;
        }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }

        public abstract void Imprimir();
    }
}
