Algoritmo CalculoImc //Gabriel Sanches - RA: 5929052190
Inicio
	
	Real Peso, Altura;
	
	Escreva("Digite o peso do usuario: ");
	Leia(Peso);
	
	Escreva("Digite a altura do usuario: ");
	Leia(Altura);
	
	CalculaImc(Altura, Peso);
	
Fim

void CalculaImc(Real Altura, Real Peso)
Inicio

	Escreva("O valor do IMC é: " + (Peso / (Altura^2)));
	
Fim