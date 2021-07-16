using System;
using System.Collections.Generic;
using System.Text;

namespace Produto.Utilidades
{
    class Produtos
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produtos() { }
        public Produtos(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
