using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova26_02.models
{
    internal class Motos:Veiculos
    {
        public string cilindradas;
        public bool partidaEletrica;
        public double peso;
        public double capacidadeTanque;

        public override double CalcularValorAluguel(int qtdDias)
        {

            if (qtdDias > 5)
            {
                _valorDiarioAluguel = _valorDiarioAluguel - (_valorDiarioAluguel * 0.15);
                _valorDiarioAluguel = _valorDiarioAluguel * qtdDias;
                return _valorDiarioAluguel;
            }
            else
            {


                _valorDiarioAluguel = _valorDiarioAluguel * qtdDias;
                return _valorDiarioAluguel;
            }



        }
    }
}
