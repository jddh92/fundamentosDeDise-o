﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPIOS_SOLID_D
{
    public class Municipal : Impuesto
    {
        public Municipal(double importe, string partida) : base(importe)
        {
            Partida = partida;
        }

        public string Partida { get; set; }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo impuesto municipal {Partida} por un importe de {Importe}");
        }
    }
}
