using System;
using System.Collections.Generic;
using System.Text;

namespace PRIMEIRO
{
    class Class1
    {
        Banco conta;
        Console.Write("Entre com npumero da conta: ");
            int numero = int.Parse(Console.ReadLine());
        Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
        Console.Write("haverá depósito inicial [S/N]? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Qual o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
        conta = new Banco(numero, titular, depositoInicial);
    }
            else
            {
                conta = new Banco(numero, titular);
}
    }
}
