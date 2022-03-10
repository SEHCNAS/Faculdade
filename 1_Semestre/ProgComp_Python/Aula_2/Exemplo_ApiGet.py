import requests
# import json


def Buscar_Dados():
    request = requests.get('https://economia.awesomeapi.com.br/last/USD-BRL')
    print(request.content)


if __name__ == '__main__':
    Buscar_Dados()
