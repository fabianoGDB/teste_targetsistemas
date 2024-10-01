#Complexidade:

#Tempo: O(n). O laço percorre cada caractere uma vez.
#Espaço: O(n), pois a string resultado cresce proporcionalmente ao tamanho da string original.

def inverter_string(s):
    resultado = ''  # Cria uma string vazia para armazenar o resultado
    for char in s:  # Itera sobre a string original
        resultado = char + resultado  # Coloca o caractere no início da nova string
    return resultado

string = "exemplo"
print(inverter_string(string))
