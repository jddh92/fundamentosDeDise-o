using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPIOS_SOLID_L
{
    public class Remito 
    {
        public Remito(int numero, DateTime fecha, int bultos) 
        {
            CantBultos = bultos;
            Numero = numero;
            Fecha = fecha;
        }

        public int CantBultos { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get;  set; }

        public string Imprimir()
        {
            return $"Imprimiendo {Descripcion()}";
        }
        public string Descripcion()
        {
            return $"Remito nro {Numero} de fecha {Fecha.ToShortDateString()} con {CantBultos}";
        }
    }
}
