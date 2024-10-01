using System;

/*
A primeira questão a menor complexidade seria o uso de um simples laço de repetição for que percorre todos os itens
Complexidade:
Tempo: O(n), onde n é o valor de INDICE. O laço é executado n vezes, somando cada valor de K.
Espaço: O(1), pois apenas variáveis inteiras são usadas (INDICE, SOMA e K), independentemente do valor de INDICE*/

int indice = 13;
int soma = Enumerable.Range(1, indice).Sum();  // Uso de LINQ para calcular a soma de 1 até o índice

Console.WriteLine(soma);

