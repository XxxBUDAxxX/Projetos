using System;
using System.Collections.Generic;
using System.Text;

namespace Funcionario.RH
{
    class Terceirizado : Funcionario
    {
        public double TaxaAdicional { get; set; }

        public Terceirizado() { }

        public Terceirizado(string nome, int hora, double salarioHora, double taxaAdicional) : base(nome, hora, salarioHora)
        {
            TaxaAdicional = taxaAdicional;
        }

        public double Pagamento()
        {
            return (SalarioHora * Hora) + (TaxaAdicional * 110 / 100);
        }

        public override string ToString()
        {
            return $"Salario = R${Pagamento()}. ";
        }
    }
}
