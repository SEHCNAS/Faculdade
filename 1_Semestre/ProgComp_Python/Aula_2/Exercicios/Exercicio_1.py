# Calculo area e perimetro do retangulo
print('-- Calculo da base e perimetro de um retangulo --')
AlturaRetangulo = float(input('Digite a altura do retangulo: '))
BaseRetangulo = float(input('Digite a Base(Largura) do retangulo: '))

if AlturaRetangulo == BaseRetangulo:
    print('As informações não batem '
          'com as caracteristica de um retangulo'
          ' - A base não pode ser igual a altura')
else:
    AreaRetangulo = AlturaRetangulo * BaseRetangulo
    PerimetroRetangulo = 2*(BaseRetangulo + AlturaRetangulo)
    print(f'A area do retangulo é {AreaRetangulo} e o'
          f' perimetro é {PerimetroRetangulo}')
