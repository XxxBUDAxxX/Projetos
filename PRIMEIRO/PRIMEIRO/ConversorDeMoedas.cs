

namespace PRIMEIRO
{
    class ConversorDeMoedas
    {
        public static double DolaParaReal(double cotacao, double quantia)
        {
            return ((quantia* cotacao)* 6 / 100) + (quantia* cotacao);
        }
    }
}


