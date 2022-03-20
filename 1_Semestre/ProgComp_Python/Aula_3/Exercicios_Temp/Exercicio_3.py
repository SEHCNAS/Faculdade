# Conversão de dias ano e meses em somente dias
import math
print('--Programa para converter de dias ano e meses em somente dias--')
try:
    # Pega os valores bases para realizar o calculo
    Anos = int(input('Digite o valor de horas a ser convertido: '))
    Meses = int(input('Digite o valor de horas a ser convertido: '))
    Dias = int(input('Digite o valor de horas a ser convertido: '))

except ValueError as error:
    # Mostra a mensagem de erro caso ocorra
    print(F'Ocorreu o seguinte erro: {error}')

else:
    # Realiza o calculo
    TempoDias = 0
    # Converte anos em dias
    TempoDias += Anos * 365
    # Converte meses em dias - Considerando o mes com 30 dias
    TempoDias += Meses * 30
    # Soma os dias
    TempoDias += Dias

    print(f'O tempo de vida em dias é {TempoDias}')
