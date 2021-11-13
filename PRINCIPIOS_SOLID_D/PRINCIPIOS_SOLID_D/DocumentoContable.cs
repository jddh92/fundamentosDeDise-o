using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPIOS_SOLID_D
{
    public abstract class DocumentoContable : IImprimible
    {
        protected string _sigla;
        public DocumentoContable(int numero, DateTime fecha, double importe)
        {
            Numero = numero;
            Fecha = fecha;
            Importe = importe;
        }

        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public double Importe { get; set; }

        public abstract void Imprimir();           
        

        public abstract double Total();
    }
}
