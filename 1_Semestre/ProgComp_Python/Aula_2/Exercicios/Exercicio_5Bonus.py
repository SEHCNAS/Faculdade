from pip._vendor import requests
import json


def Buscar_Dados():
    # Url com o parametro da moeda fixo
    request = requests.api.get(
        'https://economia.awesomeapi.com.br/last/USD-BRL')
    # pega o retorno e joga em um json
    resp = json.loads(request.content)
    return resp


# Retorna so somente um item do json - Buscar_Dados()['USDBRL']['bid']
# Retorna o json inteiro - Buscar_Dados()
CotacaoDolar = float(Buscar_Dados()['USDBRL']['bid'])

Dolares = float(input('Digite a quantidade de dolares: '))

ValorConvertido = Dolares * CotacaoDolar

print('O valor convertido é %.2f Reais' % (ValorConvertido))