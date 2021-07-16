using System;
using System.Collections.Generic;
using System.Text;

namespace PRIMEIRO
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcento)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcento / 100);
        }
        public override string ToString()
        {
            return ($"{Nome}, R$ {SalarioLiquido().ToString("f2")}");
        }

    }
}
