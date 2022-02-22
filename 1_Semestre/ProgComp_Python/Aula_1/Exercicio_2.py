Profissao = input('Digite a sua profissão:')

if not Profissao.isnumeric():
    print(f'a profissão informada foi:{Profissao}')
else:
    print('Digite um valor valido!')
