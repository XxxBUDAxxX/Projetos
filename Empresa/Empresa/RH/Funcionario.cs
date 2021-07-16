namespace Empresa.RH
{
    class Funcionario
    {
        public string Nome { get; set; }
        public int Hora { get; set; }
        public double SalarioHora { get; set; }
        public Funcionario() { }

        public Funcionario(string nome, int hora, double salarioHora)
        {
            Nome = nome;
            Hora = hora;
            SalarioHora = salarioHora;
        }

        public virtual double Pagamento()
        {
            return Hora * SalarioHora;
        }

        public override string ToString()
        {
            return $"Salario = R${Pagamento():f2}. ";
        }
    }
}
