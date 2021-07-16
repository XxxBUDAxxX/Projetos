using System;
using Empresa.Utilidades.Enums;
using Empresa.Utilidades;

namespace Course
{
    class Empresa
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o nome: ");
            string nome = Console.ReadLine();
            Console.Write($"Informe o derpatamento do {nome}: ");
            string dep = Console.ReadLine();
            Console.Write($"Informe o level do {nome} [Junior, MidLevel, Senior]: ");
            LevelTrabalhador level = Enum.Parse<LevelTrabalhador>(Console.ReadLine().Trim());
            Console.Write($"Informe o salario base do {nome}: ");
            double salarioBase = double.Parse(Console.ReadLine());
            Console.Write($"Informe quantos contratos {nome} tem: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("=========================================");

            Departamento deper = new Departamento(dep);
            Trabalhador dados = new Trabalhador(nome, level, salarioBase, deper);

            for (int i = 0; i < n; i++)
            {   
                Console.WriteLine($"Contrato #{i+1}");
                Console.Write($"Data [DD/MM/AAAA]: ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write($"Valor por hora: ");
                double valor = double.Parse(Console.ReadLine());
                Console.Write($"Duraçao em horas: ");
                int hora = int.Parse(Console.ReadLine());

                Console.WriteLine("=========================================");
                Contratos cont = new Contratos(data, valor, hora);
                dados.AddContrato(cont);
            }
            Console.Write($"Informe o mes e ano para saber quanto {nome} ganhou: [MM/AAAA]: ");
            string mesAno = Console.ReadLine();
            int mes = int.Parse(mesAno.Substring(0, 2));
            int ano = int.Parse(mesAno.Substring(3));
            Console.WriteLine("=========================================");
            Console.WriteLine($"Nome: {dados.Nome}\nDepartamento: {dados.Departamento.Nome}\nGanhos em {mesAno}:" +
                $"  {dados.Ganhos(mes, ano).ToString("f2")}");
            Console.WriteLine("=========================================");
        }
    }
}
