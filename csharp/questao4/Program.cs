using System;
/*
Uso de desconstrução no foreach para facilitar a leitura dos pares estado e valor.
LINQ para sumarizar os valores.
Complexidade:
Tempo: O(n), para iterar sobre os estados e somar.
Espaço: O(1), pois estamos iterando diretamente sobre os dados sem criar estruturas adicionais.
*/

var faturamentoEstados = new Dictionary<string, double>
{
    {"SP", 67836.43},
    {"RJ", 36678.66},
    {"MG", 29229.88},
    {"ES", 27165.48},
    {"Outros", 19849.53}
};

double faturamentoTotal = faturamentoEstados.Values.Sum();  // Usa LINQ para somar os valores

foreach (var (estado, valor) in faturamentoEstados)  // Desconstrução para chave e valor do dicionário
{
    double percentual = (valor / faturamentoTotal) * 100;
    Console.WriteLine($"{estado}: {percentual:F2}%");
}
