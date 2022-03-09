Idade = input('Digite sua idade: ')

if not Idade.isnumeric():
    print('A idade é um numero inteiro, digite um valor valido!')
else:
    print(f'A idade digitada foi: {Idade}')
