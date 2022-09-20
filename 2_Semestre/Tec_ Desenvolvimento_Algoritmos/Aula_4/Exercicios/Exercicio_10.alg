Algoritmo ConvercaoDolar_v2 //Gabriel Sanches - RA: 5929052190
Inicio
	
	Real DolarQtd, DolarTaxaConversao, RealQtd;
	
	Escreva("Digite a taxa de conversão do dolar: ");
	Leia(DolarTaxaConversao);
	
	Escreva("Digite o valor em reais que sera convertido para doalres: ");
	Leia(RealQtd);
	
	DolarQtd = ConverteRealEmDolar(RealQtd, DolarTaxaConversao);
	
	Escreva("O valor informado convertido para dolares é " + DolarQtd);

Fim

Real ConverteRealEmDolar(Real RealQtd, Real DolarTaxaConversao)
Inicio 
Retorne (RealQtd * DolarTaxaConversao;)
Fim