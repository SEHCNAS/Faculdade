Algoritmo CalculoVelocidade //Gabriel Sanches - RA: 5929052190
Inicio

	Real PObjetoTempo, PObjetoDistancia, PObjetoVelocidade, SObjetoTempo, SObjetoDistancia, SObjetoVelocidade, TObjetoTempo, TObjetoDistancia, TObjetoVelocidade;
	
	Escreva("Digite o tempo que o primeiro objeto levou para percorrer a distancia: ");
	Leia(PObjetoTempo);
	
	Escreva("Digite a distancia que o primeiro objeto percorreu: ");
	Leia(PObjetoDistancia);
	
	PObjetoVelocidade = CalculoDaVelocidade(PObjetoDistancia, PObjetoTempo);
	
	Escreva("O primeiro objeto percorreu a distancia com a velocidade de: " + PObjetoVelocidade)
	
	Escreva("Digite o tempo que o segundo objeto levou para percorrer a distancia: ");
	Leia(SObjetoTempo);
	
	Escreva("Digite a distancia que o segundo objeto percorreu: ");
	Leia(SObjetoDistancia);
	
	SObjetoVelocidade = CalculoDaVelocidade(SObjetoDistancia, SObjetoTempo);
	
	Escreva("O segundo objeto percorreu a distancia com a velocidade de: " + SObjetoVelocidade)
	
	Escreva("Digite o tempo que o terceiro objeto levou para percorrer a distancia: ");
	Leia(TObjetoTempo);
	
	Escreva("Digite a distancia que o terceiro objeto percorreu: ");
	Leia(TObjetoDistancia);
	
	TObjetoVelocidade = CalculoDaVelocidade(TObjetoDistancia, TObjetoTempo);
	
	Escreva("O terceiro objeto percorreu a distancia com a velocidade de: " + TObjetoVelocidade)

Fim

Real CalculoDaVelocidade(Real ObjetoDistancia, Real ObjetoTempo)
inicio

	Retorne(ObjetoDistancia / ObjetoTempo);
	
fim