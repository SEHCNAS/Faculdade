Algoritmo ConvercaoDolar //Gabriel Sanches - RA: 5929052190
Inicio
	
	Real DolarQtd, DolarTaxaConversao, RealQtd;
	
	Escreva("Digite a taxa de conversão do dolar: ");
	Leia(DolarTaxaConversao);
	
	Escreva("Digite o valor em dolares que sera convertido para reais: ");
	Leia(DolarQtd);
	
	RealQtd = DolarQtd * DolarTaxaConversao;
	
	Escreva("O valor informado convertido para reais é " + RealQtd);

Fim