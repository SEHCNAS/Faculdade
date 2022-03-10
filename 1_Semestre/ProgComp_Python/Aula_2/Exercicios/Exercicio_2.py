# somar 5% ao salario informado
try:
    Salario = float(input('Digite o salario: '))

except ValueError as error:
    print(f'Ocorreu o seguinte erro - {error}')

else:
    SalarioAcrescido = Salario * 1.05
    print(f'O salario acrescido de 5% é {SalarioAcrescido}')
