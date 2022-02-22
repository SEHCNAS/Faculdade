Esporte = input('Digite o nome do seu esporte favorito: ')

if not Esporte.isnumeric():
    print(f'O seu esporte favorito é {Esporte}')
else:
    print('Digite um nome valido!')