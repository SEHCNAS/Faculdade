import math

# Função para calcular conversão das bases para decimal
def CalculaOctalHexa(NumSequencia, Base):
    Contador = 0
    NumDecimal = 0

    # Realiza os calculos enquanto
    # o contador for menor que o numero de caracteres digitados

    while Contador < len(NumSequencia):
        if Base == '16':
            if NumSequencia[Contador].isnumeric():
                NumInt = int(NumSequencia[Contador])

            else:
               NumInt = DicionarioHexadecimal[NumSequencia[Contador].upper()]

        else:
            NumInt = int(NumSequencia[Contador])
        NumDecimal += NumInt * (math.pow(int(Base), Contador))
        Contador += 1
    print(NumDecimal)


print('--Converter binario, octal ou hexa para decimal--')

# Cria decionario com os valores correspondentes as letras do hexadecimal
DicionarioHexadecimal = {'A': 10, 'B': 11, 'C': 12, 'D': 13, 'E': 14, 'F': 15}

# Recebe valor e base para realizar a conversão
Sequencia = str(input('Digite a sequencia (Binario, octal ou hexa) : '))
Base = str(input('Digite a base da sequencia digitada (2, 8 ou 16) : '))

# entra no while Caso o valor não seja valido
while Base not in ('16', '2', '8'):
    print('Valor de base invalido!')
    Base = str(input('Digite a base: '))

# Inverte valor para realizar calculo e tira espaços em branco
SequenciaInvertido = ''.join(reversed(Sequencia.replace(' ', '')))

# Chama função que realizar conversão
CalculaOctalHexa(SequenciaInvertido, Base)
