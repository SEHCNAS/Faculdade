# Realiza a conversão de dolares
print('-- Conversão de dolares para real --')
try:
    CotacaoDolar = float(input('Digite a atual cotação do dolar: '))
    Dolares = float(input('Digite a quantidade de dolares: '))

except ValueError as error:
    print(f'Ocorreu um erro com os valores digitados - {error}')

else:
    ValorConvertido = Dolares * CotacaoDolar
    print('O valor convertido é %.2f Reais' % (ValorConvertido))
