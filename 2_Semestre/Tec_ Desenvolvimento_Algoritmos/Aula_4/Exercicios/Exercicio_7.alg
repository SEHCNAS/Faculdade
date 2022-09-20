Algoritmo CalculoComissao //Gabriel Sanches - RA: 5929052190
Inicio
	
	Real TelheiroQtd, QuadradoQtd, Resultado, Comissao;
	
	Escreva("Digite a quantidade de telheiros: ");
	Leia(TelheiroQtd);
	
	Escreva("Digite a quantidade de quadrados: ");
	Leia(QuadradoQtd);
	
	Resultado = (TelheiroQtd * 1.05) + (QuadradoQtd * 0.51);
	
	Comissao = Resultado * 0.10;
	
	Escreva("O valor ganho no final do dia é: " + Resultado + ", e o valor da comissão é: " +Comissao);

Fim