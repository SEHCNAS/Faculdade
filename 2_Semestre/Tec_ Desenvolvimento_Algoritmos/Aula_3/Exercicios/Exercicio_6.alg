Algoritmo MetrosCerca //Gabriel Sanches - RA: 5929052190
Inicio
	
	Real TrianguloAltura, TrianguloBase, TrianguloFaltante;
	
	Escreva("Digite a base do triangulo: ");
	Leia(TrianguloBase);
	
	Escreva("Digite a altura do triangulo: ");
	Leia(TrianguloAltura);
	
	TrianguloFaltante = raiz((TrianguloBase^2) + (TrianguloAltura^2));

	Escreva("Sera necessario comprar " + TrianguloFaltante + " metros de cerca");
Fim