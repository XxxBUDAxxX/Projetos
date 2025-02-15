﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Impostos.Utilidades
{
    abstract class Contribuinte
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }


        public Contribuinte(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double Imposto();
        
    }
}
