using System;
using System.Collections.Generic;
using System.Text;


namespace Impostos.Utilidades
{
    class Fisica : Contribuinte
    {
        public double Saude { get; set; }

        public Fisica(string nome, double rendaAnual, double saude) : base(nome, rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
            Saude = saude;
        }
        double tot = 0;
        public override double Imposto()
        {
            if (RendaAnual >= 20000)
            {
                if (Saude != 0 && Saude != null)
                {
                    tot = (RendaAnual * 25 / 100) - (Saude * 50 / 100);
                }
                else
                {
                    tot = RendaAnual * 25 / 100;
                }
            }
            else
            { 
                if(Saude != 0 && Saude != null)
                {
                    tot = (RendaAnual * 25 / 100) - (Saude * 50 / 100);
                }
                else
                {
                    tot = RendaAnual * 25 / 100;
                }
            }
            return tot;
        }
    }
}
