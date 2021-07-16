using System;
using System.Collections.Generic;
using System.Text;

namespace lista
{
    class Funcionarios
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        public Funcionarios(int id, string nome, double salario)
        {
            Boolean j = true;
            while (j  == true)
            { 
                if (id != Id)
                {
                    Id = id;
                    j = false;
                }
                

            }
            
            Nome = nome;
            Salario = salario;
        }

        public void Aumento(double porcetagem)
        {
            Salario += Salario * porcetagem / 100;
        }

        public override string ToString()
        {
            return $"Id = {Id}\n" +
                $"Nome = {Nome}\n" +
                $"Salario = {(Salario).ToString("f2")}\n" +
                $"====================";
             

        }

    }
}
