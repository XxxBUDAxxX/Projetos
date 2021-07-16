using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroConta = 000000;
            string titular = "Teste";
            double saldo = 0;
            
            Console.Write("Número da conta: ");
            numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Nome do titular da conta: ");
            titular = Console.ReadLine();
            Console.Write("Vai ter depósito inicial [S/N] ?");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Informe o valor do depósito: ");
                saldo = double.Parse(Console.ReadLine());
            }            
            Banco conta = new Banco(numeroConta, titular, saldo);
            Console.WriteLine(conta);
            Console.Write("Informe o valor do depósito: ");
            conta.deposito(double.Parse(Console.ReadLine()));
            Console.WriteLine(conta);
            Console.Write("Informe o valor do saque: ");
            conta.saque(double.Parse(Console.ReadLine()));
            Console.WriteLine(conta);
        }
    }
}
