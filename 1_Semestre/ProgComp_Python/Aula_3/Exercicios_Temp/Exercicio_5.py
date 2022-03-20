# Converter angulo para radio e pegar o seno, cosseno e tangente
import math
print('--Programa para converter angulo para radio e pegar o seno, cosseno e tangente--')
try:
    # Pega os valores bases para realizar o calculo
    Angulo = int(input('Digite o valor do angulo: '))

except ValueError as error:
    # Mostra a mensagem de erro caso ocorra
    print(F'Ocorreu o seguinte erro: {error}')

else:
    # Realiza o calculo do cosseno, seno e tangente
    Radiano = math.radians(Angulo)
    cos = math.cos(Radiano)
    sen = math.sin(Radiano)
    tan = math.tan(Radiano)

    print(f'O o cosseno é: {cos:.3f}\n'
          f'A tangente é: {tan:.3f}\n'
          f'O seno é: {sen:.3f}')
