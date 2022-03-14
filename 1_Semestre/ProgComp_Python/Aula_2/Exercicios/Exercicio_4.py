import math
# Calculo equação de 2º grau
print('-- Calculo equação de 2º grau --')
try:
    A = float(input('Digite o valor de A: '))
    B = float(input('Digite o valor de B: '))
    C = float(input('Digite o valor de C: '))

except ValueError as error:
    print(f'Essa equação não aceita letras, {error}')

else:
    Delta = (B ** 2)-4*A*C
    print(Delta)

    if Delta == 0:
        A1 = (-B + Delta) / (2*A)
        print(A1)
    elif Delta < 0:
        print('Não foi possivel calcular, delta negativo')
    else:
        raiz = math.sqrt(Delta)
        A1 = (-B + raiz) / (2*A)
        A2 = (-B - raiz) / (2*A)
        print('O resultado A1 = %.4F e A2 = %.4F' % (A1, A2))
        # print(f'O resultado A1 = {A1:.2F} e A2 = {A2:.2F}')

