using System;
using System.Collections.Generic;
using Produto.Utilidades.Enums;
using System.Text;

namespace Produto.Utilidades
{
    class Pedidos
    {
        public DateTime Momento { get; set; }
        public StatusPedido Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItensPedido> Itens { get; set; } = new List<ItensPedido>();

        public Pedidos() { }
        public Pedidos(StatusPedido status, Cliente cliente)
        {
            Momento = DateTime.Now;
            Status = status;
            Cliente = cliente;
        }

        public void AddItem(ItensPedido item)
        {
           Itens.Add(item);
        }

        public void RemoverItem(ItensPedido item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double soma = 0;
            foreach (ItensPedido item in Itens)
            {
                soma += item.Sub_Total();
            }
            return soma;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("            PEDIDO");
            sb.Append($"{Cliente}\n");
            sb.Append($"Pedido feito:{Momento}\nStatus: {Status}");
            foreach (ItensPedido item in Itens)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("\nTotal: R$" + Total().ToString("F2"));
            return sb.ToString();
                
        }


    }
}
