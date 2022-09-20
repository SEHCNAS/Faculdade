Algoritmo EquacaoSegGrau //Gabriel Sanches - RA: 5929052190
Inicio
	
	Real A, B, C, Delta, PResultado, SResultado;
	
	Escreva("Digite o valor de A: ");
	Leia(A);
	
	Escreva("Digite o valor de B: ");
	Leia(B);
	
	Escreva("Digite o valor de C: ");
	Leia(C);

	Delta = (B^2) - (4*A*C);
	
	PResultado = (-B - Raiz(Delta)) / (2*A);
	
	SResultado = (-B + Raiz(Delta)) / (2*A);
	
	Escreva("O 1º resultado é: " + PResultado);
	Escreva("O 2º resultado é: " + PResultado);
	
Fim