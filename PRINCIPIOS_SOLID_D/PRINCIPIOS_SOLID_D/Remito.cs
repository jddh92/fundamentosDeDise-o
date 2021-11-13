using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPIOS_SOLID_D
{
    public class Remito : IImprimible
    {
        public Remito(int numero, DateTime fecha, int cantBultos)
        {
            Numero = numero;
            Fecha = fecha;
            CantBultos = cantBultos;
        }

        public int Numero { get; set; }
        public DateTime Fecha { get; private set; }
        public int CantBultos { get; private set; }

        public void Imprimir()
        {
            Console.WriteLine($"Imprimineto remito número {Numero} con fecha de {Fecha} por una cantidad de {CantBultos}");
        }
    }
}
