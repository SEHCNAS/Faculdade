# Somar 10% ao valor
print('-- Soma 10% ao salario informado --')
try:
    ValorCliente = float(input('Digite o valor gasto: '))

except ValueError as error:
    print(error)
else:
    ValorAcrescido = ValorCliente * 1.10
    print('O valor acrescido de %s é %.2f' % ('10%', ValorAcrescido))
