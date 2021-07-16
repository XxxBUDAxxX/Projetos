using System;
using Produto.Utilidades.Enums;
using Produto.Utilidades;
using System.Collections.Generic;
namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos produto = new Produtos();
            ItensPedido pedido = new ItensPedido();
            Console.WriteLine("Informe os dados do cliente");
            Console.Write($"Nome: ");
            string nome = Console.ReadLine().Trim();
            Console.Write($"E-mail do {nome}: ");
            string email = Console.ReadLine().Trim();
            Console.Write($"Data de nascimento do {nome} [DD/MM/AAAA]: ");
            DateTime nascimento = DateTime.Parse(Console.ReadLine().Trim());
            Console.Write($"Informe os dados do pedido:\nPagamento_Pendente = 0\n" +
                $"Processando = 1\nEnviado = 2\nEntregue = 3\nStatus do pedido: ");
            StatusPedido status = Enum.Parse<StatusPedido>(Console.ReadLine());
            Console.Write($"Qunatos produtos diferentes foram comprados por {nome}: ");
            int n = int.Parse(Console.ReadLine());
            Cliente cliente = new Cliente(nome, email, nascimento);
            Pedidos pedidos = new Pedidos(status, cliente);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Informe os dados do intem #{i + 1}");
                Console.Write("Nome do produto: ");
                string nomeProd = Console.ReadLine();
                Console.Write($"Preço do {nomeProd}: ");
                double preco = double.Parse(Console.ReadLine());
                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                produto = new Produtos(nomeProd, preco);
                pedido = new ItensPedido(quantidade, preco, produto);
                pedidos.AddItem(pedido);
            }

             bool j = true;
            while (j == true)
            {
                
                Console.Write("Deseja remover algum produto? ");
                char resp = char.Parse(Console.ReadLine().Trim().ToUpper());
                if (resp == 'S')
                {
                    Console.Write("Informe Qual produto : ");
                    string prod = Console.ReadLine();
                    Console.Write("Informe a quantidade a ser removida: ");
                    int quant = int.Parse(Console.ReadLine());
                    pedidos.RemoverItem(prod);

                        

                    Console.WriteLine(pedidos);
                }
                else
                {
                    j = false;
                }
            }
            Console.WriteLine("PEDIDO FECHADO");
            Console.WriteLine(pedidos);

        }
    }
}
