Algoritmo AreasRetangulos_v2 //Gabriel Sanches - RA: 5929052190
Inicio
	
	real PRetangulo_Largura, PRetangulo_Altura, PRetangulo_Area;
	
	
	Escreva("Digite a altura do 1º retangulo: ");
	Leia(PRetangulo_Altura);
	
	Escreva("Digte a largura do 1º retangulo: ");
	Leia(PRetangulo_Largura);
		
	PRetangulo_Area = CalculoAreaRetangulo(PRetangulo_Altura, PRetangulo_Largura)
		
	Escreva("A area do retangulo é: " + PRetangulo_Area);

Fim

Real CalculoAreaRetangulo(Real PRetangulo_Altura, Real PRetangulo_Largura)
inicio

	Retorne (PRetangulo_Largura * PRetangulo_Altura);

fim
