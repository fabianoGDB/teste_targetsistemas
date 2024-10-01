#A primeira questão a menor complexidade seria o uso de um simples laço de repetição for que percorre todos os itens
#Complexidade
#Tempo: O(n) (mesmo raciocínio que a versão em C#).
#Espaço: O(1), já que as variáveis são do tipo inteiro e o consumo de memória é constante.
INDICE = 13
SOMA = 0

for K in range(1, INDICE + 1): # Laço que itera de 1 até INDICE
    SOMA += K ## Cada valor do K sera somado

print(SOMA)
