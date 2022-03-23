try:
    Num = int(input('Digite um numero entre 0 e 9: '))
except ValueError as error:
    print(error)
else:
    if Num in range(0, 10):
        print('Valor correto!')
    else:
        print('Valor incorreto!')
