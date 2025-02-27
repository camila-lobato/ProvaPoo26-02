using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova26_02.models
{
    internal class Caminhoes:Veiculos
    {
        public int qtdEixos;
        public int capacidadeCarga;
        public string tipoCarroceria;
        public double comprimento;
        public double altura;

        public double CalcularValorAluguel(int qtdDias, int capacidadeCarga)
        {

            if (capacidadeCarga > 10000)
            {
                double v = _valorDiarioAluguel + (_valorDiarioAluguel * 0.20);
                v = _valorDiarioAluguel * qtdDias;
                return v;
            }
            else
            {


                double v = _valorDiarioAluguel * qtdDias;
                return v;
            }



        }
    }
}
