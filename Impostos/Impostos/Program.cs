using System;
using Impostos.Utilidades;
using System.Collections.Generic;

namespace Impostos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos contribuinte tera ");
            int n = int.Parse(Console.ReadLine());

            List<Contribuinte> dados = new List<Contribuinte>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Dados do {i+1}ª contribuinte");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda anual: ");
                double renda = double.Parse(Console.ReadLine());
                Console.Write("Pessoa Fisica ou Juridica [F/J]: ");
                char resp = char.Parse(Console.ReadLine().ToUpper());
                if (resp == 'F')
                {
                    Console.Write("Gastos médicos: ");
                    double medico = double.Parse(Console.ReadLine());
                    dados.Add(new Fisica(nome, renda, medico));
                }
                else if (resp == 'J')
                {
                    Console.Write("Quantos funcionarios tem na empresa: ");
                    int func = int.Parse(Console.ReadLine());
                    dados.Add(new Juridica(nome, renda, func));
                }
                else
                {
                    Console.Write("erro!!! tipo d epessoa não indentificada: ");
                    i -= 1;
                }
            }
            Console.WriteLine("=======================");
            Console.WriteLine("        RESULTADO");
            Console.WriteLine("=======================");
            double soma = 0;
            foreach (Contribuinte iten in dados)
            {
                Console.WriteLine($"Nome = {iten.Nome}\nInposto = {iten.Imposto()}");
                soma += iten.Imposto();
                Console.WriteLine("=======================");
            }
            Console.WriteLine($"Total taxa = {soma}");
        }
    }
}
