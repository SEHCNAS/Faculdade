Algoritmo CalculoParcelaComJuros //Gabriel Sanches - RA: 5929052190
Inicio
	Real Valor, ParcelaQtd, ValorParcela;

	Escreva("Digite o valor da compra: ");
	Leia(Valor);
	
	Escreva("Digite a quantidade de parcelas: ");
	Leia(ParcelaQtd);
	
	ValorParcela = CalculaParcela(Valor, ParcelaQtd);
	
	Escreva("O valor da parcela com 5% de juros é: " + ValorParcela);

Fim


Real CalculaParcela(Real Valor, Real ParcelaQtd)
inicio
	Real ValorComJuros;
	
	ValorComJuros = Valor * 1.05;
	
	Retorne(ValorComJuros / ParcelaQtd)
	
fim
