from ApiDolar import Buscar_Dados
print('-- Conversaõ de dolares para real com api --')

# Retorna so somente um item do json - Buscar_Dados()['USDBRL']['bid']
# Retorna o json inteiro - Buscar_Dados()
CotacaoDolar = float(Buscar_Dados()['USDBRL']['bid'])

Dolares = float(input('Digite a quantidade de dolares: '))

ValorConvertido = Dolares * CotacaoDolar

print('O valor convertido é %.2f Reais' % (ValorConvertido))
