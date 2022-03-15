import math

Num = float(input('Digite um numero: '))

ValorAbsoluto = math.fabs(Num)
Parteinteira = math.trunc(Num)
Raiz = math.sqrt(Num)
Fatorial = math.factorial(Parteinteira)

print(f'ValorAbsoluto - {ValorAbsoluto}')
print(f'Parteinteira - {Parteinteira}')
print(f'Raiz - {Raiz}')
print(f'Fatorial - {Fatorial}')