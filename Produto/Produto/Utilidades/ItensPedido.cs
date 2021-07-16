using System;
using System.Collections.Generic;
using System.Text;

namespace Produto.Utilidades
{
    class ItensPedido
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produtos Produto { get; set; }

        public ItensPedido() { }

        public ItensPedido(int quantidade, double preco, Produtos produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }
        public double Sub_Total()
        {
            return Preco * Quantidade;
        }
        public override string ToString()
        {
            return $"Produto: {Produto.Nome}\nQuantidade: {Quantidade}\nPreço unitario: {Produto.Preco}\nSub Total: {Sub_Total().ToString("f2")}";
              
        }
    }
}
