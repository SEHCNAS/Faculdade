Algoritmo Calculo_AreaVolume //Gabriel Sanches - RA: 5929052190
Inicio
	
	Real CilindroAltura, CilindroRaio, CilindroArea, CilindroVolume;
	
	Escreva("Digite o raio Cilindro: ");
	Leia(CilindroRaio);
	
	Escreva("Digite a altura do cilindro: ");
	Leia(CilindroAltura);
	
	CilindroArea = 3.14 *(CilindroRaio^2);
	CilindroVolume = CilindroAltura * CilindroArea;
	
	Escreva("A area do cilindro é " + CilindroArea + " e o volume é " + CilindroVolume);

Fim