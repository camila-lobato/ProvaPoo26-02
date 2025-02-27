using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova26_02.models
{
    internal class Veiculos
    {
        public int idVeiculo;
        public string descricao;
        public string nomeMarca;
        public string anoFabricacao;
        public double _valorDiarioAluguel;
        public virtual double CalcularValorAluguel(int qtdDias)
        {
            _valorDiarioAluguel = _valorDiarioAluguel * qtdDias;
            return _valorDiarioAluguel;
        }
    }
}
