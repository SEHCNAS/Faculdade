Algoritmo ConverteMoedasEmReais //Gabriel Sanches - RA: 5929052190
Inicio
	
	inteiro VinteCinco, Dez, Cinco;
	
	Escreva("Digite a quantidade de moedas de 25 centavos: ");
	Leia(VinteCinco);
	
	Escreva("Digite a quantidade de moedas de 10 centavos:");
	Leia(Dez);
	
	Escreva("Digite a quantidade de moedas de 5 centavos:");
	Leia(Cinco);
	
	ValorCofre(VinteCinco, Dez, Cinco);
	
Fim

void ValorCofre(inteiro VinteCinco, inteiro Dez, inteiro Cinco)
Inicio

	Escreva("O valor em reais é: " + ((VinteCinco * 0.25) + (Dez * 0.10) + (Cinco * 0.05)));
	
Fim