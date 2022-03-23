try:
    Salario = float(input('Digite o valor do salario: '))
    Contador = 1
    Contas = 0
    while Contador <= 3:
        Contas += float(input(f'Digite o valor da {Contador}º Conta: '))
        Contador += 1
except ValueError as error:
    print(error)
else:
    SalarioContas = Salario - Contas

    if SalarioContas < 0:
        print('Salario insuficiente')
    else:
        print(f'SObrou {SalarioContas} do salario')
