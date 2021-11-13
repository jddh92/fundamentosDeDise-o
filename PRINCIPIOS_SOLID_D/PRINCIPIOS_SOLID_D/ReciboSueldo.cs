using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPIOS_SOLID_D
{
    public class ReciboSueldo : IImprimible
    {
        public ReciboSueldo(int legajo, double total)
        {
            Legajo = legajo;
            Total = total;
        }

        public int Legajo { get;  set; }
        public double Total { get;  set; }

        public void Imprimir()
        {
            Console.WriteLine($"Imprimineto recibo de sueldo por  {Legajo} por un total de {Total}");
        }
    }
}
