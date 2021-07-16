using System;
using System.Collections.Generic;
using System.Text;

namespace Curso
{
    class Banco
    {
        public string NomeTitular;
        public int _numeroConta { get; private set; }
        
        public double _saldo { get; private set; }

        public Banco(int numeroDaConta, string nomeTituloar, double saldo)
        {
            NomeTitular = nomeTituloar;
            _numeroConta = numeroDaConta;
            _saldo = saldo;
        }

        public void deposito(double saldo)
        {
            if (saldo > 0)
            {
                _saldo += saldo;
            }
        }
        public void saque(double saldo)
        {
            if (_saldo >= saldo + 5)
            {
                _saldo -= saldo + 5;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }
        public override string ToString()
        {
            return $"---------------------------------\n" +
                $"Dados da conta: Conta {_numeroConta}\nTitular:{NomeTitular}\nSaldo: R${_saldo.ToString("f2")}\n " +
                $"---------------------------------------";
        }
    }
}
