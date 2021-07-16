using System;
namespace vetores
{
    class Hotel
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }

        public Hotel(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        public void Reserva(string[] lista, int numquarto, string nome, string email)
        {   
            Console.Write("Informe qual quarto será reservado: ");
            int numQuarto = int.Parse(Console.ReadLine());
            if (lista[numQuarto] == null)
            {
                Console.Write("Informe o nome do locatário: ");
                nome = Console.ReadLine();
                Console.Write($"Informe E-mail do {nome}: ");
                email = Console.ReadLine();
                //lista[numquarto] = Hotel(nome, email);
            }
            else
            {
                bool j = true;
                while (j == true)
                {
                    Console.Write("Quarto já reservado favor escolher outro! ");
                    Console.Write("Informe o nome do locatário: ");
                    nome = Console.ReadLine();
                    Console.Write($"Informe E-mail do {nome}: ");
                    email = Console.ReadLine();
                    //lista[numquarto] = ;
                    if (lista[numQuarto] == null)
                    {
                        j = false;
                    }
                }
            }
        }



        public override string ToString()
        {
            return Nome + Email;
        }
    }
}