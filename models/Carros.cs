using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova26_02.models
{
    internal class Carros:Veiculos
    {
        public int qtdPortas;
        public string tamanhoBagageiro;

        public override double CalcularValorAluguel(int qtdDias)
        {
            if (qtdDias > 7)
            {
                double v = _valorDiarioAluguel -(_valorDiarioAluguel * 0.10);
                v = _valorDiarioAluguel * qtdDias;
                return v;
            }
            else
            {
                _valorDiarioAluguel = _valorDiarioAluguel * qtdDias;
                return _valorDiarioAluguel;
            }
        }
    }
}
