import math
NumeroDecimal = float(input('Digite o numero na base 10: '))

# Converte numero de float para inteiro
NumeroInt = math.trunc(NumeroDecimal)

# Pega o valor inteiro da divisão para continuar a conversão para binario -
RestoInteiro = NumeroInt // 2

# Pega o valor que sera utilizado para compor a sequencia binaria
SobraInteiro = NumeroInt % 2

# Print para teste
# print(f'Divisor = {RestoInteiro}')
# print(f'Sobra = {SobraInteiro}')
Binario = f'{SobraInteiro}'

while RestoInteiro >= 2:
    SobraInteiro = RestoInteiro % 2
    RestoInteiro = RestoInteiro // 2
    # Print para teste
    # print(f'Divisor = {RestoInteiro}')
    # print(f'Sobra = {SobraInteiro}')
    Binario += f'{SobraInteiro}'
Binario += f'{RestoInteiro}'
Binario = ''.join(reversed(Binario))
print(f'Binario = {Binario}')
