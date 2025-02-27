
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova26_02.models
{
    internal class Alugueis
    {
        public Veiculos veiculo = new Veiculos();
        public DateTime _dataInicio;
        public DateTime _dataFim;
        public int totalDias;
        public double valorTotalAluguel;
        
        public Alugueis()
        {
            int TotalDias = (_dataFim - _dataInicio).Days + 1;
            double valorTotal = veiculo.CalcularValorAluguel(TotalDias);
            
        }
        public double CalcularAluguel(Veiculos v1, DateTime dataInicio, DateTime dataFim)
        {
            double valorTotalAluguel;
            int TotalDias = (dataFim - dataInicio).Days + 1;

            if (v1._valorDiarioAluguel >= 0)
            {
                valorTotalAluguel = v1._valorDiarioAluguel * TotalDias;
            }
            else
            {
                throw new Exception("Valor de cálculo inválido, revise as informações informadas");
            }


            return valorTotalAluguel;
        }
    }
}
