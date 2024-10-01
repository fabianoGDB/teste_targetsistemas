/*
Uso de desconstrução (a, b) = (b, a + b) para atualização dos valores de Fibonacci de forma mais legível.
Função com escopo claro e reutilizável.
Complexidade:
Tempo: O(log(n)), como antes.
Espaço: O(1), já que estamos usando apenas variáveis de controle.
*/

Console.WriteLine("Escreva um inteiro para saber se faz parte ou não da sequência fibonacci:");
int num = Convert.ToInt32(Console.ReadLine()); // adiciona 1 a complexidade do código

bool IsFibonacci(int num)
{
    int a = 0, b = 1;

    while (a <= num)
    {
        if (a == num)
            return true;

        (a, b) = (b, a + b);  // Desconstrução usada para atribuição de valores

    }

    return false;
}

Console.WriteLine(IsFibonacci(num)
    ? $"O número {num} pertence à sequência de Fibonacci."
    : $"O número {num} não pertence à sequência de Fibonacci.");
