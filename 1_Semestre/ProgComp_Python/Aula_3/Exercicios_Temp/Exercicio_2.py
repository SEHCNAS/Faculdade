# Conversão de horas para minutos
import math
print('--Programa para converter as horas em minutos--')
try:
    # Pega os valores bases para realizar o calculo - valor depois do ponto é considerado minutos
    TempoHoras = float(input('Digite o valor de horas a ser convertido: '))

except ValueError as error:
    # Mostra a mensagem de erro caso ocorra
    print(F'Ocorreu o seguinte erro: {error}')

else:
    # Realiza o calculo
    TempoMinutos = math.trunc(TempoHoras) * 60
    # Tempo valores depois do ponto e converte em decimal
    TempoMinutos += math.modf(TempoHoras)[0] * 100

    print('O valor em  horas: %.2f é equivalente a %.2f em minutos ' % (TempoHoras, TempoMinutos))
