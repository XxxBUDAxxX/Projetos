using System;
using System.Collections.Generic;
using System.Text;

namespace Produto.Utilidades
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public  DateTime DataNascimento{ get; set; }

        public Cliente(string nome, string email, DateTime dataNascimento)
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
        }

        public override string ToString()
        {
            return $"=====================================\n" +
                $"DADOS DO CLIENTE\n" +
                $"=====================================\n" +
                $"Nome: {Nome}\nE-mail: {Email}\nData de nascimento: {DataNascimento}" +
                $"\n=====================================";
        }
    }
}
