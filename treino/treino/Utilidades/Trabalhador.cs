using System.Collections.Generic;
using Empresa.Utilidades.Enums;

namespace Empresa.Utilidades
{
    class Trabalhador
    {
        public string Nome { get; set; }
        public LevelTrabalhador Level { get; set; }
        public double BaseSalario { get; set; }
        public  Departamento Departamento { get; set; }
        public List<Contratos> Contrato { get; set; } = new List<Contratos>();

        public Trabalhador() { }
        public Trabalhador(string nome, LevelTrabalhador level, double baseSalario, Departamento departamento)
        {
            Nome = nome;
            Level = level;
            BaseSalario = baseSalario;
            Departamento = departamento;
        }

        public void AddContrato(Contratos contratato)
        {
            Contrato.Add(contratato);
        }

        public void RemoverContrato(Contratos contrato)
        {
            Contrato.Remove(contrato);
        }
        public double Ganhos(int mes, int ano)
        {
            double soma = BaseSalario;
            foreach (Contratos mesAnoContrato in Contrato)
            {
                if (mesAnoContrato.Date.Month == mes && mesAnoContrato.Date.Year == ano)
                {
                    soma += mesAnoContrato.TotValor();
                }
            }
            return soma;
        }

    }


}
