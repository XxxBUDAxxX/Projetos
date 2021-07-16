using System;
using System.Collections.Generic;
using Empresa.RH;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> dados = new List<Funcionario>();

            Console.Write("Quantos funcionarios vão ser cadastrados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"==========FUNCIONARIO #{i+1}==========");
                Console.Write($"Informe o nome: ");
                string nome = Console.ReadLine().Trim();
                Console.Write($"Horas trabalhadas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write($"Valor por hora: ");
                double salarioHora = double.Parse(Console.ReadLine());
                Console.Write($"Funcionario {nome} e terceirizado [S/N]: ");
                char resp = char.Parse(Console.ReadLine().Trim().ToUpper());
                if (resp == 'S')
                {
                    Console.Write($"Despesas adicional de {nome}: ");
                    double despesas = double.Parse(Console.ReadLine());
                    dados.Add(new Terceirizado(nome, horas, salarioHora, despesas));
                }
                else
                {
                    dados.Add(new Funcionario(nome, horas, salarioHora));
                }
            }
            Console.WriteLine($"==========PAGAMENTOS==========");
            foreach (Funcionario iten in dados)
            {
                Console.WriteLine($"Nome = {iten.Nome}\nSalario = {iten.Pagamento():f2}");
            }
        }
    }
}
