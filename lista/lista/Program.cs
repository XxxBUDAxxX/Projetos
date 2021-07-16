using System;
using System.Collections.Generic;

namespace lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionarios> dados = new List<Funcionarios>();
            Console.Write("Quanto funcionarios serar cadastrados: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Dados funcionario {i+1}");
                Console.Write($"ID: ");
                int id = int.Parse(Console.ReadLine());
                
                Console.Write($"Nome: ");
                string nome = Console.ReadLine();
                Console.Write($"Salario: ");
                double salario = double.Parse(Console.ReadLine());
                dados.Add(new Funcionarios(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Informe o Id que tera o salario almentado: ");
            int idAumento = int.Parse(Console.ReadLine());
            Funcionarios aumentoId = dados.Find(x => x.Id == idAumento);
            if (aumentoId != null)
            {
                Console.Write("Informe a porcentagem de aumento: ");
                double porcento = double.Parse(Console.ReadLine());
                aumentoId.Aumento(porcento);
            }
            else
            {
                Console.Write("Id não localizado!");
            }
            foreach(Funcionarios obj in dados)
            {
                Console.WriteLine(obj);
                Console.WriteLine();
            }
            
        }
    }
}
