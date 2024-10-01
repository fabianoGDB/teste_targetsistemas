#Complexidade:
#Tempo: O(log(n)). O mesmo raciocínio da versão em C#.
#Espaço: O(1). Apenas as variáveis a e b são usadas para calcular a sequência.

def is_fibonacci(num):
    a, b = 0, 1  # Inicializa os dois primeiros números de Fibonacci
    while a <= num:
        if a == num:  # Se o número for encontrado na sequência, retorna a mensagem
            return f"O número {num} pertence à sequência de Fibonacci."
        a, b = b, a + b  # Avança para o próximo número da sequência
    return f"O número {num} não pertence à sequência de Fibonacci."

num = 21
print(is_fibonacci(num))
