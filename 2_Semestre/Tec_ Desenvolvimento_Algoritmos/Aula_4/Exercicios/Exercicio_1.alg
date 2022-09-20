Algoritmo CalculoGasolina //Gabriel Sanches - RA: 5929052190
Inicio

	Real KmInicial, KmFinal, LitroQtd, LitroPreco;

	Escreva("Digite a quilometragem inicial(KM): ");
	Leia();
	
	Escreva("Digite a quilometragem final(KM): ");
	Leia();
	
	Escreva("Digite a quantidade de litros gastos: ");
	Leia();
	
	Escreva("Digite o preço da gasolina(R$): ");
	Leia();
	
	CalculaDistanciaConsumoValorGasto(KmInicial, KmFinal, LitroQtd, LitroPreco);

Fim 

void CalculaDistanciaConsumoValorGasto (Real KmInicial, Real KmFinal, Real LitroQtd, Real LitroPreco)
inicio

	Real KmPercorridos;
	
	KmPercorridos = KmFinal - KmInicial
	
	Escreva("O valor gasto foi: R$ " + (LitroQtd * LitroPreco) + ", a distancia percorrida foi: " + KmPercorridos + "KM e o consumo medio é: " + (LitroQtd / KmPercorridos))
	
fim
