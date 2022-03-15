Num = int(input('Digite um numero com 3 digitos: '))
d1 = Num//100
d2 = Num%100//10
d3 = Num%10
print(f'Digito 1 - {d1}')
print(f'Digito 2 - {d2}')
print(f'Digito 3 - {d3}')

inverso = d3 * 100 + d2 * 10 + d1 * 1
print(f'O numero inverso = {inverso}')

