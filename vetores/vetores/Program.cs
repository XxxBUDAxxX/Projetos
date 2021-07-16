using System;

namespace vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel[] quarto = new Hotel[10];
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Informe qual quarto será reservado: ");
                int numQuarto = int.Parse(Console.ReadLine());
                if (quarto[numQuarto] == null)
                {
                    Console.Write("Informe o nome do locatário: ");
                    string nome = Console.ReadLine();
                    Console.Write($"Informe E-mail do {nome}: ");
                    string email = Console.ReadLine();
                    quarto[numQuarto] = new Hotel(nome, email);
                }
                else
                {
                    bool j = true;
                    while (j == true)
                    {
                        Console.WriteLine("Quarto já reservado favor escolher outro! ");
                        Console.Write("Informe qual quarto será reservado: ");
                        numQuarto = int.Parse(Console.ReadLine());
                        if (quarto[numQuarto] == null)
                        {
                            Console.Write("Informe o nome do locatário: ");
                            string nome = Console.ReadLine();
                            Console.Write($"Informe E-mail do {nome}: ");
                            string email = Console.ReadLine();
                            quarto[numQuarto] = new Hotel(nome, email);
                            j = false;
                        }
                    }
                        

                }
                
            }
            for (int i = 0; i < 10; i++)
            {
                if (quarto[i] != null)
                {
                    Console.WriteLine($"{i} : {quarto[i]}");       
                }
            }
        }
    }
}
