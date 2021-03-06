"""
PROJETO INTERDISCIPLINAR



Integração das disciplinas
Conversão das bases binário, hexadecimal e octadecimal para a base decimal


Alunos:
RGM	Nome
28604288    Fernanda S. Carillo
29117321    Felipe Moreira Maciel
28805445	Felipe Alves Ferreira
29072123	Rodrigo da S. Campos
29052190	Gabriel Sanches

"""

# Função para validar se a sequencia tem valores aceitos
def validaSequencia(NumSequencia, Base):
    Contador = 0
    IsValido = True

    while Contador < len(NumSequencia):
        match Base:
            case '2':
                if NumSequencia[Contador] not in ('0', '1'):
                    IsValido = False
                    break

            case '8':
                if not NumSequencia[Contador].isnumeric():
                    IsValido = False
                    break
                if int(NumSequencia[Contador]) not in (0, 1, 2, 3, 4, 5, 6, 7):
                    IsValido = False
                    break

            case '16':
                if not NumSequencia[Contador].isnumeric():
                    if NumSequencia[Contador].lower() not in ('a', 'b', 'c', 'd', 'e', 'f'):
                        IsValido = False
                        break

        Contador += 1
    return IsValido


# Função para calcular conversão das bases para decimal
def BinarioOctalHexa_Decimal(NumSequencia, Base):
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
        NumDecimal += NumInt * ((int(Base)**Contador))
        Contador += 1

    return NumDecimal


print('--Converter binario, octal ou hexa para decimal--')

# Cria decionario com os valores correspondentes as letras do hexadecimal e as bases
DicionarioHexadecimal = {'A': 10, 'B': 11, 'C': 12, 'D': 13, 'E': 14, 'F': 15}
DicionarioBases = {'2': 'Binario', '8': 'Octal', '16': 'Hexa'}

# Laço de repetição para permitir que o usuario realize varias conversões em sequencia
IsContinuar = 's'
while IsContinuar.upper() in ('S', 'SIM'):

    # Recebe valor e base para realizar a conversão
    Sequencia = str(input('Digite a sequencia (Binario, octal ou hexa): '))
    Base = str(input('Digite a base da sequencia digitada (2 - Binario, 8 - Octal ou 16 - Hexa): '))

    # entra no while Caso o valor não seja valido
    while Base not in ('16', '2', '8'):
        print('Valor de base invalido!')
        Base = str(input('Digite a base: '))

    # Chama a função que valida a sequencia
    IsValido = validaSequencia(Sequencia, Base)

    if IsValido:
        # Inverte valor para realizar calculo e tira espaços em branco
        SequenciaInvertido = ''.join(reversed(Sequencia.replace(' ', '')))
        # Chama função que realizar conversão
        SequenciaDecimal = BinarioOctalHexa_Decimal(SequenciaInvertido, Base)
        print(f'O valor {Sequencia}({DicionarioBases[Base]}) convertido é {SequenciaDecimal:.0f}(Decimal)')

    else:
        print(f'O valor {Sequencia}, possui valores invalidos para a conversão solicitada')

    IsContinuar = input('Deseja realizar outra conversão? (S/N) ')
