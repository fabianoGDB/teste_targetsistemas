#Complexidade:

#Tempo: O(n), similar à versão em C#.
#Espaço: O(1), pois não há uso de estruturas adicionais.

faturamento_estados = {
    "SP": 67836.43,
    "RJ": 36678.66,
    "MG": 29229.88,
    "ES": 27165.48,
    "Outros": 19849.53
}

faturamento_total = sum(faturamento_estados.values())  # Calcula o faturamento total

for estado, valor in faturamento_estados.items():  # Calcula o percentual de cada estado
    percentual = (valor / faturamento_total) * 100
    print(f"{estado}: {percentual:.2f}%")
