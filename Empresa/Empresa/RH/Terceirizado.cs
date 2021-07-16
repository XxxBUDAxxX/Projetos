namespace Empresa.RH
{
    class Terceirizado : Funcionario
    {
        public double Despesas { get; set; }

        public Terceirizado() { }

        public Terceirizado(string nome, int hora, double salarioHora, double despesas) : base(nome, hora, salarioHora)
        {
            Despesas = despesas;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + Despesas * 110 / 100;
        }

        public override string ToString()
        {
            return $"Salario = R${Pagamento():f2}. ";
        }
    }
}
