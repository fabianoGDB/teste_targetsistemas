import json

#Complexidade
#Tempo: O(n) — O código processa o arquivo JSON, filtra os valores e faz cálculos em tempo linear.
#Espaço: O(n) — Todos os valores de faturamento válidos (não nulos) são armazenados em uma lista.


# Carregar os dados do arquivo JSON
with open('caminho_para_o_arquivo/dados.json', 'r') as file:
    faturamento_data = json.load(file)

# Filtrar os dias com faturamento > 0
faturamento_valido = [dia["valor"] for dia in faturamento_data if dia["valor"] > 0]

# 1. Menor valor de faturamento
menor_faturamento = min(faturamento_valido)

# 2. Maior valor de faturamento
maior_faturamento = max(faturamento_valido)

# 3. Média de faturamento
media_faturamento = sum(faturamento_valido) / len(faturamento_valido)

# 4. Dias com faturamento acima da média
dias_acima_media = sum(1 for valor in faturamento_valido if valor > media_faturamento)

# Exibir os resultados
print(f"Menor faturamento: {menor_faturamento}")
print(f"Maior faturamento: {maior_faturamento}")
print(f"Dias acima da média: {dias_acima_media}")
