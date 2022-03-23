try:
    Valor = float(input('Digite o valor da compra: '))
except ValueError as error:
    print(error)
else:
    if Valor > 200:
      Desconto = 0.2
      ValorFinal = Valor - (Valor * Desconto)
      print(f'O valor final com desconto é {ValorFinal}')
    else:
      print('O valor não tem desconto \n O desconto so se aplica para valores acima de 200 reais')
