using System;
using System.Collections.Generic;
using System.Text;

namespace Impostos.Utilidades
{
    class Juridica : Contribuinte
    {
        public int Funcionario { get; set; }

        public Juridica(string nome, double RendaAnual, int funcionario) : base(nome, RendaAnual)
        {
            Nome = nome;
            RendaAnual = RendaAnual;
            Funcionario = funcionario;
        }
        double tot = 0;
        public override double Imposto()
        {
            if (Funcionario > 10 )
            {
                tot = (RendaAnual * 14 / 100);
            }
            else
            { 
                tot = (RendaAnual * 16 / 100);
            }
            return tot;
        }
    }
}
