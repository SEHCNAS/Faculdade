# Calculo do volume de um tronco de uma arvore
import math
print('--Programa para calcular o volume de um tronco de uma pirâmide--')
try:
    # Pega os valores bases para realizar o calculo
    AlturaTronco = float(input('Digite o valor da altura do tronco: '))
    BaseMenor = float(input('Digite o valor da base menor: '))
    BaseMaior = float(input('Digite o valor da base maior: '))

except ValueError as error:
    # Mostra a mensagem de erro caso ocorra
    print(F'Ocorreu o seguinte erro: {error}')

else:
    # Realiza o calculo
    BaseMaiorElevado = math.pow(BaseMaior, 2)
    BaseMenorElevado = math.pow(BaseMenor, 2)

    Volume = (AlturaTronco/3) * (BaseMaiorElevado + BaseMenorElevado + (math.sqrt(BaseMaiorElevado * BaseMenorElevado)))

    print(f'O volume do tronco é: {Volume}')
    