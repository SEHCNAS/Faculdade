try:
    Turno = input('Digte o turno trabalhado\n n(Noturno) ou qualquer tecla para outro horario: ')
    Horas = float(input('Digite a quantidaade de horas trabalhadas: '))
except ValueError as error:
    print(error)
else:
    if Turno.upper() == 'N':
        PrecoHora = 45
    else:
        PrecoHora = 37.50

    Salario = Horas * PrecoHora

    print(f'O valor a ser pago é {Salario:.2f}')
