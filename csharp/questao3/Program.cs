using System;
using System.Xml.Linq;

/*Complexidade do Código:
Tempo: O(n)

Duas iterações sobre os elementos do XML (primeira para calcular soma, menor e maior, e a segunda para contar dias acima da média). Cada iteração percorre todos os dias, resultando em complexidade linear.
Espaço: O(1)

O uso de memória é constante, independentemente do número de dias, já que não armazenamos os valores em listas intermediárias, apenas utilizamos variáveis acumuladoras.
*/

// Carregar o arquivo 

string filePath = "dados.xml";
XDocument xmlDocument = XDocument.Load(filePath);

// Variáveis para armazenar o menor, maior e a soma do faturamento
double menorFaturamento = double.MaxValue;
double maiorFaturamento = double.MinValue;
double somaFaturamento = 0;
int diasComFaturamento = 0;
int diasAcimaMedia = 0;

// Primeira iteração para calcular menor, maior e soma
foreach (var row in xmlDocument.Descendants("row"))
{
    double valor = double.Parse(row.Element("valor").Value);

    // Ignorar dias sem faturamento
    if (valor > 0)
    {
        // Atualizar menor e maior faturamento
        if (valor < menorFaturamento) menorFaturamento = valor;
        if (valor > maiorFaturamento) maiorFaturamento = valor;

        // Somar o valor para calcular a média posteriormente
        somaFaturamento += valor;
        diasComFaturamento++;
    }
}

// Calcular a média de faturamento
double mediaFaturamento = somaFaturamento / diasComFaturamento;

// Segunda iteração para contar os dias com faturamento acima da média
foreach (var row in xmlDocument.Descendants("row"))
{
    double valor = double.Parse(row.Element("valor").Value);

    if (valor > 0 && valor > mediaFaturamento)
    {
        diasAcimaMedia++;
    }
}

// Exibir os resultados
Console.WriteLine($"Menor faturamento: {menorFaturamento}\nMaior faturamento: {maiorFaturamento}\nDias com faturamento acima da média: {diasAcimaMedia}");
