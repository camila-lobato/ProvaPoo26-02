
using prova26_02.models;

Veiculos v1 = new Veiculos();

Carros carro = new Carros();

Motos moto = new Motos();

Caminhoes caminhao = new Caminhoes();

Alugueis alugueis = new Alugueis();


carro._valorDiarioAluguel = 10;
moto._valorDiarioAluguel = 10;
caminhao.capacidadeCarga = 100000;
caminhao._valorDiarioAluguel = 10;

v1._valorDiarioAluguel = -10;

Console.WriteLine($"Valor do aluguel calculado pela classe aluguel: {alugueis.CalcularAluguel(v1, new DateTime(2025, 01, 01), new DateTime(2025,01,05))}");
Console.WriteLine($"Valor do aluguel calculado pela classe aluguel: {alugueis.CalcularAluguel(carro, new DateTime(2025, 01, 01), new DateTime(2025, 01, 05))}");
Console.WriteLine($"Valor do aluguel calculado pela classe aluguel: {alugueis.CalcularAluguel(moto, new DateTime(2025, 01, 01), new DateTime(2025, 01, 05))}");
Console.WriteLine($"Valor do aluguel calculado pela classe aluguel: {alugueis.CalcularAluguel(caminhao, new DateTime(2025, 01, 01), new DateTime(2025, 01, 05))}");
Console.WriteLine($"Valor total do aluguel do carro: {carro.CalcularValorAluguel(10)}");
Console.WriteLine($"Valor total do aluguel da moto: {moto.CalcularValorAluguel(10)}");
Console.WriteLine($"Valor total do aluguel do caminhão: {caminhao.CalcularValorAluguel(10,caminhao.capacidadeCarga)}");


