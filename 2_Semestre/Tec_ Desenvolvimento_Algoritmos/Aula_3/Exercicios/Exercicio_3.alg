Algoritmo AreasRetangulos //Gabriel Sanches - RA: 5929052190
Inicio
	
	real PRetangulo_Largura, SRetangulo_Largura, Retangulos_Altura, PRetangulo_Area, SRetangulo_Area, AreaTotal;
	
	Escreva("Como os retangulos possuem a mesma altura digite ela somente uma vez!");
	
	Escreva("Digite a altura: ");
	Leia(Retangulos_Altura);
	
	Escreva("Digte a largura do 1º retangulo: ");
	Leia(PRetangulo_Largura);
	
	Escreva("Digte a largura do 2º retangulo: ");
	Leia(SRetangulo_Largura);
	
	PRetangulo_Area = PRetangulo_Largura * Retangulos_Altura;
	SRetangulo_Area = SRetangulo_Largura * Retangulos_Altura;
	AreaTotal = SRetangulo_Area + PRetangulo_Area;
	
	Escreva("A area do 1º retangulo é: " + PRetangulo_Area);
	Escreva("A area do 2º retangulo é: " + SRetangulo_Area);
	
	Escreva("A area total dos 2 retangulo é: " + PRetangulo_Area);

Fim