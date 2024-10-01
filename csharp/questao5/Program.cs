using System;
/*
Uso de um array de caracteres (char[]) para manipular diretamente a inversão dos caracteres, o que é mais eficiente do que manipular strings diretamente (já que strings são imutáveis).
Complexidade:
Tempo: O(n), onde n é o comprimento da string.
Espaço: O(n), já que criamos um array de tamanho n para armazenar os caracteres invertidos.
*/
Console.WriteLine("Escreva um texto desejado para inverter:");
string stringDesejada = Console.ReadLine(); // adiciona 1 a complexidade do código

string Inverter(string str)
{
    var result = new char[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        result[i] = str[str.Length - 1 - i];  // Inverte os caracteres manualmente
    }
    return new string(result);  // Cria uma nova string a partir do array de caracteres
}

Console.WriteLine(Inverter(stringDesejada));

