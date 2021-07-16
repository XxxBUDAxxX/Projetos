using System;


namespace Curso
{
    class Produtos
    {
        private string _nome;
        public int Quantidade { get; private set; }
        public double Preco { get; private set; }    // so poderiamos ler o valor de Preco e nao modificar 
        public Produtos(string nome, int _quantidade, double preco) // este bloco e construtor 
        {
            _nome = nome;
            quantidade = _quantidade;
            Preco = preco;
        }
        public string Nome // este bloco e o propiedade onde valido se deve ou nao entrar com o nome 
        {
            get { return _nome; }
            set
            {
                if (value != null || value.Length > 1)  // value seria o valor de Nome onde usariamos no codigo principal
                {
                    _nome = value;
                }
            }
        }
        public int quantidade
        {
            get { return Quantidade; }
            set
            {
                if (value > 0)
                {
                    Quantidade += quantidade;
                }
            }
        }
        public Double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutro(int _quantidade) // void eu mexo diretamente dentro da do valor da variavel quantidade
        {
            quantidade += _quantidade;
        }
        public void RemoverProduto(int _quantidade)
        {
            quantidade -= _quantidade;
        }
        public override string ToString() // aqui usamos a palara override para voltar uma formataçao pre definida usando o ToString
        {
            return $"Nome = {Nome}\nPreço = {Preco}\nQuantidade no estoque = {Quantidade}\nValor total no estoque = {ValorTotalEmEstoque().ToString("f2")}";
        }

                                              /*  PROGRAMA PRINCIPAL*/
        /*  string prodNome = "TV";
            int prodQuantidade = 10;
            double prodPreco = 20;
            
            Produtos prod = new Produtos(prodNome, prodQuantidade, prodPreco);

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");

            prodNome = Console.ReadLine();
            Console.Write("Preço: ");

            prodPreco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");

            prodQuantidade = int.Parse(Console.ReadLine());
            
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: \n"+ prod);*/

    }
}

