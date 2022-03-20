# programa para calcular prestacao em atraso
try:
    ValorpPestacao = float(input("digite o valor da prestação: "))

    PorcetagemDaMulta = float(input("digite a porcentagem do valor da multa: "))

    qtdedias = float(input("digite os dias de atraso: "))

except ValueError as error:
    print(f'Ocorru o seguinte erro: {error}')

else:
    prestacao = ValorpPestacao + ((ValorpPestacao*(PorcetagemDaMulta/100))*qtdedias)
    print(f"valor da prestação com a multa {prestacao}")
    