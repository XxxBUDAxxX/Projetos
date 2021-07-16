using System;

namespace Empresa.Utilidades
{
    class Contratos
    {
        public DateTime Date{ get; set; }
        public double ValorPorHora { get; set; }
        public int Horas { get; set; }

        public Contratos() { }

        public Contratos(DateTime date, double valorPorHora, int horas)
        {
            Date = date;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }

        public double TotValor()
        {
            return ValorPorHora * Horas;
        }

    }
}
