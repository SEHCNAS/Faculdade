# Calculo velocidade media
try:
    Distancia = float(
        input('Qual a distancia entre as cidades: ').replace(
            'KM', '').replace('km', ''))
    Tempo = float(
        input('Qual o tempo de viagem: ').replace(
            'horas', '').replace('h', ''))

except ValueError as error:
    print(error)

else:
    VelocidadeMedia = Distancia/Tempo
    print(f'A velocidade media é {VelocidadeMedia}')
