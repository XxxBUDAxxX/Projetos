using System;
using System.Collections.Generic;
using System.Text;

namespace PRIMEIRO
{
    class Banco
    {
        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Banco(int numeroconta, string titular)
        {
            NumeroConta = numeroconta;
            Titular = titular;
        }
         public Banco(int numeroconta, string titular, double saldo) : this (numeroconta, titular)
        {
            Saldo = saldo;
        }
        public override string ToString()
        {
            return "conta" + NumeroConta + ", Titúlar: " + Titular + ", Saldo: R$ " + Saldo.ToString("f2";
        }
    }


}
