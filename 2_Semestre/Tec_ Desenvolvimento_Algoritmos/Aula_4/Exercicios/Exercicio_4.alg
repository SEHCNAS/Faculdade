Algoritmo EquacaoSegGrau_v2 //Gabriel Sanches - RA: 5929052190
Inicio
	
	Real A, B, C, Delta, PResultado, SResultado;
	
	Escreva("Digite o valor de A: ");
	Leia(A);
	
	Escreva("Digite o valor de B: ");
	Leia(B);
	
	Escreva("Digite o valor de C: ");
	Leia(C);

	Delta = getDelta(A, B, C);
	
	PResultado = getX1(A, B, Delta);
	
	SResultado = getX2(A, B, Delta);
	
	Escreva("O 1º resultado é: " + PResultado);
	Escreva("O 2º resultado é: " + PResultado);
	
Fim

Real getDelta(Real a, Real b, Real c)
inicio

	Retorne((B^2) - (4*A*C));
	
fim

Real getX1(Real a, Real b, Real delta)
inicio

	Retorne(((b * -1) - RaizQuad(Delta)) / (2*a));
	
fim

Real getX2(Real a, Real b, Real delta)
inicio

	Retorne(((b * -1) + RaizQuad(Delta)) / (2*a));
	
fim